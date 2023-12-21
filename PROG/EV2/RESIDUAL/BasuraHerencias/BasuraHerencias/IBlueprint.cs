using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public interface IBlueprint
    {
        //+AddShape(shape:IShape)
        //+GetShapeCount():int
        //+GetShapeAt(int)
        //+RemoveShapeAt(int)
        //+GetArea():double

        void AddShape(IShape shape);
        int GetShapeCount();
        IShape? GetShapeAt(int index);
        void RemoveShapeAt(int index);
        double GetArea();
    }
}
