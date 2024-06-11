using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Detecta_Copias
{
    public class FileManager : IDisposable
    {
        private FileStream _fileStream;
        private string? _filePath;


        public FileManager()
        {
        }

        public FileManager(string filepath)
        {
            _fileStream = File.OpenRead(filepath);
            _filePath = filepath;
            
        }

        public string? Length { get; set; }

        public byte[] ReadFilesToByte(string filepath)
        {
            using (FileStream fileStream = File.OpenRead(filepath))
            {
                byte[] buffer = new byte[2048];
                _fileStream.Read(buffer, 0, buffer.Length);
                return buffer;
            }
            
        }

        public string HashCalculator(byte[] buffer)
        {
            using (SHA256 hash = SHA256.Create())
            {
                byte[] hashBytes = hash.ComputeHash(buffer);
                return BitConverter.ToString(hashBytes).Replace("-", "");
            }
        }


        public void Dispose()
        {
            _fileStream.Dispose();
        }

        //internal void CopyFile(string file, string destinationPath)
        //{
        //    File.Copy(file, destinationPath, true);
        //}
    }
    
}
