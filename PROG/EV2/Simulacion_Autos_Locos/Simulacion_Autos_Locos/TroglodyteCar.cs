using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Autos_Locos
{
    public class TroglodyteCar : Car
    {
        public TroglodyteCar() : base(Utils.GetRandomDouble(0.0, 3.0), 20, GenerateDrivers(), "TroglodyteCar")
        {
        }

        public override void Simulate(IRace race)
        {
            base.Simulate(race);
        }

        static List<Driver> GenerateDrivers()
        {
            return new List<Driver> { new Human("Troglodyte 1"), new Human("Troglodyte 2") };
        }


    }
}
