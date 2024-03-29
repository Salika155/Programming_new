using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2daEv
{
    public class Point2D
    {
        private double _x;
        private double _y;
        

        // Javi: Ok
        public Point2D(double x, double y)
        {
            this._x = x;
            this._y = y;
        }

        public override string ToString()
        {
            return "(" + _x + ", " + _y + ")";
        }

        //public double getX()
        //{
        //    return _x;
        //}

        //public double getY()
        //{
        //    return _y;
        //}
    }
}