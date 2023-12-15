 using System;
using System.Transactions;

namespace Exercises
{
    internal class Exercises
    {
        public static bool ParImpar(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if ((number % i) == 0)
                    return false;
            }
            return true;
        }

        public static double GetAreaCirc(double radius)
        {
            return Math.PI * (radius * radius);
        }

        public static double GetAreaRectangle(double width, double height)
        {
            return (width * height);

        }

        public static double GetDistance(double pointa, double pointb)
        {
            return (pointb - pointa);

        }

        //funcion que le pase un numero y devuelve string, que contiene 
        public static string GeneratePrimeString(int number)
        {
            string result = "";
            for (int i = 1; i < number; i++)
            {
                if (IsPrime(i))
                    result += i + ",";
            }
            return result;
        }

        //n = 20 string = "0,1,1,2,3,5,6,13,"
        public static string GenFibonacciSequence(int number)
        {
            string result = "";
            //for
            {

            }

            return result;
        }

        //secuencia result h-o-l-a char c= s [3]
        /*public static string GetCharSequence(string word)
        {

        }*/

        //letra entre varias del abecedario
        // public static string GetBetweenWords(char a, char b, char c)
        //{ if (b < a && a < c)
        //return;

        // }
        //return ((min <= character) && (character <= max)) 
        //return ((min <= character) && (character <= max))

        //le pases un string y te diga si es un correo electronico o no, meter @ par
        //public static bool GetEmail(string word)
        //{
        //if (mail == null)
        // for (int i = 0; i < word.Length - 1; i++)
        //if (mail[i] == "." return false;
        // else if (mail[i] == "@"
        //return true;
        //}
        /*if (GetNumberOf (mail, '@')!=1
        return false;
        if (ConstainsTwoDots(mail".")
        return false;
        if (ContainsNotValid Characters(email))
        return false;
        if (mail[0]=='@' || mail[0]=='.'|| mail[mail.Lenght - 1] = @ || ...)*/
        /*
         si word es algo que tiene algo parecido a length y puedo hacer word[i]
         puedo hacer foreach (char c in word)
         {if (c == character)
        count++;
         }
        usar if varias veces y no se cumple, no sigue comprobando, y se usa y se concatena con &&
        */

        public static double GetDistance2p(Vector3 a, Vector3 b)
        {
            double x2 = a.x - b.x;
            double y2 = a.y - b.y;
            double z2 = a.z - b.z;
            // GetDistance = Exercises.GetMath





            return Math.Sqrt(x2 * x2 + y2 * y2 + z2 * z2);


        }

        //funcion le ponga vector y te de modulo

        //productorio de 7, numeros del 1 al 7 calculateproductor

        public static int CalculateProductory(int number)
        {
            if (number <= 0)
                return 0;
            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        public static int CalculateMCD(int n1, int n2)
        {
            int result = 1;
            for (int i = 2; i <= n1 && i <= n2; i++)
            {
                if (n1 % i == 0 && n2 % i == 0)
                    result = i;
            }
            return result;
        }
        //productorio de un numero p s int calculateproductory2 hacer el bucle de otra forma, intentando reducir en 1 llamada recursiva

        //saturate(valor, min, max) si valor es mas pequeño que min, me devuelve min, si valor es mayor que max, me devuelve max

        public static double Saturate(double value, double min, double max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        //double circular(value, min, max)
        /*public static double Circular(double value, double min, double max)
        {
            double dis = max - min;
            while (value < min value > max)
            {
                if (value < min) 
                    return value;
                if (value > max) 
                    return value + (max);
            }
            return value;
        }*/
        public static double Circular(double value, double min, double max)
        {
            double dis = max - min;
            while (value > max)
            {
                value -= dis;
            }
            while (value < min)
            {
                value += dis;
            }
            return value;
        }
        //EGRFDG


    }








}