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

        //-_position:Point2D
        //-_name:string
        //public string GetName()
        //{

        //}

        public Shape(Point2D position, string name)
        {
            _position = position;
            _name = name;
        }

        public Point2D Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }

        public string Name
        {
            get 
            { 
                return _name; 
            }
            set
            { 
                _name = value; 
            }
        }

        public string GetName()
        {
           return _name;
        }
        public void SetName(string name)
        {
            _name= name;
        }

        public Point2D GetPosition2D()
        {
            return _position;
        }
        public void SetPosition2D(Point2D position2D)
        {
            _position = position2D;
        }

        public abstract ShapeType GetShapeType();
        

        public virtual bool HasArea()
        {
            return GetArea() != null;
        }


        public abstract double GetArea();


        //double IShape.GetArea()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
