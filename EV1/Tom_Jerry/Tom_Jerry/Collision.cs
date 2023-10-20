using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tom_Jerry
{
    internal class Collision
    {
        public static bool CheckCollision(float x, float y, float w, float h, float x2, float y2, float w2, float h2)

        {
            float xm = x - x2;
            float ym = y - y2;
            float wm = w - w2;
            float hm = h - h2;

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
