using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_2daEv
{
    public class Blueprint : IBlueprint
    {
        public int ShapeCount { get; set; }
        
       
        public void AddShape(IShape shape)
        {
            if (shape == null)
                return;  
            
        }

        public void Draw(ICanvas canvas)
        {
           
        }

        public List<IShape> GetShapes()
        {
            throw new NotImplementedException();
        }

        public List<IShape> GetShapes(IBlueprint.FilterDelegate del)
        {
            throw new NotImplementedException();
        }

        public IShape GetShapeWithName(string name)
        {
            throw new NotImplementedException();
        }

        public void RemoveShapeWithName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
