using System.Security.Cryptography;
using System.Text.Json;

namespace Proyecto_Detecta_Copias
{
    //public class AppParams
    //{
    //    public string[]? Imput_folders  { get; set; }
    //    public string[]? Options { get; set; }
    //    public string? OutputFolder { get; set;}
    //}
    internal class Program
    {
        static void Main(string[] args)
        {

            var directorioOrigen1 = @"C:\Users\carre\Desktop\carpeta_origen";
            //var directorioOrigen2 = args[1];
            //var directorioOrigen3 = args[2];
            var directorioDestino = @"C:\Users\carre\Desktop\carpeta_destino";
            #region codigoviejo
            //Stream s = File.OpenRead("Hola.txt");
            //byte[] buffer = new byte[2048];
            //while (true)
            //{
            //    int br = s.Read(buffer, 0, buffer.Length);
            //    if (br == 0)
            //        break;
            //}


            //try
            //{
            //    using (var p = CreateFile())
            //    {
            //        p.Hola(buffer, 0, buffer.Length);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    if (p != null)
            //        p.Dispose()
            //}




            //private static IDisposable CreateFile()
            //{
            //    throw new NotImplementedException();
            //}

            //public static void Hola(byte[] buffer, int v1, int v2)
            //{
            //    throw new NotImplementedException();
            //}

            //File.Exists("Hola.txt");
            //string[] s = File.ReadAllText("Hola.txt");
            //string[] s2 = File.ReadAllLines("Hola.txt");

            //FileStream
            //fs.ReadAllBytes("Hola.txt");

            //using (SHA256 sha256 = SHA256.Create())
            //{
            //    byte[] hash = sha256.ComputeHash(byte[] b);
            //    hash.GetHashCode();
            //    int = object.GetHashCode();

            //}

            //try
            //{
            //    using (StreamReader r = new StreamReader("Hola")
            //    {
            //        while(true)
            //        {
            //            string line = r.ReadLine();
            //            if (line == null)
            //                break;
            //        }
            //        r.Close(); //PUEDE NO HACER FALTA
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    if (p != null)
            //        p.Dispose()
            //}

            //class File Autocloseable : IDisposable
            //{   
            //~File()    
            //}
            //@override
            //void finalize()
            //{
            //    Dispose();
            //}

            //foreach (var file in Directory.EnumerateFiles("C://", "*.*"))
            //{
            //   SearchOption.AllDirectories();
            //    var s = Path.GetFullPath(file);
            //}
            #endregion

            //string RUTAdELaRCHIVOcONlOSPath = args[0];
            //try
            //{
            //    string jsonContent = File.ReadAllText(RUTAdELaRCHIVOcONlOSPath);
            //    var obj = JsonSerializer.Deserialize<AppParams>(jsonContent);

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //if (args.Length < 2)
            //{
            //    Console.WriteLine("No se han introducido argumentos suficientes");
            //    return;
            //}

            //var directorioOrigen1 = @"C:\Users\carre\Desktop\carpeta_origen";
            ////var directorioOrigen2 = args[1];
            ////var directorioOrigen3 = args[2];
            //var directorioDestino = @"C:\Users\carre\Desktop\carpeta_destino";

            //var filesOrigen1 = Directory.GetFiles(directorioOrigen1, "*.*", SearchOption.AllDirectories);
            //var filesDestino = Directory.GetFiles(directorioDestino, "*.*", SearchOption.AllDirectories);
            //var files = Directory.GetFiles(directorioOrigen1, "*.*", SearchOption.AllDirectories);

            //if (!Directory.Exists(directorioDestino))
            //{
            //    try
            //    {
            //        // Intentar crear el directorio de destino
            //        Directory.CreateDirectory(directorioDestino);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Error al crear el directorio de destino: {ex.Message}");
            //        return; // Salir del programa si ocurre un error al crear el directorio
            //    }
            //}

            //foreach (var file in filesOrigen1)
            //{
            //    var nombreArchivo = Path.GetFileName(file);
            //    var rutaDestino = Path.Combine(directorioDestino, nombreArchivo);
            //    if (!filesOrigen1.Contains(rutaDestino))
            //    {
            //        try
            //        {
            //            // Intentar copiar el archivo al directorio de destino
            //            File.Copy(file, rutaDestino);
            //            Console.WriteLine($"Copiando {nombreArchivo} a {directorioDestino}");
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine($"Error al copiar el archivo {nombreArchivo}: {ex.Message}");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"El archivo {nombreArchivo} ya existe en {directorioDestino}");
            //    }
            //}
            //Console.WriteLine("Completado");

            //var directorioOrigen1 = @"C:\Users\carre\Desktop\carpeta_origen";
            ////var directorioOrigen2 = args[1];
            ////var directorioOrigen3 = args[2];
            //var directorioDestino = @"C:\Users\carre\Desktop\carpeta_destino";

            var filesOrigen1 = Directory.GetFiles(directorioOrigen1, "*.*", SearchOption.AllDirectories);
            var filesDestino = Directory.GetFiles(directorioDestino, "*.*", SearchOption.AllDirectories);
            var files = Directory.GetFiles(directorioOrigen1, "*.*", SearchOption.AllDirectories);

            FileApp app = new FileApp();
            app.Execute(directorioOrigen1, directorioDestino);

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


        


    

