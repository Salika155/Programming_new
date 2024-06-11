using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Detecta_Copias
{
    public class FileApp
    {
        private  DirectoryManager _directoryManager;
        private FileComparer _fileComparer;

        public FileApp()
        {
            _directoryManager = new DirectoryManager();
            _fileComparer = new FileComparer();
        }

        public void Execute(string[] directoriosOrigen, string directorioDestino)
        {
            if (!DirectoryExists(directorioDestino))
            {
                return;
            }

            foreach (var directorioOrigen in directoriosOrigen)
            {
                if (!ValidateSourceDirectory(directorioOrigen))
                {
                    continue;
                }

                var archivosDestino = LoadFiles(directorioDestino);
                var archivosOrigen = LoadFiles(directorioOrigen);

                ProcessFiles(directorioOrigen, directorioDestino, archivosOrigen, archivosDestino);
            }
        }

        private List<FileClass> LoadFiles(string directorio)
        {
            //tengo que retocar esto porque no se que hace directamente
            return _directoryManager.GetFiles(directorio).Select(file => new FileClass(file)).ToList();
        }

        private void ProcessFiles(string directorioOrigen, string directorioDestino, List<FileClass> archivosOrigen, List<FileClass> archivosDestino)
        {
            foreach (var archivoOrigen in archivosOrigen)
            {
                var nombreArchivo = Path.GetFileName(archivoOrigen.Name);
                var pathRelativo = Path.GetRelativePath(directorioOrigen, archivoOrigen.Ruta);
                var rutaDestino = Path.Combine(directorioDestino, pathRelativo);

                bool existsInDestination = archivosDestino.Any(archivoDestino => _fileComparer.CompareFiles(archivoOrigen, archivoDestino));

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

        //el copy seguramente tenga que retocarlo ya que no puedo hacer uso del copy como funcion
        private void CopyFile(FileClass archivoOrigen, string rutaDestino, string nombreArchivo)
        {
            try
            {
                var rutaDirectorioDestino = Path.GetDirectoryName(rutaDestino);
                if (!_directoryManager.DirectoryExists(rutaDirectorioDestino))
                {
                    _directoryManager.CreateDirectory(rutaDirectorioDestino);
                }

                File.Copy(archivoOrigen.Ruta, rutaDestino);
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
                Console.WriteLine($"El directorio de origen no existe: {directorioOrigen}");
                return false;
            }
            return true;
        }

        private bool DirectoryExists(string directorioDestino)
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

        //public void Execute(string[] directoriosOrigen, string directorioDestino)
        //{

        //    if (!_directoryManager.DirectoryExists(directorioDestino))
        //    {
        //        try
        //        {
        //            _directoryManager.CreateDirectory(directorioDestino);
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Error al crear el directorio de destino: {ex.Message}");
        //            return;
        //        }
        //    }

        //    foreach (var directorioOrigen in directoriosOrigen)
        //    {

        //        if (!_directoryManager.DirectoryExists(directorioOrigen))
        //        {
        //            Console.WriteLine($"El directorio de origen no existe: {directoriosOrigen}");
        //            continue;
        //        }

        //        var archivosDestino = _directoryManager.GetFiles(directorioDestino).Select(file => new FileClass(file)).ToList();
        //        var archivosOrigen = _directoryManager.GetFiles(directorioOrigen).Select(file => new FileClass(file)).ToList();

        //        foreach(var archivoOrigen in archivosOrigen)
        //        {
        //            var nombreArchivo = Path.GetFileName(archivoOrigen.Name);
        //            var pathRelativo = Path.GetRelativePath(directorioOrigen, archivoOrigen.Ruta);
        //            var rutaDestino = Path.Combine(directorioDestino, pathRelativo);

        //            //esto no se que es y tengo que buscarlo
        //            bool existsInDestination = false;
        //            foreach (var archivoDestino in archivosDestino)
        //            {
        //                if (_fileComparer.CompareFiles(archivoOrigen,archivoDestino))
        //                {
        //                    existsInDestination = true;
        //                    break;
        //                }
        //            }

        //            if (!existsInDestination)
        //            {
        //                try
        //                {
        //                    var rutaDirectorioDestino = Path.GetDirectoryName(rutaDestino);
        //                    if (!_directoryManager.DirectoryExists(rutaDirectorioDestino))
        //                    {
        //                        _directoryManager.CreateDirectory(rutaDirectorioDestino);
        //                    }

        //                    File.Copy(archivoOrigen.Ruta, rutaDestino);
        //                    Console.WriteLine($"Copiando {nombreArchivo} de {directorioOrigen} a {rutaDestino}");

        //                }
        //                catch
        //                {
        //                    Console.WriteLine($"Error al copiar el archivo {nombreArchivo}");
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine($"El archivo {nombreArchivo} ya existe en {directorioDestino}");
        //            }
        //        } 
        //    }
        //}
    }
}
