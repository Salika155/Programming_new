using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    internal class Utils
    {
        Random random = new Random();

        public int GetRandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }

    }
}
