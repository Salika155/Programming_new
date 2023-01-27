using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Baraja
{
    public class Utils
    {
        //Atributos privados
        private static Random _random = new Random();

        //Métodos
        public static int GetRandomInteger(int min, int max) //static llamar objeto sin crear clase
        {
            return _random.Next(min, max);
        }

        public static double GetRandomReal(double min, double max)
        {
            var r =_random.NextDouble();
            //return min + r*(max - min)
            //hacer comprobacion de valores minimos y maximos
            return _random.NextDouble() * (max - min) + min;
        }

    }
}
