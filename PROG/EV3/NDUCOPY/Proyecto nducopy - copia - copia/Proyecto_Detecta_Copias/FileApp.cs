using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Detecta_Copias
{
    public class FileApp
    {
        private DirectoryManager _directoryManager;
        private FileComparer _fileComparer;
        private DuplicateFinder _duplicateFinder;

        public FileApp()
        {
            _directoryManager = new DirectoryManager();
            _fileComparer = new FileComparer(new FileManager());
            _duplicateFinder = new DuplicateFinder();
        }

        public void Execute(string[] directoriosOrigen, string directorioDestino)
        {
            if (!CheckDirectoryExists(directorioDestino))
            {
                return;
            }

            var archivosDestino = LoadFiles(directorioDestino);
            var archivosFiltrados = new List<FileClass>();

            foreach (var directorioOrigen in directoriosOrigen)
            {
                if (!ValidateSourceDirectory(directorioOrigen))
                {
                    continue;
                }

                var archivosOrigen = LoadFiles(directorioOrigen);
                var archivosDuplicados = _duplicateFinder.FindDuplicates(archivosOrigen, new FileManager());

                foreach (var archivo in archivosDuplicados)
                {
                    if (!archivo.IsDuplicate)
                    {
                        archivosFiltrados.Add(archivo);
                    }
                }

                ProcessFiles(directorioOrigen, directorioDestino, archivosFiltrados, archivosDestino);
                archivosFiltrados.Clear();
            }
        }

        private List<FileClass> LoadFiles(string directorio)
        {
            var files = _directoryManager.GetFiles(directorio);
            var fileClasses = new List<FileClass>();

            foreach (var file in files)
            {
                fileClasses.Add(new FileClass(file));
            }

            return fileClasses;
        }

        private void ProcessFiles(string directorioOrigen, string directorioDestino, List<FileClass> archivosOrigen, List<FileClass> archivosDestino)
        {
            foreach (var archivoOrigen in archivosOrigen)
            {
                var nombreArchivo = Path.GetFileName(archivoOrigen.Name);
                var pathRelativo = Path.GetRelativePath(directorioOrigen, archivoOrigen.Ruta);
                var rutaDestino = Path.Combine(directorioDestino, pathRelativo);

                bool existsInDestination = false;
                foreach (var archivoDestino in archivosDestino)
                {
                    if (_fileComparer.CompareFiles(archivoOrigen, archivoDestino))
                    {
                        existsInDestination = true;
                        break;
                    }
                }

                if (!existsInDestination)
                {
                    CopyFile(archivoOrigen, rutaDestino, nombreArchivo);
                }
                else
                {
                    Console.WriteLine($"El archivo {nombreArchivo} ya existe en {directorioDestino}");
                }
            }
        }

        private void CopyFile(FileClass archivoOrigen, string rutaDestino, string nombreArchivo)
        {
            try
            {
                string? rutaDirectorioDestino = Path.GetDirectoryName(rutaDestino);
                if (!_directoryManager.DirectoryExists(rutaDirectorioDestino))
                {
                    _directoryManager.CreateDirectory(rutaDirectorioDestino);
                }

                using (FileStream origenStream = new FileStream(archivoOrigen.Ruta, FileMode.Open, FileAccess.Read))
                using (FileStream destinoStream = new FileStream(rutaDestino, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[2048];
                    int bytesRead;
                    while ((bytesRead = origenStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        destinoStream.Write(buffer, 0, bytesRead);
                    }
                }

                Console.WriteLine($"Copiando {nombreArchivo} de {archivoOrigen.Ruta} a {rutaDestino}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al copiar el archivo {nombreArchivo}: {e.Message}");
            }
        }

        private bool ValidateSourceDirectory(string directorioOrigen)
        {
            if (!_directoryManager.DirectoryExists(directorioOrigen))
            {
                try
                {
                    _directoryManager.CreateDirectory(directorioOrigen);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al crear el directorio: {ex.Message}");
                    return false;
                }
            }
            return true;
        }

        private bool CheckDirectoryExists(string directorioDestino)
        {
            if (!_directoryManager.DirectoryExists(directorioDestino))
            {
                try
                {
                    _directoryManager.CreateDirectory(directorioDestino);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al crear el directorio de destino: {ex.Message}");
                    return false;
                }
            }
            return true;
        }
    }
}
