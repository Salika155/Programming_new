using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Detecta_Copias
{
    internal class FileComparer
    {
        private FileManager? _fileManager;

        public FileComparer(FileManager fileManager)
        {
            _fileManager = fileManager;
        }

        
        //pendiente de corregir, esto asi no funciona
        public bool CompareFiles(FileClass file1, FileClass file2)
        {
            if (file1 == null || file2 == null)
            {
                throw new ArgumentNullException("FileClass instances cannot be null.");
            }

            FileInfo fileInfo1 = new FileInfo(file1.Ruta);
            FileInfo fileInfo2 = new FileInfo(file2.Ruta);

            if (fileInfo1.Length != fileInfo2.Length)
            {
                return false;
            }

            byte[] file1Bytes = _fileManager.ReadFilesToByte(file1.Ruta);
            byte[] file2Bytes = _fileManager.ReadFilesToByte(file2.Ruta);

            string hash1 = _fileManager.HashCalculator(file1Bytes);
            string hash2 = _fileManager.HashCalculator(file2Bytes);

            if (hash1 == hash2 && file1.Name == file2.Name)
            {
                file1.IsDuplicate = false;
                file2.IsDuplicate = true;
                return true;
            }
            return false;
        }
    }
}
