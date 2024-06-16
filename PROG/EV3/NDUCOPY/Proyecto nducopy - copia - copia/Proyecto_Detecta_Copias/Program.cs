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

//Desglose de Pasos
//Inicio y Validación de Argumentos:
//Se inicia el programa y se validan los argumentos proporcionados.
//Inicialización de Componentes:
//Se inicializan FileApp, DirectoryManager, y FileComparer.
//Verificación y Creación de Directorio de Destino:
//CheckDirectoryExists verifica y crea el directorio de destino si es necesario.
//Validación de Directorios de Origen:
//ValidateSourceDirectory verifica la existencia de cada directorio de origen.
//Carga y Comparación de Archivos:
//LoadFiles carga los archivos de los directorios de origen y destino.
//ProcessFiles compara cada archivo de origen con los archivos de destino.
//Si no existe un archivo duplicado, CopyFile realiza una copia manual del archivo.
//Comparación y Actualización de Duplicados:
//CompareFiles compara los archivos byte por byte y establece IsDuplicate en true si son iguales.







