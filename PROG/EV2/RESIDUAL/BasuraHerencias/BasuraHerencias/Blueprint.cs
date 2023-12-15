using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public class Blueprint : IBlueprint
    {
       
        //tiene lista de IShape
        private List<IShape> _shape;


        public void AddShape(IShape shape)
        {
            throw new NotImplementedException();
        }

        public double GetArea(double area)
        {
            throw new NotImplementedException();
        }

        public IShape GetShapeAt(int index)
        {
            throw new NotImplementedException();
        }

        public int GetShapeCount()
        {
            return _shape.Count;
        }

        public void RemoveShapeAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
