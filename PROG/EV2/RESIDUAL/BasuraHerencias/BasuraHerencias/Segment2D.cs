using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraHerencias
{
    public class Segment2D : ShapeWithoutArea
    {
        //-from, -to:Point2D

        private Point2D? _from;
        private Point2D? _to;

        public Segment2D(Point2D position, string name) : base(position, name)
        {
            //from y to

        }

        public override ShapeType GetShapeType()
        {
            return ShapeType.SEGMENT2D;
        }
    }
}
