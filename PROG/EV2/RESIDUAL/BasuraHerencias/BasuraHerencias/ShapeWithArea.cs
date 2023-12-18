using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public class ShapeWithArea : Shape
    {
        private Point2D position;
        private string name;

        public ShapeWithArea(Point2D position, string name)
        {
            this.position = position;
            this.name = name;
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
