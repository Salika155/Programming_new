using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public abstract class Blueprint : IBlueprint
    {
       
        //tiene lista de IShape
        private List<IShape> _shapes;

        public Blueprint()
        {
            _shapes = new List<IShape>();
        }

        public void AddShape(IShape shape)
        {
            _shapes.Add(shape);
        }

        public double GetArea(double area)
        {
            return area;
        }

        public IShape GetShapeAt(int index)
        {
            throw new NotImplementedException();
        }

        public int GetShapeCount()
        {
            return _shapes.Count;
        }

        public void RemoveShapeAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
