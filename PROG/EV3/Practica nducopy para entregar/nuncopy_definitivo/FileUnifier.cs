﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuncopy_definitivo
{
    public class FileUnifier
    {
        private List<Ufile> _files = new List<Ufile>();
        private List<Ufile> _duplicades = new List<Ufile>();
        private List<string> _directories = new List<string>();
        private string? _outputPath = string.Empty;
        private int _success = 0;
        private int _errors = 0;

        public bool IsOutputPathSet => !string.IsNullOrEmpty(_outputPath);
        public bool HasDirectories => _directories.Count > 0;
        public bool HasFiles => _files.Count > 0;
        public bool HasDuplicades => _duplicades.Count > 0;
        public bool ExportDuplicates { get; set; } = false;
        public bool HasErrors => _errors > 0;
        

        public void AddFile(Ufile file)
        {
            if (file == null)
                throw new ArgumentNullException("No se encontro el archivo");
            _files.Add(file);
        }

        public void AddDirectory(string pathDirectory)
        {
            if (Directory.Exists(pathDirectory))
                _directories.Add(pathDirectory);
            else
                Console.WriteLine($"El directorio '{pathDirectory}' no existe.");
        }

        public void ListFiles()
        {
            foreach(string dir in _directories)
            {
                string[] files = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    Ufile f = new Ufile()
                    {
                        PathFile = file,
                        Hash = FileReader.GetHash(file),
                        Size = FileReader.GetSize(file),
                        Disabled = false,
                    };
                    _files.Add(f);
                }
            }
        }
        

        public void CompareFiles()
        {
            for (int i = 0; i < _files.Count; i++)
            {
                if (_files[i].Disabled)
                    continue;
                var file1 = _files[i];

                for (int j = i + 1; j < _files.Count; j++)
                {
                    var file2 = _files[j];
                    if (file1.Hash == file2.Hash)
                    {
                        long size1 = FileReader.GetSize(file1.PathFile);
                        long size2 = FileReader.GetSize(file2.PathFile);
                       
                        if (size1 == size2)
                        {
                            if (FileReader.CompareFilesByBytes(file1, file2))
                            {
                                file2.Disabled = true;
                                _duplicades.Add(file2);
                            }
                        }
                    }
                }
            }
        }

        public void CopyFiles()
        {
            if (!IsOutputPathSet || !HasDirectories || !HasFiles)
                throw new ArgumentNullException("No se encontro el directorio de salida");

            string? directoryPathParent = Directory.GetParent(_directories[0]).FullName;
            foreach (var file in _files)
            {
                if (file.Disabled)
                    continue;
                string targetPath = Path.Combine(_outputPath, file.PathFile.Substring(directoryPathParent.Length + 1));
                string targetDirPath = Path.GetDirectoryName(targetPath);
                if (!Directory.Exists(targetDirPath))
                    Directory.CreateDirectory(targetDirPath);
                else if (File.Exists(targetPath))
                {
                    _errors++;
                    Console.WriteLine($"El archivo '{file.PathFile}' ya existe en '{targetPath}.'");
                    continue;
                    
                }
                File.Copy(file.PathFile, targetPath);
                Console.WriteLine($"Copiando archivo '{file.PathFile}' a '{targetPath}'");
                _success++;
                
            }
            Console.WriteLine($"Se copiaron {_success} archivos con éxito y hubo {_errors} errores.");
        }

        private (string targetPath, string? targetDirPath) GetDestinationRoute(string filePath, string parentDirectoryPath, Ufile file)
        {
            // Esta línea obtiene la ruta relativa del archivo dentro del directorio de origen.
            string relativePath = parentDirectoryPath != null ? filePath.Substring(parentDirectoryPath.Length + 1) : file.PathFile;
            string targetPath = Path.Combine(_outputPath, relativePath);
            string? targetDirPath = Path.GetDirectoryName(targetPath);
            return (targetPath, targetDirPath);
        }

        public void SetOutputPath(string outputPath)
        {
            if (!Directory.Exists(outputPath))
            {
                Console.WriteLine($"El directorio '{outputPath}' no existe. Creando el directorio en el escritorio...");

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                _outputPath = Path.Combine(desktopPath, "nuncopyOutputFile");

                Directory.CreateDirectory(_outputPath);
            }
            else
            {
                _outputPath = Path.Combine(outputPath, "nuncopyOutputFile");
                Directory.CreateDirectory(_outputPath);
            }
        }
    }
}