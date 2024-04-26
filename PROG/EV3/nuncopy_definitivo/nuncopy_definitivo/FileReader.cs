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
            //compara los archivos por tamaño y hash
            //esto esta mal
            if (file1.Size != file2.Size || file1.Hash != file2.Hash)
                return false;
            
            try
            {
                using (var fileStream1 = System.IO.File.OpenRead(file1.PathFile))
                using (var fileStream2 = System.IO.File.OpenRead(file2.PathFile))
                {
                    byte[] buffer1 = new byte[2048];
                    byte[] buffer2 = new byte[2048];
                    int bytesRead1;
                    int bytesRead2;

                    //lee el archivo antes del bucle
                    while ((bytesRead1 = fileStream1.Read(buffer1, 0, buffer1.Length)) > 0)
                    {
                        bytesRead2 = fileStream2.Read(buffer2, 0, buffer2.Length);
                        if (bytesRead1 != bytesRead2)
                            return false;

                        for (int i = 0; i < bytesRead1; i++)
                        {
                            if (buffer1[i] != buffer2[i])
                                return false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al comparar los archivos: " + e.Message);
                return false;
            }
            return true;
        }

        public static string GetHash(string file)
        {
            try 
            {
                //crea un objeto de la clase SHA256 para calcular el hash
                //abre el archivo en modo lectura
                using(var sha256 = System.Security.Cryptography.SHA256.Create())
                using (var fileStream = File.OpenRead(file))
                {
                    //crea un buffer de bytes de 2048
                    //mientras se lea el archivo, se calcula el hash de los bytes leidos
                    
                    byte[] buffer = new byte[2048];
                    int bytesRead;

                    //lee el archivo antes del bucle
                    bytesRead = fileStream.Read(buffer, 0, buffer.Length);

                    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        //calcula el hash de los bytes leidos
                        sha256.TransformBlock(buffer, 0, bytesRead, null, 0);
                    }
                    //finaliza el calculo del hash
                    sha256.TransformFinalBlock(buffer, 0, 0);

                    //devuelve el hash en formato string basw64
                    byte[] hasBytes = sha256.Hash;
                    return Convert.ToBase64String(hasBytes);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al leer el archivo: " + e.Message);
                return string.Empty;
            }
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
