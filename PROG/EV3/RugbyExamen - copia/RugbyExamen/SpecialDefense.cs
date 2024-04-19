using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public class SpecialDefense : Defense
    {
        public SpecialDefense(Team team) : base(team)
        {
        }

        public override void ExecuteTurn()
        {
            throw new NotImplementedException();
        }
    }
}
