using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public class SpecialDefense : Defense
    {
        public SpecialDefense(string name, Team team, Position position) : base(name, team, position)
        {

        }

        public SpecialDefense(string name, Team team, int initialX, int initialY) : this(name, team, new Position(initialX, initialY))
        {
        }

        public override void ExecuteTurn(IBoardGame board)
        {
            throw new NotImplementedException();
        }
    }
}
