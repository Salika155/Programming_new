﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oca
{
    internal class Dice
    {
        private Random random;

        public Dice()
        {
            random = new Random();
        }

        public int RollDice()
        {
            return random.Next(1, 7);
        }
    }
}
