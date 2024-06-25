using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Detecta_Copias
{
    internal class DirectoryManager
    {
        public string[] GetFiles(string directoryPath, string searchPattern = "*.*", SearchOption searchOption = SearchOption.AllDirectories)
        {
            if (!Directory.Exists(directoryPath))
            {
                throw new DirectoryNotFoundException($"El directorio no se encuentra: {directoryPath}");
            }

            return Directory.GetFiles(directoryPath, searchPattern, searchOption);
        }

        public bool DirectoryExists(string directoryPath)
        {
            try
            {
                var directoryInfo = new DirectoryInfo(directoryPath);
                return directoryInfo.Exists;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void CreateDirectory(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }
    }
}
