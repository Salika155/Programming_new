using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocos
{
    public interface IRace
    {
        void Init(double distance);

        public List<RaceObject> Simulate();

        public void PrintDrivers();
        List<Driver>

         GetObjectCount(object obj);

        /*public double GetDistance(double min, double max)
        {
            
        }*/
            
            
    }
}
