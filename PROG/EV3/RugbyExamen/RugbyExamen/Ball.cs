using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public class Ball
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Ball(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int GetXValue { get { return X; } }
        public int GetYValue { get { return Y; } }

        public int GetX()
        {
            return X;
        }

        public int GetY() 
        {
            return Y;
        }

        public void Move(int newx, int newy)
        {
            X = newx;
            Y = newy;
        }
    }
}
