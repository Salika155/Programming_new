using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public class Defense : Player
    {
        public Defense(string name, Team team, Position position) : base(name, team, position)
        {
        }

        public Defense(string name, Team team, int initialX, int initialY) : this(name, team, new Position(initialX, initialY))
        {
        }

        //public Defense(string name, Team team, int initialX, int initialY) : this(name, team, initialX, initialY)
        //{
        //}

        public override void ExecuteTurn(IBoardGame boardGame)
        {
            throw new NotImplementedException();
        }

    }
}
