using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Detecta_Copias
{
    public class DuplicateFinder
    {

        public static bool CompareFiles(string file1, string file2)
        {
            using (var fileManager1 = new FileManager(file1))
            using (var fileManager2 = new FileManager(file2))
            {
                var buffer1 = fileManager1.ReadAllBytes();
                var buffer2 = fileManager2.ReadAllBytes();

                if (buffer1.Length != buffer2.Length)
                {
                    return false;
                }
                return true;

            }
        }

        public string[] FindDuplicates(string[] files)
        {
            var hashes = new HashSet<string>();
            var duplicates = new List<string>();


            foreach (var file in files)
            {
                using(var fileManager = new FileManager(file))
                {
                    var hash = Utils.HashCalculator(fileManager.ReadAllBytes());
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
            using (var fileManager = new FileManager(filePath))
            {
                var buffer = fileManager.ReadAllBytes();
                return Utils.HashCalculator(buffer);
            }
        }
    }
}
