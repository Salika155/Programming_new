using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocos
{
    public class TroglodyteCar : Car
    {
        private string _name;
        private int _golpecabeza;

        public TroglodyteCar(string name, double finetunning, double velocity, CarType type) : base(name, finetunning, velocity, type)
        {
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
    }
}
