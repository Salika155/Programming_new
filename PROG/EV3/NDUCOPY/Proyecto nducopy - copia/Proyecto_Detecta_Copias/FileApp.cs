using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Detecta_Copias
{
    public class FileApp
    {
        private  FileManager _fileManager;
        private  DirectoryManager _directoryManager;
        private FileComparer _fileComparer;

        public FileApp()
        {
            _fileManager = new FileManager();
            _directoryManager = new DirectoryManager();
            _fileComparer = new FileComparer();
        }

        public void Execute(string filesOrigen1, string directorioDestino)
        {
            var files = _directoryManager.GetFiles(filesOrigen1);


            if (!_directoryManager.DirectoryExists(directorioDestino))
            {
                try
                {
                    _directoryManager.CreateDirectory(directorioDestino);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al crear el directorio de destino: {ex.Message}");
                    return;
                }
            }

            foreach (var file in files)
            {
                var nombreArchivo = Path.GetFileName(file);
                var rutaDestino = Path.Combine(directorioDestino, nombreArchivo);
                if (!filesOrigen1.Contains(rutaDestino))
                {
                    try
                    {
                        // Intentar copiar el archivo al directorio de destino
                        File.Copy(file, rutaDestino);
                        Console.WriteLine($"Copiando {nombreArchivo} a {directorioDestino}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al copiar el archivo {nombreArchivo}: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine($"El archivo {nombreArchivo} ya existe en {directorioDestino}");
                }
            }
            Console.WriteLine("Completado");
        }
    }
}
