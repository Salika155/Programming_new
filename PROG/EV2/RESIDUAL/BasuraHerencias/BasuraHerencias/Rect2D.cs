using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BasuraHerencias
{
    public class Rect2D : ShapeWithArea
    {
        //-min, -max:Point2D

        private Point2D _min;
        private Point2D _max;

        public Rect2D(Point2D position, string name, Point2D min, Point2D max) : base(position, name)
        {
            _min = min;
            _max = max;
            
            //_type = GetShapeType();
            
        }

        //+Set/Get/Min/Max
        //+GetHeight():double
        //+GetWidth():double
        
        //public Point2D Min { 
        //    get 
        //    { 
        //        return _min; 
        //    } 
        //    set
        //    {
        //        _min = value;
        //    }
        //}

        //public Point2D Max
        //{
        //    get
        //    {
        //        return _max;
        //    }
        //    set
        //    {
        //        _max = value;
        //    }
        //}

        public override double GetArea()
        {
            double with = GetWidth();
            double height = GetHeight();
            return with * height;
        }

        public double GetHeight()
        {
            return _max._y - _min._y;
        }

        public double GetWidth() 
        {
            return _max._x - _min._x;
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
