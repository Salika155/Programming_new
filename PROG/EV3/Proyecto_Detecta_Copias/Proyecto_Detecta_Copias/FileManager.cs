using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Detecta_Copias
{
    public class FileManager : IDisposable
    {
        private FileStream _fileStream;
        

        public FileManager(string filepath)
        {
            _fileStream = File.OpenRead(filepath);
            
        }

        public byte[] ReadAllBytes()
        {
            byte[] buffer = new byte[2048];
            _fileStream.Read(buffer, 0, buffer.Length);
            return buffer;
        }

        public void Dispose()
        {
            _fileStream.Dispose();
        }
    }
    
}
