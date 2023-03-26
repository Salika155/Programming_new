
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace BuscaminasBiblio
{
    public class Board1 : IBoard
    {
        List<Position> bombs = new List<Position>();
        List<Flags> flags = new List<Flags>();

        private int _width;
        private int _height;

        List<Position> openCells = new List<Position>();
        List<Position> closeCells = new List<Position>();


        public void PutFlagAt(int x, int y)
        {
            for (int i = 0; i < flags.Count; i++)
                if (flags[i].position.x != x && flags[i].position.y != y)
                    flags.Add(new Flags(x, y));
        }

        public void DeleteFlagAt(int x, int y)
        {
            for (int i = 0; i < flags.Count; i++)
                if (flags[i].position.x == x && flags[i].position.y == y)
                    flags.RemoveAt(i);
        }

        public bool OpenCell(int x, int y)
        {
            //abre una celda, puede ser un numero o una bomba
            if (IsFlagAt(x, y) == false)
                return true;
            return false;
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetHeight()
        {
            return _height;
        }

        public void CreateBoard(int width, int height)
        {
            _width = width;
            _height = height;
            throw new Exception("No puedes crear un tablero de ese tamaño");
        }

        public void Init(int x, int y, int bombCount)
        {
            //empieza la partida
            //x e y corresponden a la casilla donde el jugador empieza el juego
            //no puede haber bomba en la casilla de inicio

            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    closeCells.Add(new Position(i, j));
                }
            }

            closeCells.Remove(new Position(x, y));
        }

        public bool IsBombAt(int x, int y)
        {
            for (int i = 0; i <= bombs.Count; i++)
            {
                if (bombs[i].x == x && bombs[i].y == y)
                    return true;
            }
            return false;
        }

        public bool IsFlagAt(int x, int y)
        {
            for (int i = 0; i <= flags.Count; i++)
            {
                if (flags[i].position.x == x && flags[i].position.y == y)
                    return true;
            }
            return false;
        }

        public bool IsOpen(int x, int y)
        {
            for (int i = 0; i <= openCells.Count; i++)
            {
                if (openCells[i].x == x && openCells[i].y == y)
                    return true;
            }
            return false;
        }

        public int GetBombProximity(int x, int y)
        {
            int count = 0; 
            //mirar las  casillas a +1 y -1 de la casilla indicada para comprobar si hay bomba o no
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (IsBombAt(i, j))
                        count++;
                }
            }
            return count;
        }

        public bool HasWin(int x, int y)
        {

            //si todas las celdas de numero estan abiertas, y no se ha explotado ninguna bomba
            for (int i = 0; i <= bombs.Count; i++)
            {
                if (openCells[i] == bombs[i])
                    return false;
            }
            return true;
        }

    }
}