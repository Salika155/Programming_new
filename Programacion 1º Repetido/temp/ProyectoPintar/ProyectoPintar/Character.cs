using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDK;

namespace ProyectoPintar
{
    public class Character : World
    {
        public double x;
        public double y;
        public double red, green, blue, alpha;

       
        public void Draw(ICanvas canvas)
        {
            canvas.FillShader.SetColor(red, green, blue, alpha);
            canvas.DrawRectangle(x, y, 1.5, 1.5);
        }

    }
}
