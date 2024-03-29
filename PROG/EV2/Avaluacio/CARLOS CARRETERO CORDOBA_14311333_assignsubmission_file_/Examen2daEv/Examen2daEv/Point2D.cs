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

        public Point2D()
        {

        }

        // Javi: Ok
        public Point2D(double x, double y) 
        {
            _x = x;
            _y = y;
        }

        public double getX() 
        {
            return _x;
        }

        public double getY()
        {
            return _y;        
        }
    }
}
