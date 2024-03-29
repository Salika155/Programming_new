using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2daEv
{
    public class CanvasConsole : ICanvas
    {
        private int _width;
        private int _height;
        private Color _currentColor;

        // Javi: No era precisamente lo que esperaba, ..., pero bueno
        public int Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Width must be a positive value.");
                _width = value;
            }
        }

        public int Height 
        {
            get { return _height; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Height must be a positive value.");
                _height = value;
            } 
        }
        public Color CurrentColor 
        {
            get { return _currentColor;}
            //set { _currentColor = value; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Color must be a valid value.");
                }
                _currentColor = value;
            }
        }

        public CanvasConsole()
        {
           
            CurrentColor = new Color(0, 0, 0, 0);

        }

        // Javi: No implementada
        public void DrawCircle(Rect2D rect)
        {
            //if (rect.IsValid())
                Console.WriteLine("Pintando un círculo de color " + CurrentColor.ToString() + " en el rectangulo " + rect.ToString());
        }

        // Javi: No implementada
        public void DrawPolygon(Point2D[] points)
        {
            string pointsToString = "(";
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i] == null)
                {
                    Console.WriteLine("Uno de los puntos del Polinomio es nulo. No se ha podido dibujar el Polinomio.");
                    return;
                }
                pointsToString += " " + points[i].ToString() + "";
            }
            pointsToString += ")";
            Console.WriteLine("Pintando un polinomio de color " + CurrentColor.ToString() + " con los puntos " + pointsToString);
        }

        // Javi: No implementada
        public void DrawRectangle(Rect2D rect)
        {
            //if (rect.IsValid())
                Console.WriteLine("Pintando un rectangulo de color " + CurrentColor.ToString() + " en las coordenadas " + rect.ToString());
                
        }
        public void SetColor(Color color)
        {
            if (color != null)
                CurrentColor = color;
        }
    }
}

