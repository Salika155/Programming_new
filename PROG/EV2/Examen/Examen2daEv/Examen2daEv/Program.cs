namespace Examen2daEv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICanvas pepe = new CanvasConsole();
            Rect2D rectangle = new Rect2D(4, 6, 8, 9);
            Point2D[] points = new Point2D[5];
            points[0] = new Point2D(1, 1);
            points[1] = new Point2D(1, 1);
            points[2] = new Point2D(1, 1);
            points[3] = new Point2D(1, 1);
            points[4] = new Point2D(1, 1);

            pepe.DrawPolygon(points);
            pepe.DrawRectangle(rectangle);
            pepe.DrawCircle(rectangle);
        }
    }
}