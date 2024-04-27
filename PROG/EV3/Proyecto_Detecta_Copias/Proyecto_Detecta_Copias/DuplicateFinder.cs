using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Detecta_Copias
{
    public class DuplicateFinder
    {
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
                    else
                    {
                        hashes.Add(hash);
                    }
                }
            }
            return hashes.ToArray();
        }
    }
}
