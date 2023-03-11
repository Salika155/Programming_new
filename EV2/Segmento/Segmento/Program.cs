namespace Segmento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto2D puntoA = new Punto2D(1,1);
            Punto2D puntoB = new Punto2D(2,2);

            Segment2D segment = new Segment2D(puntoA,puntoB);
        }
    }
}