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
                    
                }
            }
        }

        

        public bool IsOccupied(int x, int y)
        {
            for (int i = 0; i < _characterList.Count; i++)
            {
                if (_characterList[i].X == x && _characterList[i].Y == y)
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
