
namespace Ecuation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ecuation equation = new Ecuation(2, -8, 6);

            (double sol1, double sol2) = equation.GetSqrt();
            Console.WriteLine("La solución 1 es: " + sol1);
            Console.WriteLine("La solución 2 es: " + sol2);

            bool hasSqrts = equation.ItHasSqrts();
            Console.WriteLine("Tiene raíces: " + hasSqrts);

            bool hasSqrt = equation.ItHasSqrt();
            Console.WriteLine("Tiene una sola raíz: " + hasSqrt);

            double discriminant = equation.GetDiscriminant();
            Console.WriteLine("Discriminante: " + discriminant);

            Ecuation equation1 = new Ecuation(5, -3, 14);

            (double sol3, double sol4) = equation1.GetSqrt();
            Console.WriteLine("La solución 1 es: " + sol3);
            Console.WriteLine("La solución 2 es: " + sol4);

            bool hasSqrts1 = equation1.ItHasSqrts();
            Console.WriteLine("Tiene raíces: " + hasSqrts1);

            bool hasSqrt1 = equation1.ItHasSqrt();
            Console.WriteLine("Tiene una sola raíz: " + hasSqrt1);

            double discriminant1 = equation1.GetDiscriminant();
            Console.WriteLine("Discriminante: " + discriminant1);

        }
    }
}