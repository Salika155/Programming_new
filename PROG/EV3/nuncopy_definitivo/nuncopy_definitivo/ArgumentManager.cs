using System;
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
                                Console.WriteLine("Directory does not exist");
                        }
                        else
                            Console.WriteLine("No directory provided");
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
                                Console.WriteLine("Directory does not exist");
                        }
                        else
                            Console.WriteLine("No directory provided or output path is already set");
                        break;
                    case "-t":
                        fileUnifier.ExportDuplicates = true;
                        break;
                    default:
                        Console.WriteLine("Invalid argument");
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
    }

    
}
