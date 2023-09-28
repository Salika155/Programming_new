using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FunctionsEjercicios
    {
        ////menor de 2 numeros
        //public static int MenorQue(int n1, int n2)
        //{
        //    if (n1 <= n2)
        //        return n1;
        //    return n2;
        //}

        ////numero es par
        //public static bool EsPar(int p)
        //{
        //    if (p % 2 == 0)
        //        return true;
        //    return false;
        //}

        ////menor de 3 numeros(2 versiones)

        //public static int MenorQueTres(int m1, int m2, int m3)
        //{
        //    if (m1 <= m2 && m1 <= m3)
        //        return m1;
        //    else if (m2 <= m3 && m2 <= m1)
        //        return m2;
        //    return m3;
        //}

        //public static int MenorQueTres2(int m1, int m2, int m3)
        //{
        //    return MenorQue(m3, MenorQue(m1, m2));
        //}


        ////serie 0, -2, 4, -6, 8 imprimen
        //public static void Serie1(int s)
        //{
        //    int valor = 0;
        //    //bucle
        //    for (int i = 0; i < s; i += 2)
        //    {
        //        if (valor == 1)
        //        {
        //            valor = 0;
        //            Console.WriteLine(-i);
        //        }
        //        else
        //        {
        //            Console.WriteLine(i);
        //            valor = 1;
        //        }
        //    }
        //}

        //// Primo
        //public static bool EsPrimo(int n)
        //{
        //    for (int i = 2; i < n; i++)
        //    {
        //        if (n % i == 0)
        //            return false;
        //    }
        //    return true;
        //}

        ////Serie 0, 5, 3, 8, 6, 11 imprimen
        //public static void Serie2(int num)
        //{
        //    int n = 0;
        //    int a = 1;

        //    Console.WriteLine(n);
        //    while (n <= num)
        //    {
        //        if (a >= 0)
        //            n += 5;
        //        else
        //            n -= 2;
        //        Console.WriteLine(n);
        //        a *= -1;
        //    }
        //}

        ////Sumatorio
        //public static int GetSumatorio(int n)
        //{
        //    int result = 0;

        //    for (int i = 0; i < n; i++)
        //        result += i;
        //    return result;
        //}


        ////Productorio
        //public static int GetProductorio(int n)
        //{
        //    int result = 1;

        //    for (int i = 1; i <= n; i++)
        //        result *= i;
        //    return result;
        //}

        ////funcion que concatene dos strings

        //public static string ConcatenacionStrings(string a, string b)
        //{
        //    return a + b;
        //}

        ////0, 1, 2, 3, 4, 5, 6, 7
        //public static string StringSerie1(int n)
        //{
        //    string res = "";
        //    for (int i = 0; i <= n; i++)
        //    {
        //        res += i + ",";
        //    }
        //    return res;
        //}

        //1, 2, 4, 8, 16, 32, 64
        public static string StringSerie2(int n)
        {
            int aux = 1;
            string res = "";
            for (int i = 0; i <= n; i++)
            {
                res += aux + ", ";
                aux *= 2;
            }
            return res;
        }
    }
}