using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoDragonBall
{
    public static class Utils
    {
        private static Random _random = new Random();
        public static double GetRandom(double min, double max)
        {
            if (min <= max)
            {
                double dif = max - min;
                double result = dif * _random.NextDouble();
                return result + min;
            }
            else
                
            return _random.NextDouble() * (max - min) + min;         
        }
    }
}
