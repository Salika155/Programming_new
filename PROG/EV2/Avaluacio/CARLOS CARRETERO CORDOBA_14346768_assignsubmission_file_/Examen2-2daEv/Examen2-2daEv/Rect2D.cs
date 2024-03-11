using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_2daEv
{
    public class Rect2D : Shape
    {
        public double MinX, MinY, MaxX, MaxY;

        public double Area; // TODO:
        public Point2D? Center; // TODO:

        

        public Rect2D(string name, Color color) : base(name, color)
        {
            this.name = "Rect2D";
        }

        
    }
}
