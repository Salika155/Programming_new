using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_2daEv
{
    public class Rectangle : Polygon
    {
        public Rectangle(string name, Color color) : base(name, color)
        {
            this.name = "Rectangle";

            
        }

        public override void DrawRectangle(ICanvas canvas)
        {
            base.DrawRectangle(canvas);
        }

        //public override 

        //public Point GetIndexAt(int index)
        //{

        //}

        public void SetArea(Point2D[] point)
        {
           

        }
    }
}
