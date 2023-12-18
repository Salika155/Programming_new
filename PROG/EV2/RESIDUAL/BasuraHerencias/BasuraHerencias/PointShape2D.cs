using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public class PointShape2D : ShapeWithoutArea
    {
        //tiene lista de Point2D
        private List<Point2D> _points;

        public PointShape2D(Point2D position, string name) : base(position, name)
        {
            
        }

        public PointShape2D(Point2D position) : base(position, string.Empty)
        {

        }

        public override ShapeType GetShapeType()
        {
            return ShapeType.POINTSHAPE2D;
        }
    }
}
