using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasBiblio
{
    /// <summary>
    /// Clase auxiliar para generar randoms cuando haga falta un valor aleatorio. 
    /// Para este caso con valores INT
    /// </summary>
    public class Utils
    {
        private static Random Random = new Random();

        public static int GetRandom(int min, int max)
        {
            if (min > max)
            {
                int dif = min;
                min = max;
                max = dif;
            }
            return Random.Next(min, max);
        }
    }
}
