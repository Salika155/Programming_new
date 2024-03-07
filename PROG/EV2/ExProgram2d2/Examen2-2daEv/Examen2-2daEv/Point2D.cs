using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_2daEv
{
    
    public class Point2D : Point
    {
        public double X, Y;
       

        public Point2D(double x, double y, string name, Color color) : base (name, color)
        {
            this.name = "Point2D";
            X = x;
            Y = y;
            
        }

        




    }

    

    

    
}

