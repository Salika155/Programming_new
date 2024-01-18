using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraTupla
{
    public class Tupla
    {
        //ecuacion de 2º grado, resultados (r1, r2) y out r1, out r2
        //(-b +- (Raiz b^2 - 4ac) / 2a)

        //(int, string) _tupla = (4, "hola");
        //Tupla<int, string> _tupla2 = new(5, "adios");

        public static void ResultadoTupla(double a, double b, double c, out double raizPositiva, out double raizNegativa)
        {
            a = 1;
            b = 1;
            c = 1;

            raizPositiva = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c) / (2 * a));
            raizNegativa = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c) / (2 * a));
            Tupla.ResultadoTupla(a, b, c, out raizPositiva, out raizNegativa);
        }

        //hecho por javi
        public static bool SolveEquation2(double a, double b, double c, out double res1, out double res2)
        {
            res1 = double.NaN;
            res2 = double.NaN;
            

            if (a == 0.0)
                return false;
            double r = b * b - 4.0 * a * c;
            if (r < 0.0)
                return false;
            double root = Math.Sqrt(r);
            double denom = 1.0 / (2.0 * a);
            res1 = (-b + root) * (denom);
            res2 = (-b - root) * (denom);

            return true;


        }
        
        
    }
}
