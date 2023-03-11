using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocos
{
    public class Utils
    {
        Random r = new Random();

        public double GetRandom(double min, double max)
        {
            return r.NextDouble();
        }
    }
}
