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

        public void AddShape(IShape shape);
        public int GetShapeCount();
        public IShape GetShapeAt(int index);
        public void RemoveShapeAt(int index);
        public double GetArea(double area);
    }
}
