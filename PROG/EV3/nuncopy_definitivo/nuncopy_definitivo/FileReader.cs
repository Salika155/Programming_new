using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuncopy_definitivo
{
    public class FileReader
    {
        private FileReader _fileReader;

        //public FileReader(string path)
        //{
            
        //    _fileReader = File.OpenRead(path);
        //}

        //public byte[] ReadAllbytes()
        //{
        //    byte[] buffer = new byte[2048];
        //    _fileReader.Read(buffer, 0, buffer.Length);
        //    return buffer;
        //}   

        public static bool CompareFilesByBytes(Ufile file1, Ufile file2)
        {
            if (file1.Size != file2.Size && file1.Hash != file2.Hash)
            {
                return false;
            }
            return true;
        }

        public static string GetHash(string file)
        {
           Utils.HashCalculator(File.ReadAllBytes(file));
            return File.ReadAllText(file);
        }

        public static long GetSize(string filePath)
        {
            if (filePath == null)
                throw new ArgumentNullException("No se encontro el archivo");

           FileInfo info = new FileInfo(filePath);
           return info.Length;
        }
    }
}
