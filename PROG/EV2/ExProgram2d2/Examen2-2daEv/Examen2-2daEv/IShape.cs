using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_2daEv
{
    public interface IShape
    {
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public Color Color
        {
            get
            {
                return Color;
            }
            set
            {
                Color = value;

            }
        }
        public bool HasArea
        {
            get
            {
                return false;
            }
        }
                

        public double Area 
        {
            get
            {
                return Area;
            } 
         }
        public double Perimeter 
        {
            get
            {
                return Perimeter;
            }
        }
        Point2D Center {
            get
            {
                return Center;
            }
        }
        Rect2D Rect 
        {
            get
            {
                return Rect;
            } 
        }

        void DrawCircle(ICanvas canvas);
        void DrawRectangle(ICanvas canvas);
    }
}
