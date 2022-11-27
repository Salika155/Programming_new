using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace ex_program_eva
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El área del círculo es = ");
            Console.WriteLine(Exercises_ex.GetAreaCirc(1));
            Console.WriteLine("El volumen del cilindro es = ");
            Console.WriteLine(Exercises_ex.GetCylindreVolume(2, 4));

            Console.WriteLine("El resultado de la jugada es ");
            Console.WriteLine(Exercises_ex.GetResultGame(playType.PAPER, playType.PAPER));
            //me falla el pptls

            Console.WriteLine("X vale = ");
            Console.WriteLine(Exercises_ex.EcuationSolution(20, 5));

            Console.WriteLine("Los resultados de la ecuación de 2º grado son = ");
            Console.WriteLine(Exercises_ex.EcuationSolution2Grade(2, 2, 4));

            Console.WriteLine("El triangulo es ");
            Console.WriteLine(Exercises_ex.TriangleType(106, 106, 106));

            Console.WriteLine("El máximo común divisor de los dos números es ");
            Console.WriteLine(Exercises_ex.GetMCD(16, 212));


            Console.WriteLine("El mínimo común multiplo de los dos números es ");
            Console.WriteLine(Exercises_ex.GetMCM(16356, 2142));
        }

    }
}        