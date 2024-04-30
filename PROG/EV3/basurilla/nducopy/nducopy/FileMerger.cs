﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace nducopy
{
    public class FileMerger
    {
        private string _pathOut = string.Empty;
        private string _name = string.Empty;
        private List<string> _directories = new List<string>();
        private List<FileUser> _files = new List<FileUser>();
        private List<FileUser> _duplicates = new List<FileUser>();
        private bool _isDuplicate = false;
        private bool _isSuccess = false;

        public bool IsSetPathOut => !string.IsNullOrEmpty(_pathOut);
        public string Name => _name;
        public bool HasDirectories => _directories.Count > 0;
        public bool HasFiles => _files.Count > 0;
        public bool ExportDuplicates { get; set; }
        public bool ControlOutputContain { get; set; }
        public bool IsDuplicate { get => _isDuplicate; }

        //public DuplicateFileGestor(string ruta)
        //{
        //    _pathOut = ruta;
        //    _name = System.IO.Path.GetFileName(ruta);

        //}

        public void AddDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                _directories.Add(path);
            }
        }

        public void SetPathOut(string path)
        {
            if (Directory.Exists(path))
            {
                string newPath = Path.Combine(path, "newFileCombined");
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                _pathOut = newPath;
            }
        }

        public void ListFiles()
        {
            foreach (string directory in _directories)
            {
                string[] allfiles = Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories);
                foreach (string file in allfiles)
                {
                    FileUser fileUser = new FileUser(file)
                    {
                        Path = file,
                        Hash = FileGestor.GetHashFromFile(file),
                        Size = new FileInfo(file).Length,
                    };
                    _files.Add(fileUser);
                }
            }
        }

        public void CompareFiles()
        {
            for (int i = 0; i < _files.Count; i++)
            {
                if (_files[i].Disabled)
                    continue;
                for (int j = i + 1; j < _files.Count; j++)
                {
                    var file1 = _files[i];
                    var file2 = _files[j];
                    if (file2.Disabled)
                        continue;
                    if (file1.Hash == file2.Hash && file1.Size == file2.Size)
                    {
                        file2.Disabled = true;
                        _duplicates.Add(file2);
                    }
                }
            }
        }

        public void CopyFiles()
        {
            if (!IsSetPathOut || !HasDirectories || !HasFiles)
                return;

            string directoryPath = Directory.GetParent(_directories[0]).FullName;
            if (directoryPath == null)
                throw new Exception("Error al obtener la ruta del directorio");

            //foreach (var file in _files)
            //{
            //    if(file.Disabled)
            //        continue;
            //    string filePath = file.Path;
            //    var path = GetDestinationRoute()
            //}

            foreach (var file in _files)
            {
                if (file.Disabled)
                    continue;

                string destinationPath = Path.Combine(_pathOut, Path.GetFileName(file.Path));

                try
                {
                    File.Copy(file.Path, destinationPath, true);
                    Console.WriteLine($"El archivo {file.Path} fue copiado a {destinationPath}.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al copiar el archivo {file.Path}: {ex.Message}");
                }
            }
        }

        public void MakeTextFileOfDuplicates()
        {
            if (!ExportDuplicates || _duplicates.Count == 0)
                return;
            string filePath = Path.Combine(_pathOut, "duplicates.txt");
            using (Stream stream = File.Open(filePath, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    foreach (var file in _duplicates)
                        writer.WriteLine(file.Path);
                }
            }
        }
    }
}