using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FunctionsEjercicios
    {
        //menor de 2 numeros

        public static int MenorQue(int n1, int n2)
        {
            if (n1 <= n2)
                return n1;
            return n2;
        }

        //numero es par
        
        public static bool EsPar(int p)
        {
            if (p % 2 == 0)
                return true;
            return false;
        }

        //menor de 3 numeros(2 versiones)

        public static int MenorQueTres(int m1, int m2, int m3)
        {
            if (m1 <= m2 && m1 <= m3)
                return m1;
            else if (m2 <= m3 && m2 <= m1)
                return m2;
            return m3;
        }

        public static int MenorQueTres2(int m1, int m2, int m3)
        {
            //    //llamada a otra funcion
            return MenorQue(m3, MenorQue(m1, m2));
        }

        //serie 0, -2, 4, -6, 8 imprimen

        public static void Serie1(int s)
        {
            int valor = 1;
            //bucle
            for (int i = 0; i < s; i+=2)
            {
                //if ()
            }



        }

        // Primo
        //%

        //Serie 0, 5, 3, 8, 6, 11 imprimen
        //bucle

        //Sumatorio 
        //bucle

        //Productorio



    }
}
