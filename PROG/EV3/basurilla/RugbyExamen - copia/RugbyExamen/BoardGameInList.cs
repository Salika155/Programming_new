namespace RugbyExamen
{
    public class BoardGameBasedInList : IBoardGame
    {
        private Ball _ball = new Ball(new Position());
        private List<Character> _characterList = new List<Character>();

        public void AddPlayer(Character character)
        {
            if (character == null)
            {
                throw new Exception("El character es null");
            }
            if (!IsAvailable(character.Position.GetX(), character.Position.GetY()))
            {
                throw new Exception("Posicion invalida");
            }
            if (Contains(character))
            {
                throw new Exception("El character ya existe");
            }
            _characterList.Add(character);
        }

        public bool Contains(Character character)
        {
            return IndexOf(character) >= 0;
        }

        private int IndexOf(Character character)
        {
            for (int i = 0; i < _characterList.Count; i++)
            {
                if (_characterList[i] == character)
                {
                    return i;
                }
            }
            return -1;
        }

        public Ball GetBall()
        {
            throw new NotImplementedException();
        }

        public Character? GetCharacterAt(int x, int y)
        {
            foreach (var p in _characterList)
            {
                if (p.Position.x == x && p.Position.y == y)
                {
                    return p;
                }
            }
            return null;
        }

        public bool IsAvailable(int x, int y)
        {
            if (GetCharacterAt(x, y) != null)
            {
                return false;
            }
            if (x < 0 || x >= IBoardGame.WIDTH)
            {
                return false;
            }
            if (y < 0 || y >= IBoardGame.HEIGHT)
            {
                return false;
            }
            return true;
        }
    }
}