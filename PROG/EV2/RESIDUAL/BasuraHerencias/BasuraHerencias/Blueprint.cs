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
            //comprobacion
            for (int i = 0; i < _shapes.Count; i++)
            {
                
                if (area == _shapes[i].GetArea())
                {
                    return area;
                }
            }
            return -1;
        }

        public abstract double GetArea();

        public IShape? GetShapeAt(int index)
        {
            if (index >= 0 && index < _shapes.Count)
            {
                return _shapes[index];
            }
            return null;
        }

        public int GetShapeCount()
        {
            if (_shapes != null)
                return _shapes.Count;
            return -1;
        }

        public void RemoveShapeAt(int index)
        {
            if (index < 0 || index > GetShapeCount())
                return;

            _shapes.RemoveAt(index);

        }
    }
}
