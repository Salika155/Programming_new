using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_2daEv
{
    public class Segment : Shape
    {
        public Point2D pointA;
        public Point2D pointB;

        public Segment(string name, Color color) : base(name, color)
        {
            this.name = "Segment";
            
        }




    }
}
