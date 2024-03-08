using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_2daEv
{
    public interface IBlueprint
    {
        delegate bool FilterDelegate(IShape shape);
        void AddShape(IShape shape);
        void RemoveShapeWithName(string name);
        IShape GetShapeWithName(string name);
        List<IShape> GetShapes(FilterDelegate del);
        void Draw(ICanvas canvas);

    }
}
