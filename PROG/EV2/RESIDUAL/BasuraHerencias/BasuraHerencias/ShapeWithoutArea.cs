using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public class ShapeWithoutArea : Shape
    {
        private Point2D _position;
        private string _name;

        public ShapeWithoutArea(Point2D position, string name)
        {
            this._position = position;
            this._name = name;
        }

        public override double GetArea()
        {
            return GetArea();
        }

        public override ShapeType GetShapeType()
        {
            throw new NotImplementedException();
        }
    }
}
