using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2daEv
{
    

    public interface ICanvas
    {
        int Width { get; }
        int Height { get; }
        Color CurrentColor { get; }

        void SetColor(Color color);
        void DrawRectangle(Color color);
        void DrawCircle(Rect2D circle, Color color);
        void DrawPolygon(Point2D[] point2Ds, Color color);
        
    }
}
