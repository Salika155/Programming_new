﻿using System.Security.Cryptography;
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

            var directorioOrigen1 = @"C:\Users\carre\Desktop\carpeta_origen";
            //var directorioOrigen2 = args[1];
            //var directorioOrigen3 = args[2];
            var directorioDestino = @"C:\Users\carre\Desktop\carpeta_destino";

            var files = Directory.GetFiles(directorioOrigen1, "*.*", SearchOption.AllDirectories);

            var duplicateFinder = new DuplicateFinder();
            var duplicates = duplicateFinder.FindDuplicates(files);

            foreach(var duplicate in duplicates)
            {
                File.Copy(duplicate, Path.Combine(directorioDestino, Path.GetFileName(duplicate)));
                Console.WriteLine(duplicate);
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


        


    

