using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecuation
{
    public class Ecuation
    {
        private double _a;
        private double _b; 
        private double _c;

        public Ecuation(double a, double b, double c) 
        {
            _a = a;
            _b = b;
            _c = c;
        }

       
        public (double sol1, double sol2) GetSqrt()
        {
            double discriminant = GetDiscriminant();
            double result1;
            double result2;

            if ((_a == 0) || (discriminant < 0))
            {
                return (double.NaN, double.NaN);
            }

            double sqrtDiscriminant = Math.Sqrt(discriminant);
            result1 = (-_b + sqrtDiscriminant) / (2 * _a);
            result2 = (-_b - sqrtDiscriminant) / (2 * _a);
            return (result1, result2);
        }

        public double GetDiscriminant()
        {
            return (_b * _b) - (4 * _a * _c);
        }

        public bool ItHasSqrts()
        {
            if (GetDiscriminant() >= 0);
            return true;
        }

        public bool ItHasSqrt()
        {
            if (GetDiscriminant() == 0);
            return true;
        }
    }
}
