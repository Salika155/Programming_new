using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Detecta_Copias
{
    public class DuplicateFinder
    {

        public string[] FindDuplicates(string[] files, FileManager fileManager)
        {
            var hashes = new HashSet<string>();
            var duplicates = new List<string>();


            foreach (var file in files)
            {
                using(fileManager = new FileManager(file))
                {
                    var fileBytes = fileManager.ReadFilesToByte(file);
                    var hash = fileManager.HashCalculator(fileBytes);
                    if (!string.IsNullOrEmpty(hash) && !hashes.Add(hash))
                    {
                        duplicates.Add(file);
                    }
                }
            }
            return duplicates.ToArray();
        }

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
