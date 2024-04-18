using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public class SpecialDefense : Defense
    {
        public SpecialDefense(string name, TeamType team, int x, int y) : base(name, team, x, y)
        {
        }
    }
}
