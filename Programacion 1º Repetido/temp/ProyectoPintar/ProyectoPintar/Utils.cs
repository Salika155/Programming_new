using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPintar
{
    internal class Utils
    {
        private static Random r = new Random();

        public static double GetRandom()
        {
            return r.NextDouble();
        }

        public static double GetRandom(double min, double max)
        {
            //return (r.NextDouble() * (max - min) + min);
            double r = GetRandom();
            double v = r * (max - min);
            return v + min;
        }
    }
}
