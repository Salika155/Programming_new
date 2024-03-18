using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Autos_Locos
{
    public class TroglodyteCar : Car
    {
        public TroglodyteCar(string driverName, string driverName2) : base(Utils.GetRandomDouble(0.0, 3.0), 20, GenerateDrivers(driverName), "El Rocomóvil")
        {
        }

        public override void Simulate(IRace race)
        {
            base.Simulate(race);
        }

        static List<Driver> GenerateDrivers(string driverName)
        {
            return new List<Driver> { new Human("Troglodyte 1"), new Human("Troglodyte 2") };
        }


    }
}
