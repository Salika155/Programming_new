using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Autos_Locos
{
    public class WoodCar : Car
    {
        public WoodCar() : base(Utils.GetRandomDouble(0.0, 3.0), 15, GenerateDrivers(), "WoodCar")
        {
        }

        public override void Simulate(IRace race)
        {
            base.Simulate(race);
        }

        private static List<Driver> GenerateDrivers()
        {
            return new List<Driver> { new Human("Leñador"), new Animal("Castor") };
        }
    }
}
