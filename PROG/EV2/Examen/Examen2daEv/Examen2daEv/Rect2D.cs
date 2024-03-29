using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2daEv
{

    // Javi: Rectángulo mal planteado, no tiene 4 puntos, no has cumplido las especificaciones
    public class Rect2D
    {
        // Javi: Y estos intros

        public double X { get;}
        public double Y { get; }
        public double Width { get; }
        public double Height { get; }

        public Rect2D(double x, double y, double width, double height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
        

        public bool IsValid() => Width != null && Height != null;

        //public override void DrawRectangle()
        //{

        //}
    }
}