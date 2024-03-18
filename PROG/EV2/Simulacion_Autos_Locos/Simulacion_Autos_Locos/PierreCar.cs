using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Autos_Locos
{
    internal class PierreCar : Car
    {
        public PierreCar(string driverName, string driverName2) : base(Utils.GetRandomDouble(0.0, 3.0), 20, GenerateDrivers(driverName), "El Súper Perrari")
        {
        }

        static List<Driver> GenerateDrivers(string driverName)
        {
            return new List<Driver> { new Human("Pierre Nodoyuna"), new Human("Patán") };
        }

        public override void Simulate(IRace race)
        {
            base.Simulate(race);
        }
    }
    
    
}
