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

            string[] directoriosOrigen = args.Take(args.Length - 1).ToArray();
            string directorioDestino = args.Last();

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

            FileApp app = new FileApp();
            app.Execute(directoriosOrigen, directorioDestino);

            Console.WriteLine("Completado");

            //DirectoryManager directoryHandler = new DirectoryManager();
            //FileComparer fileComparer = new FileComparer();

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


        


    

