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

        public Dementor(string v1, Team team1, int v2, int v3) : this(v1, team1, v2, v3)
        {
        }

        public override void ExecuteTurn(IBoardGame boardGame)
        {
            throw new NotImplementedException();
        }
    }
}
