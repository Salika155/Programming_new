using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_2daEv
{
    public class Circle : Shape
    {
        public Circle(string name, Color color) : base(name, color)
        {
            this.name = "Circle";
        }

        public double Radio
        {
            get
            {
                return Radio;
            }
            set
            {
                Radio = value;
            }
        }

        public override void DrawCircle(ICanvas canvas) 
        {
            base.DrawCircle(canvas);
        }

        //public static double GetAreaCircle(ICanvas canvas) 
        //{


        //}

        

        



    }
}
