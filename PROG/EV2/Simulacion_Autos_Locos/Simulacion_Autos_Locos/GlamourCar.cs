using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Autos_Locos
{
    public class GlamourCar : Car
    {
        public GlamourCar() : base(Utils.GetRandomDouble(0.0, 3.0), 20, GenerateDrivers(), "GlamourCar")
        {
        }


        static List<Driver> GenerateDrivers()
        {
            return new List<Driver> { new Human("Penelope") };
        }
    }
}
