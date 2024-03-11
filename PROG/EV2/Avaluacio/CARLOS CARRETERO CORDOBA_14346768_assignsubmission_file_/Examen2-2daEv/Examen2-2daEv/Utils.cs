using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_2daEv
{
    public class Utils
    {
        public double GetDistance(Point2D a, Point2D b) 
        {
            //distancia = raiz de (ax - bx)^2 + (ay - by)^2

            var pointa = Math.Pow((Math.Abs(a.X - b.X)), 2);
            var pointb = Math.Pow((Math.Abs(a.Y - b.Y)), 2);
            var distancia = Math.Sqrt(pointa + pointb);
            return distancia;
            
        }

        public Rect2D GetBoundingBox(Point2D[] points)
        {

            return Rect2D();
        }

        private Rect2D Rect2D()
        {
            throw new NotImplementedException();
        }

        public double GetArea(Point2D[] points)
        {
            if (points == null) 
                return 0;
            
            var area = 0;
            for (int i = 0, j = i + 1; i < points.Length; i++, j++) 
            {
                area = (int)(points[i].X + points[j].X + (points[i].Y + points[j].Y));
            }
            return area;
        }

        public double GetPerimeter(Point2D[] points) 
        {
            if (points == null)
                return 0;

            var perimeter = 0;
            var area = GetArea(points);
            for (int i = 0, j = i + 1; i < points.Length; i++, j++)
            {
                perimeter = 0;
            }
            return perimeter;
        }
    }
}
