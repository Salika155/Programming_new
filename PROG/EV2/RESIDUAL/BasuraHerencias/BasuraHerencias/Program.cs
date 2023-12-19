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

            
            

            

            // Crear un objeto Rect2D con los elementos necesarios
            

            // Ahora puedes usar el objeto rect como Rect2D
            double area = rect.GetArea();
            Console.WriteLine("Área del rectángulo: " + area);
        }
    }
}