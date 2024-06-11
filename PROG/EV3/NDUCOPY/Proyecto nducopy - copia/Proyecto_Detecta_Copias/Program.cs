using System.Security.Cryptography;
using System.Text.Json;

namespace Proyecto_Detecta_Copias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Se requieren al menos dos argumentos: la ruta del directorio origen y la ruta del directorio destino.");
                return;
            }

            string directorioDestino = args.Last();
            string[] directoriosOrigen = args.Take(args.Length - 1).ToArray();

            //var directoriosOrigen = args[0];
            //var directorioDestino = args[1];

            //FileApp app = new FileApp();
            //app.Execute(directoriosOrigen, directorioDestino);

            Console.WriteLine("Directorios Origen:");
            foreach (var dir in directoriosOrigen)
            {
                Console.WriteLine($"- {dir}");
            }
            Console.WriteLine($"Directorio Destino: {directorioDestino}");

            DirectoryManager directoryHandler = new DirectoryManager();
            FileComparer fileComparer = new FileComparer();

            if (!directoryHandler.DirectoryExists(directorioDestino))
            {
                try
                {
                    directoryHandler.CreateDirectory(directorioDestino);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al crear el directorio de destino: {ex.Message}");
                    return;
                }
            }

            foreach (var directorioOrigen in directoriosOrigen)
            {
                if (!directoryHandler.DirectoryExists(directorioOrigen))
                {
                    Console.WriteLine($"El directorio de origen no existe: {directorioOrigen}");
                    continue;
                }

                var archivosDestino = directoryHandler.GetFiles(directorioDestino);
                var filesOrigen = directoryHandler.GetFiles(directorioOrigen);

                foreach (var fileOrigen in filesOrigen)
                {
                    var nombreArchivo = Path.GetFileName(fileOrigen);
                    var relativePath = Path.GetRelativePath(directorioOrigen, fileOrigen);
                    var rutaDestino = Path.Combine(directorioDestino, relativePath);

                    bool existsInDestination = archivosDestino.Any(destFile => fileComparer.CompareFiles(fileOrigen, destFile));

                    if (!existsInDestination)
                    {
                        try
                        {
                            var rutaDirectorioDestino = Path.GetDirectoryName(rutaDestino);
                            if (!directoryHandler.DirectoryExists(rutaDirectorioDestino))
                            {
                                directoryHandler.CreateDirectory(rutaDirectorioDestino);
                            }

                            File.Copy(fileOrigen, rutaDestino);
                            Console.WriteLine($"Copiando {nombreArchivo} de {directorioOrigen} a {rutaDestino}");
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
            }
            Console.WriteLine("Completado");
        }

    

        //foreach(string route in args)
        //{ Console.WriteLine(route); }
        //MODO RELEASE PARA EJECUTAR DESDE CMD no esta codigo fuente
        //desensamblador 
        //ofuscador de codigo para que no se pueda leer el codigo fuente
        //csharp environment variables
        //depurar codigo

        //esto va dentro de un doc txt
        //"input foders" : ["f1", "f2", "f3"],
        //options" : ["keep directories", "keep files"],
        //"output_folder" : "out1"

    }
}


        


    

