using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraExamen
{
    public class Utils
    {
        private static Random _random = new Random();

        public static double GetRandom(double min, double max)
        {
            if (min > max)
                return GetRandom(max, min);
            double dis = max - min;
            double getRandom = dis *_random.NextDouble();
            return getRandom;
        }
    }
}
