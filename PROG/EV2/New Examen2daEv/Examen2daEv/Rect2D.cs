using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2daEv
{
    public class Rect2D
    {
        public Point2D BottomLeft { get; set; }
        public Point2D TopRight { get; set; }


        public Rect2D(Point2D bottomLeft, Point2D topRight)
        {
            BottomLeft = bottomLeft;
            TopRight = topRight;
        }

        //public override void DrawRectangle()
        //{

        //}
    }
}
