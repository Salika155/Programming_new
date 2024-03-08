using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2daEv
{
    public abstract class CanvasConsole : ICanvas
    {

        public int Width { get; set; }
        public int Height { get; set; }
        public Color CurrentColor { get; set; }

        public CanvasConsole(double width, double height, Color color)
        {

        }

        
        public virtual void DrawCircle(Rect2D circle, Color color)
        {
            
        }

        public virtual void DrawPolygon(Point2D[] point2Ds, Color color)
        {
            throw new NotImplementedException();
        }

        public virtual void DrawRectangle(Color color)
        {
            
        }

        public virtual void SetColor(Color color)
        {
            
        }
    }
}
