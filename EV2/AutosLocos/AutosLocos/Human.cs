using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocos
{
    public class Human : Driver
    {
        private string _name;

        /*public Human(string _name) : base()
        public abstract double GetVelocityExtra(DriverType, )
        {

        }*/

        public override double GetVelocityExtra(double velocity)
        {
            throw new NotImplementedException();
        }
    }
}
