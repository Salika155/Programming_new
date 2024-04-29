using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RugbyExamen
{
    public class Striker : Player
    {
        public Striker(string name, Team team, Position position) : base(name, team, position)
        {

        }

       

        public override void ExecuteTurn(IBoardGame boardGame)
        {
            throw new NotImplementedException();
        }
    }
}
