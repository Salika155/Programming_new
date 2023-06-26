using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segment2D
{
    public class Point2D
    {
        public double x;
        public double y;

        public Point2D()
        {
        }

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "Point  = (" + x + ", " + y + ")";
        }
    }

   
}
