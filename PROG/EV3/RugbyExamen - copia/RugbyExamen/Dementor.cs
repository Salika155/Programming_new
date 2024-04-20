using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public class Dementor : Character
    {
        //4 dementores

        public Dementor(Position position) : base(position)
        {
            
        }

        public Dementor(Team team1, Position position) : this(team1, position)
        {
        }

        public override void ExecuteTurn(IBoardGame boardGame)
        {
            throw new NotImplementedException();
        }
    }
}
