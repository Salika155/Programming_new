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

        //public FileComparer()
        //{
        //}

        //public bool CompareFiles(FileClass filePath1, FileClass filePath2)
        //{
        //    // Comparar contenidos byte por byte
        //    using (FileStream fs1 = File.OpenRead(filePath1.Ruta))
        //    using (FileStream fs2 = File.OpenRead(filePath2.Ruta))
        //    {
        //        int byte1, byte2;
        //        do
        //        {
        //            //posible tener que pasarle aqui el readfilestobyte
        //            byte1 = fs1.ReadByte();
        //            byte2 = fs2.ReadByte();
        //        }
        //        while (byte1 == byte2 && byte1 != -1);

        //        // Comparar tamaños primero para una comparación rápida
        //        FileInfo fileInfo1 = new FileInfo(filePath1.Ruta);
        //        FileInfo fileInfo2 = new FileInfo(filePath2.Ruta);

        //        if (fileInfo1.Length != fileInfo2.Length)
        //        {
        //            return false;
        //        }

        //        bool areEquals = byte1 == byte2;

        //        if (areEquals)
        //        {
        //            filePath1.IsDuplicate = true;
        //            filePath2.IsDuplicate = true;
        //        }

        //        return areEquals;

        //    }
        //}

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
