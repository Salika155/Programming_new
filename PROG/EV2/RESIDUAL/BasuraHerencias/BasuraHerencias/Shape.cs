using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public abstract class Shape : IShape
    {
        protected Point2D _position;
        private string _name;

        //-position:Point2D
        //-name:string
        //public string GetName()
        //{

        //}
        public abstract double GetArea();

        public string GetName()
        {
            throw new NotImplementedException();
        }

        public Point2D GetPosition2D()
        {
            throw new NotImplementedException();
        }

        public ShapeType GetShapeType()
        {
            throw new NotImplementedException();
        }

        public bool HasArea()
        {
            throw new NotImplementedException();
        }

        public void SetName(string name)
        {
            throw new NotImplementedException();
        }

        public void SetPosition2D(Point2D position2D)
        {
            throw new NotImplementedException();
        }

        double IShape.GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
