using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_2daEv
{
    public class Polygon : Shape
    {
        private Point2D[] _points;
        private int _pointCount;

        public Polygon(string name, Color color) : base(name, color)
        {
            this.name = "Polygon";
        }

        public int PointCount 
        { 
            get 
            {
                return _pointCount;
            }
        }

        public void Clear()
        {
            _points = new Point2D[0];
        }

        public bool Close(Point2D point) 
        {
            if (point == null) 
                return false;
            return true;
        }

        public void AddPoint(Point2D point) 
        {
            if (_points == null || PointCount == null)
                return;
            int lenght = _points.Length;
            
            for (int i = 0, j = i + 1; i < lenght; i++) 
            {
                //Point2D p = _points[i];
                //if (p != null)
                //{
                //    _points[i] = point;
                //    _points[j] = _points[i];
                //    _points[j + 1] = p;
                //}
            }
            
             
        }

        public virtual void DrawPolygon(ICanvas canvas)
        {
            canvas.DrawPolygon(_points);
            
        }

        public Point2D GetPointAt(int index)
        {
            if (index == null || index < 0)
                return null;
            
            for (int i = 0; i < _points.Length; i++)
            {
                Point2D point = _points[i];
                if (_points[i].X == index || _points[i].Y == index)
                    return _points[i];
                return point;
            }
            return null;
            

        }

        //public virtual Point2D GetRect()
    }
}
