using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public class Ball : GameObject
    {
        //de esta manera solo un jugador puede tener la pelota
        public Player? PlayerThatHaveTheBall;
        public Ball(Position position) : base(position)
        {
        }

        public Position GetCoordenadas()
        {
            if (PlayerThatHaveTheBall != null)
            {
                return PlayerThatHaveTheBall.Position;
            }
            return Position;
        }

        

    }
}
