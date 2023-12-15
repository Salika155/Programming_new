using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ejerciciosrepaso
    {
        public static int GetSuma(int n1 , int n2)
        {
            /*int result;
            result = n1 + n2;
            return result;*/
            return n1 + n2;
        }

        public static int GetMajor(int n1, int n2, int n3)
        {
            if (n1 > n2 && n1 > n3)
                return n1;
            if (n2 > n1 && n2 > n3)
                return n2;
            return n3;

        }
    }
}
