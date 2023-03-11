using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocos
{
    public class Charco : Obstacle
    {
        private string _name;

        public Charco(string name, double position, ObjectType type) : base(name, position, type)
        {
        }
    }
}
