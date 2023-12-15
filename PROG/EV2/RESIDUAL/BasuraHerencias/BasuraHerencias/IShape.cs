using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public enum ShapeType
    {
        POLYLINE2D,
        POINT2D,
        POINTSHAPE2D,
        RECT2D,
        SEGMENT2D,


    }
    public interface IShape
    {
        //+GetPosition():Position2D
        //+SetPosition(point:Point2D)
        //+GetArea():double
        //+HasArea():bool
        //+GetShapeType():shapetype
        //+GetName/+SetName


        public Point2D GetPosition2D();

        public void SetPosition2D(Point2D position2D);
        public double GetArea();
        public bool HasArea();
        public ShapeType GetShapeType();
        public string GetName();
        public void SetName(string name);

        
        
        
    }
}
