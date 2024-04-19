using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public class Utils
    {
        private static Random r = new();

        public static double RandomRange(double min, double max)
        {
            if (min > max)
                return RandomRange(max, min);
            return r.NextDouble() * (max - min) + min;
        }

        public static int RandomRangeInt(int min, int max)
        {
            int r = (int)RandomRange(min, max);
            return r;
        }

        public static bool IsInRange(int x, int y, int x2, int y2, int range)
        {
            return Math.Abs(x - x2) <= range && Math.Abs(y - y2) <= range;
        }

        //public int GetDistance(int x, int y, int x2, int y2)
        //{
        //    return Math.Abs(x - x2) + Math.Abs(y - y2);
        //}

    }
}
