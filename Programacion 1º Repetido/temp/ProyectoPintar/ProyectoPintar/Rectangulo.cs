using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDK;

namespace ProyectoPintar
{
    public class Rectangulo
    {
        public double x;
        public double y;
        public double width;
        public double height;
        public double red, green, blue, alpha;

        public double GetRight()
        {
            return x + width;
        }

        public double GetLeft()
        {
            return x + height;
        }

        public double GetTop()
        {
            return y + width;
        }

        public double GetBottom() 
        {
            return y + height;
        }

        public bool IsIntersecting(Rectangulo other)
        {
            if (other == null)
                return false;
            if (x < other.x)
                return false;
            if (y < other.y)
                return false;
            if (width < other.width)
                return false;
            if (height < other.height)
                return false;
            return true;
        }

        
    }
    
        //examen lunes funciones, listas, array, objetos
}
