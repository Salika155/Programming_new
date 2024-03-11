using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_2daEv
{
    public abstract class Shape : IShape
    {
        protected string name;
        private Color _color;
        //private Point2D[] _points;

        public Shape(string name, Color color)
        {
            this.name = name;
            this._color = color;
        }

        public virtual void DrawCircle(ICanvas canvas)
        {
            canvas.SetColor(_color);
        }

        public virtual void DrawRectangle(ICanvas canvas)
        {
            canvas.SetColor(_color);
        }

        
    }
}
