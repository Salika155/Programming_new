using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            result = ConsoleApp1.Ejerciciosrepaso.GetSuma(2, 3);
            Console.WriteLine(result);

            int major;
            major = Ejerciciosrepaso.GetMajor(8, 9, 10);
            Console.WriteLine("\nSuma de texto");
            Console.WriteLine(major);
        }

    }
}