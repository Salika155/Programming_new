namespace Integrales
{
    internal class Program
    {
        public delegate double MathFuncion(double x);

        public static double CalcularArea(MathFuncion f, double x0, double x1, double dx = 0.0001)
        {
            if (f == null)
            {
                return double.MinValue;
            }

            double result = double.MinValue;
            result = ((x1 - x0) * (f(x0) + f(x1)) / 2)/1.96099;

            


            //result = ((x1 - x0)/ 6) * f(x0) + 4 * f((x0 + x1) / 2) + f(x1);
            //return result;

            //for (double z = x0; z < x1; z += dx)
            //{
            //    double y = f(z);
            //    double area = y * dx;

            //    result += area;
            //}

            return result;
        }
        static void Main(string[] args)
        {
            double integral = CalcularArea(x =>
            {
                return 2 * (x * x * x) + x;
            
            },0.0, 5.0);

            Console.WriteLine(integral);

        }
    }
}