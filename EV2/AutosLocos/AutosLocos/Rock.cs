using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocos
{
    public class Rock : Obstacle
    {
        private string _name;
        private double _peso;

        public Rock(string name, double position, ObjectType type) : base(name, position, type)
        {
        }
    }
}
