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

        public Rect2D(Point2D position, string name) : base(position, name)
        {
            
        }

        public Rect2D()
        {
        }



        //public Rect2D()
        //{

        //}


        //+Set/Get/Min/Max
        //+GetHeight():double
        //+GetWidth():double

        //public Rect2D (Point2D min, Point2D max)
        //{
        //    _min = min;
        //    _max = max;
        //}

        //public Rect2D()
        //{
        //}

        public Point2D Min { 
            get 
            { 
                return _min; 
            } 
            set
            {
                _min = value;
            }
        }

        public Point2D Max
        {
            get
            {
                return _max;
            }
            set
            {
                _max = value;
            }
        }

        public override double GetArea()
        {
            return GetHeight() * GetWidth();
        }

        public double GetHeight()
        {
            return Math.Abs(Max._y - Min._y);
        }

        public double GetWidth() 
        {
            return Math.Abs(Max._x - Min._x);
        }

        public Point2D GetMin()
        {
            return _min;
        }

        public Point2D GetMax()
        {
            return _max;
        }

        public void SetMin(Point2D min) 
        {
            _min = min;
        }

        public void SetMax(Point2D max) 
        {
            _max = max;
        }

        public override ShapeType GetShapeType()
        {
            return ShapeType.RECT2D;
        }
    }
}
