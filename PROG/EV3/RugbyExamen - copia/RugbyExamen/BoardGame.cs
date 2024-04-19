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

    //public class BoardGame : IBoardGame
    //{
    //    List<Character> _characterList;
    //    private int _width;
    //    private int _height;
    //    private Ball _ball;

    //    public BoardGame(int width, int height)
    //    {
    //        this._width = width;
    //        this._height = height;
    //        _characterList = new List<Character>();
    //    }

    //    public void PintBoard()
    //    {
    //        for (int y = 0; y <= _height; y++)
    //        {
    //            for(int x = 0; x <= _width; x++)
    //            {
    //                Position position = new Position(x, y);
    //                if (_ball.Position == position)
    //                {
    //                    Console.Write("O ");
    //                }
    //                else if (IsOccupied(position))
    //                {
    //                    Console.Write("X ");
    //                }
    //                else
    //                {
    //                    Console.Write("- ");
    //                }
    //            }
    //        }
    //    }

        

        //public bool IsOccupied(Position position)
        //{
        //    for (int i = 0; i < _characterList.Count; i++)
        //    {
        //        if (_characterList[i].Position == position)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //public void CreateCharacter(int count, CharacterType type, TeamType team)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Character character = null;
                
        //        _characterList.Add(character);


        //    }
        //}

        //public void CreateCharacter(int striker, int defense, int specialDef)
        //{
        //    CreateCharacter(striker, CharacterType.Striker);
        //    CreateCharacter(defense, CharacterType.Defense);
        //    CreateCharacter(specialDef, CharacterType.SpecialDefense);
        //}

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
