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

        //public int X
        //{ get { return _x; } set { _x = value; } }
        //public int Y
        //{ get { return _y; } set { _y = value; } }
        
        public List<Position> GetPossibleMoves(Game g, int distance)
        {
            List<Position> possibleMoves = new List<Position>();
            
            return possibleMoves;
        }
        

        public virtual void ExecuteTurn()
        {
           
        }

        //public void Move(int x, int y)
        //{
        //    _x = x;
        //    _y = y;
        //}

    }
}
