﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Utils
    {
        static Random r = new Random();

        public static double RandomRange(double min, double max)
        {
            if (min < max)
                return RandomRange(max, min);
            return r.NextDouble() * (max - min) + min;
        }

        public static int RandomRangeInt(int min, int max)
        {
            return r.Next(min, max);
        }

       
    }
}
