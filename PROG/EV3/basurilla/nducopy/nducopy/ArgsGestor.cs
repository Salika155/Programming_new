using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nducopy
{
    public static class ArgsGestor
    {
        public static void ArgsSender(string[] args, FileGestor fileGestor)
        {
             var directorioOrigen1 = @"C:\Users\carre\Desktop\carpeta_origen";
            //var directorioOrigen2 = args[1];
            //var directorioOrigen3 = args[2];
            var directorioDestino = @"C:\Users\carre\Desktop\carpeta_destino";

            var files = Directory.GetFiles(directorioOrigen1, "*.*", SearchOption.AllDirectories);

            var duplicateFinder = new FileGestor();
            var duplicates = duplicateFinder.FindDuplicates(files);

            foreach(var duplicate in duplicates)
            {
                File.Copy((string)duplicate, Path.Combine(directorioDestino, Path.GetFileName((string?)duplicate)));
                Console.WriteLine(duplicate);
            }
            Console.WriteLine("Completado");

            if (args.Length == 0)
            {
                Console.WriteLine("No se han introducido argumentos");
                return;
            }
            for(int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    //case 
                }
                Console.WriteLine(args[i]);
            }
            
        }

    }
}
