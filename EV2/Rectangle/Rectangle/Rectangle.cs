using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Rectangle
    {
        private readonly double _x;
        private readonly double _y; 
        private readonly double _width;
        private readonly double _height;

        double XMax => _x + _width;
        double YMax => _y + _height;


        public Rectangle()
        {
            
        }

        public Rectangle(double x, double y, double width, double height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        public double GetDiagonal()
        {
            return Math.Sqrt((_width * _width) + (_height * _height));
        }

        public double GetArea() 
        {
            return _width * _height;
        }

        public double GetPerimeter()
        {
            return 2 * (_width + _height);
        }

        public bool IntersectWith(Rectangle rectangle) 
        {
            if (IsOutOfRectangle(rectangle))
                return false;
            if (IsInsideOfRectangle(rectangle))
                return false;
            if (rectangle.IsInsideOfRectangle(this))
                return false;
            return true;

        }

        private bool IsOutOfRectangle(Rectangle rectangle)
        {
            if (XMax < rectangle._x)
                return true;
            if (_x > rectangle.XMax)
                return true;
            if (YMax < rectangle._y)
                return true;
            if (_y > rectangle.YMax)
                return true;
            return false;
        }

        private bool IsInsideOfRectangle(Rectangle rectangle)
        {
            if (_x <= rectangle._x)
                return false;
            if (XMax >= rectangle.XMax)
                return false;
            if (_y <= rectangle._y)
                return false;
            if (YMax >= rectangle.YMax)
                return false;
            return true;
        }
    }

    
}
