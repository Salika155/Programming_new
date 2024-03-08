using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2daEv
{
    
    public class Color
    {
        public double R { get; set; }
        public double G { get; set;}
        public double B { get; set; }
        public double A { get; set; }

        public Color(double r, double g, double b, double a)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }

    }
}
