using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPintar
{
    internal class Interesect
    {
        public static bool CheckCollision(double x, double y, double w, double h, double x2, double y2, double w2, double h2)
        {
            double xm = x - x2;
            double ym = y - y2;
            double wm = w - w2;
            double hm = h - h2;

            if (xm > wm || ym > hm)
                return false;
            if (x2 > wm || y2 > hm)
                return false;
            if (w2 > wm || y2 > hm)
                return false;
            return true;

        }
    }
}
