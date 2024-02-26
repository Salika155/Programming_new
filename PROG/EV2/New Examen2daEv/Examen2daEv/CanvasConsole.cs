using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2daEv
{


    public abstract class CanvasConsole : ICanvas
    {

        public int Width { get;}
        public int Height { get; }
        public Color CurrentColor { get; set; }

        public CanvasConsole(int width, int height, Color color)
        {
            Width = width;
            Height = height;
            CurrentColor = color;
        }

        public void SetColor(double r, double g, double b, double a)
        {
            CurrentColor = new Color(r, g, b, a);
        }

        public void DrawRectangle(Color color)
        {
            Console.WriteLine($"Dibujando rectángulo de color {GetColorName(CurrentColor)}");
        }

        public void DrawCircle(Rect2D circle)
        {
            Console.WriteLine($"Dibujando círculo de color {GetColorName(CurrentColor)}");
        }

        public void DrawPolygon(Point2D[] point2Ds)
        {
            Console.WriteLine($"Dibujando polígono de color {GetColorName(CurrentColor)}");
        }

        private string GetColorName(Color color)
        {
            if (color.R == 1.0 && color.G == 0.0 && color.B == 0.0 && color.A == 0.0)
                return "rojo";
            else if (color.R == 0.0 && color.G == 1.0 && color.B == 0.0 && color.A == 0.0)
                return "verde";
            else if (color.R == 0.0 && color.G == 0.0 && color.B == 1.0 && color.A == 0.0)
                return "azul";
            else 
                return "alfa";
        }

    }
}
