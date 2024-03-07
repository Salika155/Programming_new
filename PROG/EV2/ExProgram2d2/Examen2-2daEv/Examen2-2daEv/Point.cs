using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_2daEv
{
    public class Point : Shape
    {
        public double x, y;

        public Point(string name, Color color) : base(name, color)
        {
            this.name = "Point";
            
        }

       

    }
}
