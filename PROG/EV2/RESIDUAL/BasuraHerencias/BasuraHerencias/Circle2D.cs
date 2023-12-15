using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public class Circle2D : ShapeWithArea
    {
        //-radius:double
        //+Set/Get/Radius

        private double _radius;

        public double GetRadius()
        {
            return _radius;
        }


        public void SetRadius(double radius)
        {
            _radius = radius;
        }
    }
}
