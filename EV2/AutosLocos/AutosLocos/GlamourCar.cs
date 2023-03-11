using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocos
{
    public class GlamourCar : Car
    {
        private string _name;
        private double _finetunning;
        private double _ritmo;

        public GlamourCar(string name, double finetunning, double ritmo) :base()
        {
            _name = name;
            _finetunning = finetunning;
            _ritmo = 20;
        }

        

       /* public GlamourCar()
        {

        }

        public double GetVelocityExtra();*/

    }
}
