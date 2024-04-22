using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public enum CharType
    {
        PLAYER,
        DEMENTOR,
    }

    public abstract class Character
    {
        public Position Position;

        public Character(Position position) 
        {
            Position = position;
        }

        public List<Position> GetPossibleMoves(Game g, int distance)
        {
            List<Position> possibleMoves = new List<Position>();
            
            return possibleMoves;
        }

        public abstract void ExecuteTurn(IBoardGame boardGame);
        //pasarle un partido

    }
}
