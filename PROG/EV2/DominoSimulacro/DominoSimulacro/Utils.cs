using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoSimulacro
{
    public class Utils
    {
        Random _r = new Random();

        public int RandomNumber(int min, int max)
        {

            return _r.Next(min, max);
        }

        public int GetRandom(int min, int max)
        {
            return _r.Next(min, max + 1);
        }
    }
}
