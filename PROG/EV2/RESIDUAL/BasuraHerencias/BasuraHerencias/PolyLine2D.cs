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

        private readonly List<Point2D> _points = new List<Point2D>();


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

            return _points[index];

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
            if (index < 0 || index >= _points.Count)
                return;
            _points.RemoveAt(index);
        }

        public override ShapeType GetShapeType()
        {
            return ShapeType.POLYLINE2D;
        }

        public override bool HasArea()
        {
            return false;
        }

        public virtual void SetName(string name)
        {
            Name = name;
        }
    }
}
