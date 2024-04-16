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
