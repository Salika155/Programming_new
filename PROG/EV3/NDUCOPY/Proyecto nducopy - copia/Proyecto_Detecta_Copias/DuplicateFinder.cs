using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Detecta_Copias
{
    public class DuplicateFinder
    {
        public List<FileClass> FindDuplicates(List<FileClass> files, FileManager fileManager)
        {
            var duplicates = new List<FileClass>();
            var fileHashes = new List<(string hash, FileClass file)>();

            // Calcular y almacenar hashes
            foreach (var file in files)
            {
                var fileBytes = fileManager.ReadFilesToByte(file.Ruta);
                var hash = fileManager.HashCalculator(fileBytes);
                fileHashes.Add((hash, file));
            }

            // Agregar depuración para verificar el contenido de fileHashes
            Console.WriteLine("Número de archivos hasheados: " + fileHashes.Count);

            // Comparar archivos con el mismo hash y tamaño
            for (int i = 0; i < fileHashes.Count; i++)
            {
                bool isOriginal = true;
                for (int j = i + 1; j < fileHashes.Count; j++)
                {
                    //// Agregar depuración para verificar los índices y tamaños
                    //Console.WriteLine($"Comparando archivos: i={i}, j={j}");
                    //Console.WriteLine($"Tamaño archivo i: {fileHashes[i].file.Size}, Tamaño archivo j: {fileHashes[j].file.Size}");

                    if (fileHashes[i].hash == fileHashes[j].hash && fileHashes[i].file.Size == fileHashes[j].file.Size)
                    {
                        fileHashes[j].file.IsDuplicate = true;
                        duplicates.Add(fileHashes[j].file);
                        isOriginal = false;


                        if (!IsInList(duplicates, fileHashes[j].file))
                        {
                            duplicates.Add(fileHashes[j].file);
                        }
                    }
                }
                if (!isOriginal)
                {
                    fileHashes[i].file.IsDuplicate = false; // Ensure the original is not marked as duplicate
                    duplicates.Add(fileHashes[i].file);
                }
            }

            return duplicates;
        }



        private bool IsInList(List<FileClass> list, FileClass file)
        {
            foreach (var item in list)
            {
                if (item.Ruta == file.Ruta)
                {
                    return true;
                }
            }
            return false;
        }
        //public List<FileClass> FindDuplicates(List<FileClass> files, FileManager fileManager)
        //{
        //    var hashes = new HashSet<string>();
        //    var duplicates = new List<FileClass>();

        //    foreach (var file in files)
        //    {
        //        var fileBytes = fileManager.ReadFilesToByte(file.Ruta);
        //        var hash = fileManager.HashCalculator(fileBytes);
        //        var fileInfo = new FileInfo(file.Ruta);
        //        var fileKey = $"{hash}-{fileInfo.Length}-{fileInfo.Name}";

        //        if (!string.IsNullOrEmpty(hash) && !hashes.Add(fileKey))
        //        {
        //            duplicates.Add(file);
        //        }
        //    }
        //    return duplicates;
        //}


        //public string[] FindDuplicates(string[] files, FileManager fileManager)
        //{

        //    var hashes = new HashSet<string>();
        //    var duplicates = new List<string>();


        //    foreach (var file in files)
        //    {
        //        var fileBytes = fileManager.ReadFilesToByte(file);
        //        var hash = fileManager.HashCalculator(fileBytes);
        //        //var fileInfo = new FileInfo(file);
        //        //var fileKey = $"{hash}-{fileInfo.Length}-{fileInfo.Name}";
        //        if (!string.IsNullOrEmpty(hash) && !hashes.Add(hash))
        //        {
        //            duplicates.Add(file);
        //        }

        //    }
        //    return duplicates.ToArray();
        //}

        public static string CalculateHash(string filePath)
        {
            using (var fileManager = new FileManager())
            {
                var buffer = fileManager.ReadFilesToByte(filePath);
                return fileManager.HashCalculator(buffer);
            }
        }
    }
}
