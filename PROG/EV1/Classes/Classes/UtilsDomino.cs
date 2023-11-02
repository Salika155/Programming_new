using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class UtilsDomino
    {
        private static Random r = new Random();

        public static int GetRandom()
        {
            return r.Next();
        }

        public static int GetRandom(int min, int max)
        {
            return r.Next(min, max + 1);
        }
    }
}
