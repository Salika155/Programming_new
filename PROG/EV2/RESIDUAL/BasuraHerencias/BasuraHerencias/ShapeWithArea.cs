using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public abstract class ShapeWithArea : Shape
    {
        //private Point2D position;
        //private string name;

        protected ShapeWithArea(Point2D position, string name) : base(position, name)
        {

        }

        //public Point2D Position
        //{
        //    get { return position; }
        //    set { position = value; }
        //}

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        public override double GetArea()
        {
            return GetArea();
        }
        

        //public override ShapeType GetShapeType()
        //{
        //    throw new NotImplementedException();
        //}

        public override bool HasArea()
        {
            return true;
        }
    }
}
