using System.Net.Http.Headers;
using Segment2D;


namespace Segment2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point2D p1 = new Point2D(2, 0);
            Point2D p2 = new Point2D(2, 2);
            Point2D p3 = new Point2D(1, 1);
            Point2D p4 = new Point2D(3, 1);

            Segment2D s1= new Segment2D(p1, p2);
            Segment2D s2 = new Segment2D(p3, p4);

            double distance = s1.GetDistance();

            Console.WriteLine("Distance: " + distance);

            Console.WriteLine(s1.GetAveragePoint());

            Console.WriteLine("Intersect: " + s2.IntersectWith(s1));

            s2.SwapYValors(s1);
            Console.WriteLine("Intersect: " + s2.IntersectWith(s1));

            Console.WriteLine("Los segmentos s1 y s2 se intersectan? " + s1.IntersectWith(s2));


            Point2D p5 = new Point2D(-1, 0);
            Point2D p6 = new Point2D(-1, 2);
            Point2D p7 = new Point2D(-1, 3);
            Point2D p8 = new Point2D(-3, 3);

            Segment2D s3 = new Segment2D(p5, p6);
            Segment2D s4 = new Segment2D(p7, p8);

            Console.WriteLine("Intersect: " + s3.IntersectWith(s4));

            
            Console.WriteLine("Esta fuera de rango? "+ s2.IsOutOfRange(s1));
            Console.WriteLine("Esta dentro de rango? " + s2.IsInsideOfRange(s1));
        }
    }
}