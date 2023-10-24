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

        public void SetPositionX(double x)
        {
            this.x = x;
        }

        public void SetPositionY(double y)
        {
            this.y = y;
        }


        

        public bool IsCollision(Rectangulo other)
        {
            if (other == null)
                return false;

            double left1 = x;
            double right1 = x + width;
            double top1 = y;
            double bottom1 = y + height;

            double left2 = other.x;
            double right2 = other.x + other.width;
            double top2 = other.y;
            double bottom2 = other.y + other.height;

            return left1 < right2 && right1 > left2 && top1 < bottom2 && bottom1 > top2;

            
        }

        internal void SetWorldWidth(double width)
        {
            this.width = width;
        }

        internal void SetWorldHeight(double height)
        {
            this.height = height;
        }
    }
    
        //examen lunes funciones, listas, array, objetos
}
