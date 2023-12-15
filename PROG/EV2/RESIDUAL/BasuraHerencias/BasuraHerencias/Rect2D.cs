using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public class Rect2D : ShapeWithArea
    {
        //-min, -max:Point2D

        private Point2D _min;
        private Point2D _max;

        //+Set/Get/Min/Max
        //+GetHeight():double
        //+GetWidth():double

        public override double GetArea()
        {
            return -1;
        }
    }
}
