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

        public Dementor(string name, Position position) : base(position)
        {
            
        }

        public Dementor(Position position) : this(position)
        {
           
        }

        public override void ExecuteTurn(IBoardGame boardGame)
        {
            throw new NotImplementedException();
        }
    }
}
