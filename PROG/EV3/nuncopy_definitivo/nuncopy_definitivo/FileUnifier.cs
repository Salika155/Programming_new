using System;
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
        

        public void AddFile(Ufile file)
        {
            if (file == null)
                throw new ArgumentNullException("No se encontro el archivo");
            _files.Add(file);
        }

        public void AddDirectory(string pathDirectoriy)
        {
           if(Directory.Exists(pathDirectoriy))
                _directories.Add(pathDirectoriy);
           Directory.CreateDirectory(_outputPath);
                
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
            //TODO: implementar la copia de archivos
            //esto creo que seria mejor encapsularlo en un metodo aparte
            if (!IsOutputPathSet || !HasDirectories || !HasFiles || HasDuplicades)
                throw new ArgumentNullException("No se encontro el directorio de salida");
            
        }

        //public string[] FindDuplicates(string[] stringfiles)
        //{
        //    var hashes = new HashSet<string>();
        //    var duplicates = new HashSet<string>();

        //    foreach (var file in stringfiles)
        //    {
        //        using (var fileUnifier = new FileUnifier(stringfiles))
        //        {
        //            var hash = Utils.HashCalculator(fileUnifier.ReadAllBytes());
        //            if (!string.IsNullOrEmpty(hash) && !hashes.Add(hash))
        //            {
        //                duplicates.Add(file);
        //            }
        //        }

        //    }
        //}

        //TODO: implementar la exportacion de archivos duplicados y no duplicados
        //TODO: implementar la implementacion de los paths de los archivos y el path de salida

        //es esto pero de otra manera, tengo que pensar  como hacerlo:
        //private (string targetPath, string? targetDirPath) GetDestinationRoute(string filePath, string parentDirectoryPath, UFile file)
        //{
        //    string relativePath = parentDirectoryPath != null ? filePath.Substring(parentDirectoryPath.Length + 1) : file.Path; //Comprobar después
        //    string targetPath = Path.Combine(_outputPath, relativePath);
        //    string? targetDirPath = Path.GetDirectoryName(targetPath);
        //    return (targetPath, targetDirPath);
        //}

        //public void MakeTextFileOfDuplicates()
        //{
        //    if (!ExportDuplicates || _duplicates.Count == 0)
        //        return;
        //    string filePath = Path.Combine(_outputPath, "duplicates.txt");
        //    using (Stream stream = File.Open(filePath, FileMode.Create))
        //    {
        //        using (StreamWriter writer = new StreamWriter(stream))
        //        {
        //            foreach (var file in _duplicates)
        //                writer.WriteLine(file.Path);
        //        }
        //    }
        //}

        //public void SetOutputPath(string path)
        //{
        //    if (Directory.Exists(path))
        //    {
        //        string newPath = Path.Combine(path, "FileUnifierOutput");
        //        Directory.CreateDirectory(newPath);
        //        _outputPath = newPath;
        //    }
        //}
    }
}
