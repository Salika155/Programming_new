using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public class PolyLine2D : ShapeWithArea
    {
        //+AddPoint(print )
        //+GetPointCount()
        //+GetPointAt()
        //+SetPointAt()
        //+RemovePointAt()

        //tiene lista de point2D

        //hay un getarea pero no es visible

        private List<Point2D> _points;

        public PolyLine2D(Point2D position, string name) : base(position, name)
        {

        }

        public void AddPoint(Point2D point)
        {
            if (point == null)
                return;
            _points.Add(point);
        }

        public int GetPointCount()
        {
            return _points.Count;
        }

        public Point2D? GetPointAt(int index)
        {
            if (index < 0 || index >= _points.Count)
                return null;

            for (int i = 0; i < _points.Count; i++)
            {
                Point2D point = _points[i];
                return point;
            }
            return null;

        }

        public void SetPositionAt(int index, Point2D point)
        {
            if (index >= 0 && index < _points.Count)
            {
                _points[index] = point;
            }
            else
                return;
        }

        public void RemovePersonAt(int index)
        {
            _points.RemoveAt(index);
        }


    }
}
