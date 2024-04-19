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

        public Defense(string v1, Team team1, int v2, int v3)
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
