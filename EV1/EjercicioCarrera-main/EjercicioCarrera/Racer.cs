using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCarrera
{
    internal class Racer
    {
        public string Name;
        public double position;

        public void SimulatePosition()
        {
            this.position += 10;
        }
    }
}
