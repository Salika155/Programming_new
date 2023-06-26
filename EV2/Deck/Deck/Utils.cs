using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    internal class Utils
    {
        private static Random _random;

        public Utils() 
        { 
            _random = new Random();
        }

        public static int GetRandomInteger(int min, int max)
        {
            if (min > max)
            {
                int dif = min;
                min = max;
                max= dif;
            }
            return _random.Next(min, max + 1);
        }

        public static double GetRandomReal(double min, double max) 
        {

            if (min > max)
            {
                double dif = min;
                min = max;
                max = dif;
            }
            return _random.NextDouble() * (max - min) + min;
        }
    }
}
