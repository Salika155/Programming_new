using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public enum ShapeType
    {
        POLYLINE2D,
        //POINT2D,
        POINTSHAPE2D,
        RECT2D,
        SEGMENT2D,
        CIRCLE2D,
        UNKNOWN


    }
    public interface IShape
    {
        //+GetPosition():Point2D
        //+SetPosition(point:Point2D)
        //+GetArea():double
        //+HasArea():bool
        //+GetShapeType():shapetype
        //+GetName/+SetName

        Point2D GetPosition2D();

        void SetPosition2D(Point2D position2D);
        double GetArea();
        bool HasArea();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
        ShapeType GetShapeType();
        string GetName();
        void SetName();

        
        
        
    }
}
