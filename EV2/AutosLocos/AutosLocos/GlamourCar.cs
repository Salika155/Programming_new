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

        public GlamourCar(string name, double finetunning, double ritmo) : base(name, finetunning, ritmo)
        {
            _name = name;
            _finetunning = finetunning;
            _ritmo = 20;
        }

        public override ObjectType GetObjectType()
        {
            throw new NotImplementedException();
        }

        public override bool IsEnable()
        {
            throw new NotImplementedException();
        }

        public override void Simulate(IRace race)
        {
            throw new NotImplementedException();
        }



        /* public GlamourCar()
         {

         }

         public double GetVelocityExtra();*/

    }
}
