namespace BasuraHerencias
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Rect2D rect = new Rect2D();
            //rect.GetArea();

            // Crear un objeto Point2D para la posición
            Point2D position = new Point2D { _x = 0, _y = 0 };

            // Crear objetos Point2D para min y max
            Point2D min = new Point2D { _x = 0, _y = 0 };
            Point2D max = new Point2D { _x = 10, _y = 5 };


            IShape rect = new Rect2D(position, "Rectángulo", min, max);

            if(rect is Rect2D)
            {
                rect = (Rect2D)rect;
            }
            rect.GetArea();

            double area = rect.GetArea();
            Console.WriteLine("Área del rectángulo: " + area);

            //ejemplo profesor prueba referencias objetos
            //Segment2D s1 = new Segment2D();
            //Segment2D s2 = new Segment2D();

            //s1.SetMin(s2.GetMin());
            //s1.GetMin()._x = 10;
            //s2.GetMin()._x = 20;

            //Console.WriteLine(s1.GetMin().x);
            //Console.WriteLine(s2.GetMin().x);
        }
    }
}