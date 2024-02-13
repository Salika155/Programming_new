using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocos
{
    public abstract class Race : IRace
    {
        Race race;

        public List<Driver> GetObjectCount(object obj)
        {
            throw new NotImplementedException();
        }

        public void Init(double distance)
        {
            throw new NotImplementedException();
        }

        public void PrintDrivers()
        {
            throw new NotImplementedException();
        }

        public List<RaceObject> Simulate()
        {
            throw new NotImplementedException();
        }
    }
}
