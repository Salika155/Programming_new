using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum ColorType
{
    BLUE,
    WHITE,
    BLACK
}

namespace ClasesDelfin
{
    public class Delfin
    {
        public double size;
        public double life;
        public string name;
        public ColorType color;

        //funcion de objeto
        public double GetLifePercent()
        {
            return life / 10.0;

        }

        public bool IsAlive()
        {
            return life > 0.0;
        }
    }
}
