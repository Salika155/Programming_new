using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocos
{
    public class Animal : Driver
    {
        private int _name;



       

        public override double GetVelocityExtra(double velocity)
        {
            double velocityextra = (velocity * 3.0);
            return velocityextra;
        }
    }
}
