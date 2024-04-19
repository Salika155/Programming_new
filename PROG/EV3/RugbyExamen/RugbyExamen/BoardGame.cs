using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public class BoardGame
    {
        List<Character> _characterList;
        private int _width;
        private int _height;
        private Ball _ball;

        public BoardGame(int width, int height)
        {
            this._width = width;
            this._height = height;
            _characterList = new List<Character>();
        }

        public void PintBoard()
        {
            for (int y = 0; y <= _height; y++)
            {
                for(int x = 0; x <= _width; x++)
                {
                    Position position = new Position(x, y);
                    if (_ball.Position == position)
                    {
                        Console.Write("O ");
                    }
                    else if (IsOccupied(position))
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
            }
        }

        

        public bool IsOccupied(Position position)
        {
            for (int i = 0; i < _characterList.Count; i++)
            {
                if (_characterList[i].Position == position)
                {
                    return true;
                }
            }
            return false;
        }

        public void CreateCharacter(int count, CharacterType type, TeamType team)
        {
            for (int i = 0; i < count; i++)
            {
                Character character = null;
                
                _characterList.Add(character);


            }
        }

        public void CreateCharacter(int striker, int defense, int specialDef)
        {
            CreateCharacter(striker, CharacterType.Striker);
            CreateCharacter(defense, CharacterType.Defense);
            CreateCharacter(specialDef, CharacterType.SpecialDefense);
        }
    }
}
