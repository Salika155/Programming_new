﻿using System;
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


            Exercises_ex.GetResultGame(playType.SCISSORS, playType.LIZARD);
            Console.WriteLine GetResultGame(playType play1, playType play2);
            

        }

    }
}        