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

        public FileComparer()
        {
        }

        public bool CompareFiles(string filePath1, string filePath2)
        {
            // Comparar tamaños primero para una comparación rápida
            FileInfo fileInfo1 = new FileInfo(filePath1);
            FileInfo fileInfo2 = new FileInfo(filePath2);

            if (fileInfo1.Length != fileInfo2.Length)
            {
                return false;
            }

            // Comparar contenidos byte por byte
            using (FileStream fs1 = File.OpenRead(filePath1))
            using (FileStream fs2 = File.OpenRead(filePath2))
            {
                int byte1, byte2;
                do
                {
                    byte1 = fs1.ReadByte();
                    byte2 = fs2.ReadByte();
                }
                while (byte1 == byte2 && byte1 != -1);

                return byte1 == byte2;
            }
        }
    }
}
