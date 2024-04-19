using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public class Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public void Move(int newx, int newy)
        {
            x = newx;
            y = newy;
        }



        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
    }
}
