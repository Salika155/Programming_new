using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecuation
{
    class Ecuacion
    {
        private double _a, _b, _c;
        //private double _a, _b, _c;

        public Ecuacion(double a, double b, double c)
        {
            this._a = a;//this._a
            this._b = b;//this._b
            this._c = c;
        }

        public double[] obtenerRaiz()
            //
        {
            double[] raices = new double[2];
            double discriminante = obtenerDiscriminante();
            if (discriminante >= 0)
            {
                raices[0] = (-_b + Math.Sqrt(discriminante)) / (2 * _a);
                raices[1] = (-_b - Math.Sqrt(discriminante)) / (2 * _a);
                return raices;
            }
            else
            {
                return new double[] { double.NaN, double.NaN };
            }
        }

        //if (!hasroots()&&(!hasroot) 

        //otra
        //if (_a == 0.0)
        //return NaN
        //var disc = GetDiscriminant();
        // if (disc < 0)
        //return NaN;
        //solucion 
        public double obtenerDiscriminante()
        {
            return (_b * _b) - 4.0 * _a * _c;
        }

        public bool tieneRaices()
        {
            return obtenerDiscriminante() >= 0;
        }
        

        public bool tieneRaiz()
        {
            return obtenerDiscriminante() == 0;
        }
        //double aux =tieneraiz
        //return aux ==0
    }

}
