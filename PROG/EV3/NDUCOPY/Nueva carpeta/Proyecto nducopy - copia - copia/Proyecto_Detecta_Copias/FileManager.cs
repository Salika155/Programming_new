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

        public string? Length
        {
            get => _filePath;
            set => _filePath = value;
        }

        public byte[] ReadFilesToByte(string filepath)
        {
            using (FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            using (MemoryStream ms = new MemoryStream())
            {
                byte[] buffer = new byte[2048]; // Buffer de 2KB
                int bytesRead;
                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, bytesRead);
                }
                return ms.ToArray();
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

        public string ComputeHash(string filePath)
        {
            var buffer = ReadFilesToByte(filePath);
            return HashCalculator(buffer);
        }
    }
}

