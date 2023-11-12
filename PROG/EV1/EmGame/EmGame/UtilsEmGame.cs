using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmGame
{
    internal class UtilsEmGame
    {
        private static Random random= new Random();

        public static int GetRandom()
        {
            return random.Next();
        }

        public static int GetRandom(int x, int y)
        {
            return random.Next(x, y);
        }

        public static double GetRandomDouble() 
        {
            return random.NextDouble();
        }

        public static double GetRandomDouble(double min, double max)
        {
            return (random.NextDouble() * (max - min) + min);
        }

    }
}
