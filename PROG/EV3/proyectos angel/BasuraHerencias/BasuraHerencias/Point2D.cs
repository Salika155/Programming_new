using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public class Point2D
    {
        public double _x;
        public double _y;

        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public Point2D()
        {

        }

        //public double X
        //{ 
        //  get { return _x; } 
        //  set { _x = value; } 
        //}

        //public double Y
        //{
        //    get { return _y; } 
        //    set { _y = value; }
        //}

        //public bool equals(Point2D other)
        //{ returns Equals(this, other)}

        //public override bool Equals (Object? obj)
        //if (this == obj) return true;
        //{ if (obj == null) return false;
        //if (obj is not Shape) -> return false

        //Point2D p = (Point2D)obj;
        //return Equals(this, p)

        //public static bool operator == (Point2D o1, Point2D o2
        //{return Equals (o1, o2)

        //public bool Contains(T item)
        //{ }
    }
}
