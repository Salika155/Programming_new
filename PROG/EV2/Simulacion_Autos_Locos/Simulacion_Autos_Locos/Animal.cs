using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Autos_Locos
{
    public class Animal : Driver
    {
        public Animal(string name) : base(name)
        {
        }

        public override double GetVelocityExtra()
        {
            return 3;
        }
    }
}
