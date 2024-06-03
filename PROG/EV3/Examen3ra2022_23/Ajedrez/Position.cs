using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    internal class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj is Position)
            {
                Position other = (Position)obj;
                return X == other.X && Y == other.Y;
            }
            return false;
        }

        public override string ToString()
        {
            return $"({X}), ({Y})";
        }


    }
}
