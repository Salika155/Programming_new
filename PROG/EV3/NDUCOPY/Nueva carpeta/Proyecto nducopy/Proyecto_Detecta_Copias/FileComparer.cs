using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Detecta_Copias
{
    internal class FileComparer
    {
        private FileManager _fileManager;

        public FileComparer(FileManager fileManager)
        {
            _fileManager = fileManager;
        }

        public FileComparer()
        {
        }

        public bool CompareFiles(string filePath1, string filePath2)
        {
            using (FileManager fileManager1 = new FileManager(filePath1))
            using (FileManager fileManager2 = new FileManager(filePath2))
            {
                if (fileManager1.Length != fileManager2.Length)
                    return false;

                byte[] buffer1Array = fileManager1.ReadFilesToByte(filePath1);
                byte[] buffer2Array = fileManager2.ReadFilesToByte(filePath2);

                string hash1 = _fileManager.HashCalculator(buffer1Array);
                string hash2 = _fileManager.HashCalculator(buffer2Array);

                if (hash1 != hash2)
                    return false;
                return true;
            }
        }
    }
}
