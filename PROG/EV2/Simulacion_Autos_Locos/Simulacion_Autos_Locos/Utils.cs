using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Autos_Locos
{
    public class Utils
    {
        //instancia de la clase Random para generar numeros aleatorios
        //static para que sea unico en toda la aplicacion
        static Random r = new Random();

        //metodo para generar un numero aleatorio entre un rango de doubles
        public static double GetRandomDouble(double min, double max)
        {
            return r.NextDouble() * (max - min) + min;
        }

        //metodo para generar un numero aleatorio entre 0 y 1
        public static double GetRandomDouble()
        {
            return r.NextDouble();
        }
    }
}
