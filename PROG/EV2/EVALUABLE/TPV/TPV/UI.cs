using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPV
{
    public class UI
    {

        public static void ShowMainMenu(TPVLib.ITPV tpv)
        {
            Console.WriteLine("Welcome to the TPV");
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Remove product");
            Console.WriteLine("3. Update product");
            Console.WriteLine("4. Show product");
            Console.WriteLine("5. Show all products");
            Console.WriteLine("6. Exit");
        }

    }
}
