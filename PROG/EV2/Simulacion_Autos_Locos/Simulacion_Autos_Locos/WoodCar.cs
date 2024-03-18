using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Autos_Locos
{
    public class WoodCar : Car
    {
        public WoodCar(string driverName, string driverName2) : base(Utils.GetRandomDouble(0.0, 3.0), 15, GenerateDrivers(driverName), "El Troncoswagen")
        {
        }

        public override void Simulate(IRace race)
        {
            base.Simulate(race);
        }

        private static List<Driver> GenerateDrivers(string driverName)
        {
            return new List<Driver> { new Human("Leñador"), new Animal("Castor") };
        }
    }
}
