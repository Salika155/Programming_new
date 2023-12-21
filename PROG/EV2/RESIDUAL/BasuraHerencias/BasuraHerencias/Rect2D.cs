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

        private Point2D _min = new Point2D();
        private Point2D _max = new Point2D();

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
            //_min = min;
            //esto lo que hace es apuntar a la variable, no iguala el valor, sino que apunta directamente.
            //importante esto sera una prueba evaluable
            //comprobar null
            _min._x = min._x;
            _min._y = min._y;
        }

        public void SetMax(Point2D max) 
        {
            //comprobar null
            _max._x = max._x;
            _max._y = max._y;
        }

        public override ShapeType GetShapeType()
        {
            return ShapeType.RECT2D;
        }

        



    }
}
