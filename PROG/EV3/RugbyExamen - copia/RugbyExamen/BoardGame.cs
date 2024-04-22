using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{

    public interface IBoardGame
    {
        const int WIDTH = 10;
        const int HEIGHT = 20;

        bool IsAvailable(int x, int y);
        Character? GetCharacterAt(int x, int y);
        void AddPlayer(Character character);
        Ball GetBall();
        bool IsOnTheBoard(Position position)
        {
            //if (position == null)
            //{
            //    return false;
            //}
            //return IsOnTheBoard(position.x, position.y);
            return position == null ? false : IsAvailable(position.GetX(), position.GetY());
        }

        
    }

    

        public class BoardGameBasedInArray : IBoardGame
        {
            public void AddPlayer(Character character)
            {
                throw new NotImplementedException();
            }

            public Ball GetBall()
            {
                throw new NotImplementedException();
            }

            public Character? GetCharacterAt(int x, int y)
            {
                throw new NotImplementedException();
            }

            public bool IsAvailable(int x, int y)
            {
                throw new NotImplementedException();
            }
        }

       
    
}
