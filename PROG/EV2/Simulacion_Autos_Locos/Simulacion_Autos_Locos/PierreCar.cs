using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Autos_Locos
{
    internal class PierreCar : Car
    {
        public PierreCar() : base(Utils.GetRandomDouble(0.0, 3.0), 20, GenerateDrivers(), "PierreCar")
        {
        }

        static List<Driver> GenerateDrivers()
        {
            return new List<Driver> { new Human("Pierre") };
        }

        public override void Simulate(IRace race)
        {
            base.Simulate(race);
        }
    }
    
    
}
