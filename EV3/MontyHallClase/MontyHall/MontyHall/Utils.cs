﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
    public class Utils
    {
       private static Random _random = new Random();
        
        public static int GetRandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
