using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasBiblio
{
    public class Bombs
    {
        public Position position;
      
       
        public Bombs(Position position)
        {
            this.position = position;
            
        }

        public Position Position { get; }
    }
}
