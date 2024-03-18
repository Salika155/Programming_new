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

        //Metodo para calcular la distancia entre dos puntos
        public static double CalculateDistance(double value1, double value2)
        {
            if (value1 > value2)
                return value1 - value2;
            else
                return value2 - value1;
        }

        //Metodo para generar las probabilidades de que un evento ocurra
        public static bool Probability(double probability)
        {
            return probability >= RandomRange(0.0, 100.00);
        }

        //Metodo para generar un numero aleatorio entre un rango especifico
        public static double RandomRange(double min, double max)
        {
            if (min > max)
                return r.NextDouble() * (min - max) + max;
            return r.NextDouble() * (max - min) + min;
        }

        public static int GetRandomInt(int min, int max)
        {
            return r.Next(min, max);
        }
    }
}
