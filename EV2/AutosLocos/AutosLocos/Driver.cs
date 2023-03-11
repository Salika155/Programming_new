using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocos
{

    public enum DriverType
    {
        Human,
        Animal
    }
    public abstract class Driver
    {
        List<Driver> drivers = new List<Driver>();

        public abstract double GetVelocityExtra(double velocity);
    }
}
