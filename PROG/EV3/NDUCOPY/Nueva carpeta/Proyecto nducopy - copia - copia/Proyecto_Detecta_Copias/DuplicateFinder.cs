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
            var uniqueFiles = new List<FileClass>();
            var fileHashes = new Dictionary<string, FileClass>();

            foreach (var file in files)
            {
                var hash = fileManager.ComputeHash(file.Ruta);

                if (fileHashes.ContainsKey(hash))
                {
                    file.IsDuplicate = true;
                }
                else
                {
                    file.IsDuplicate = false;
                    fileHashes[hash] = file;
                    uniqueFiles.Add(file);
                }
            }

            return uniqueFiles;
        }
    }
}