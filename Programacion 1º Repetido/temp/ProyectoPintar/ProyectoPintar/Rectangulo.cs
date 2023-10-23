using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDK;

namespace ProyectoPintar
{
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
            //public void Draw(ICanvas canvas)
            //{

            //}

            //public void SetPositionX(double positionX)
            //{

            //}

            //public void SetPositionY(double positionY)
            //{

            //}

            //public void SetWidth(double width)
            //{

            //}

            //public void SetHeight(double height)
            //{

            //}

            //public double GetPositionX(double positionX)
            //{
            //    return positionX;
            //}

            //public double GetPositionY(double positionY)
            //{
            //    return positionY;
            //}

            //public double GetWidth(double widtth)
            //{
            //    return widtth;
            //}

            //public double GetHeight(double height)
            //{
            //    return height;
            //}

        }

        //examen lunes funciones, listas, array, objetos


        
    }

}
