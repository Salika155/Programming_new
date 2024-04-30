﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuncopy_definitivo
{
    public static class ArgumentManager
    {
        
        public static void CheckArguments(string[] args, FileUnifier fileUnifier)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No se han pasado argumentos");
                return;
            }
            

            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "-d":
                        if (i + 1 < args.Length)
                        {
                            string path = args[i + 1];
                            if (Directory.Exists(path))
                            {
                                fileUnifier.AddDirectory(path);
                                i++;
                            }
                            else
                                Console.WriteLine("El directorio no existe");
                        }
                        else
                            Console.WriteLine("No se ha provisto de un directorio");
                        break;
                    case "-o":
                        if (!fileUnifier.IsOutputPathSet && i + 1 < args.Length)
                        {
                            string path = args[i + 1];
                            if (Directory.Exists(path))
                            {
                                fileUnifier.SetOutputPath(path);
                                i++;
                            }
                            else
                                Console.WriteLine("El directorio no existe");
                        }
                        else
                            Console.WriteLine("El directorio no ha sido provisto o el path de salida esta en uso");
                        break;
                    case "-t":
                        fileUnifier.ExportDuplicates = true;
                        break;
                    default:
                        Console.WriteLine("Argumento invalido");
                        break;
                }
            }
        }

        public static void SetDirectories(FileUnifier fileUnifier, string[] inputDirectories, string outputDirectory)
        {
            foreach (var inputDirectory in inputDirectories)
            {
                if (Directory.Exists(inputDirectory))
                {
                    fileUnifier.AddDirectory(inputDirectory);
                }
                else
                {
                    Console.WriteLine($"El directorio de entrada '{inputDirectory}' no existe.");
                }
            }

            if (Directory.Exists(outputDirectory))
            {
                fileUnifier.SetOutputPath(outputDirectory);
            }
            else
            {
                Console.WriteLine($"El directorio de salida '{outputDirectory}' no existe.");
            }
        }

        //public static void SetDirectories(FileUnifier fileUnifier, string[] inputDirectories, string outputDirectory)
        //{
        //    try
        //    {
        //        if (inputDirectories != null)
        //        {
        //            foreach (var inputDirectory in inputDirectories)
                        
                
        //            if (Directory.Exists(inputDirectory))
        //            {
        //                fileUnifier.AddDirectory(inputDirectory);
        //            }
        //            else
        //            {
        //                Console.WriteLine($"El directorio de entrada '{inputDirectory}' no existe.");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("El arreglo de directorios de entrada es nulo.");
        //        }

        //        if (Directory.Exists(outputDirectory))
        //        {
        //            fileUnifier.SetOutputPath(outputDirectory);
        //        }
        //        else
        //        {
        //            Console.WriteLine($"El directorio de salida '{outputDirectory}' no existe.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Se produjo una excepción en SetDirectories: {ex.Message}");
        //        // Puedes agregar más información de depuración si lo deseas.
        //    }
        //}
    }

    
}