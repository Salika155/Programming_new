using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangulo
{
    class Rectangulo
    {
        private int _x;
        private int _y;
        private int _width;
        private int _height;

        public Rectangulo()
        {

        }

        public Rectangulo(int x, int y, int width, int height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        public double obtenerDiagonal()
        {
            return Math.Sqrt(Math.Pow(_width, 2) + Math.Pow(_height, 2));
        }

        public int obtenerArea() 
        {
            return _width * _height;
        }

        public int obtenerPerimetro() 
        {
            return ((_width * _width) + (_height* _height));
        }

        public bool intersectaCon(Rectangulo rectangulo)
        {
            int x1 = this._x;
            int y1 = this._y;
            int x2 = x1 + this._width;
            int y2 = y1 + this._height;

            int x3 = rectangulo._x;
            int y3 = rectangulo._y;
            int x4 = x3 + this._width;
            int y4 = y3 + this._height;

            return (x1 < x4 && x1 > x3 && y1 < y4 && y2 > y3);

            //if (other.x >(this.x + this.width))
                //return false;
            //if (other.y > (this.y + this.height))
                //return false
            //if (other.x + oher.width) a this.x))

            //return true;

            //puede hacerse con or 
        }
            
                
        

    }
}
