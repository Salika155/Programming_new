
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace BuscaminasBiblio
{
    public class Board1 : IBoard
    {
        List<Position> _bombs = new List<Position>();
        List<Flag> _flags = new List<Flag>();

        private int _width;
        private int _height;

        // Javi: De estas dos listas, una no hace falta. Es decir, si una
        // celda no está abierta, es que está cerrada.

        List<Position> _openCells = new List<Position>();
       
        public void PutFlagAt(int x, int y)
        {
            // Javi: Este algoritmo está mal, lo único que hay que hacer es: si no hay una bandera, ponerla
            Flag flag = new Flag(x, y);
            bool flagExist = false;

            for (int i = 0; i < _flags.Count; i++)
            {
                if (_flags[i].position.x == x && _flags[i].position.y == y)
                {
                    flagExist = true;
                    break;
                }
            }
            if (!flagExist)
                _flags.Add(flag);
        }

        public void DeleteFlagAt(int x, int y)
        {
            for (int i = 0; i < _flags.Count; i++)
            {
                if (_flags[i].position.x == x && _flags[i].position.y == y)
                {
                    _flags.RemoveAt(i);
                    break;
                }
            }
            // Javi: Para ahorrar un poco de cómputo puedes hacer un break
        }

        public bool OpenCell(int x, int y)
        {
            // Javi: Esta función no hace lo que debería, es decir, no abre una celda
            //abre una celda, puede ser un numero o una bomba
            bool canOpenCells = true;

            if (IsFlagAt(x, y))
            {
                canOpenCells = false;
            }
            else if (IsOpen(x, y))
            {
                canOpenCells = false;
            }
            else if (IsBombAt(x, y))
            {
                canOpenCells = false;
            }
            else
            {
                Position cellPosition = new Position(x, y);
                _openCells.Add(cellPosition);
            }
            return canOpenCells;
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
            
        }

        public void Init(int x, int y, int bombCount)
        {
            _openCells.Clear();
            _flags.Clear();
            _bombs.Clear();
            //empieza la partida
            //x e y corresponden a la casilla donde el jugador empieza el juego
            //no puede haber bomba en la casilla de inicio
            
            Utils.GetRandom(x, y);

            while (_bombs.Count < bombCount)
            {
                int bombX = Utils.GetRandom(0, _width);
                int bombY = Utils.GetRandom(0, _height);

                if (bombX != x || bombY != y)
                {
                    Position bombPosition = new Position(bombX, bombY);
                    _bombs.Add(bombPosition);
                }
            }

            // Javi: Yo creo que sería mejor opción llevar sólo la gestión de las celdas abiertas, no las cerradas

        }

        // Javi: Perfecto!!!
        public bool IsBombAt(int x, int y)
        {
            for (int i = 0; i < _bombs.Count; i++)
            {
                if (_bombs[i].x == x && _bombs[i].y == y)
                    return true;
            }
            return false;
        }

        public bool IsFlagAt(int x, int y)
        {
            for (int i = 0; i < _flags.Count; i++)
            {
                if (_flags[i].position.x == x && _flags[i].position.y == y)
                    return true;
            }
            return false;
        }

        public bool IsOpen(int x, int y)
        {
            for (int i = 0; i < _openCells.Count; i++)
            {
                if (_openCells[i].x == x && _openCells[i].y == y)
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
            

            bool isWinner = true;

            if (IsFlagAt(x, y))
            {
                isWinner = false;
            }
            else if (IsOpen(x, y))
            {
                isWinner = false;
            }
            else if (IsBombAt(x, y))
            {
                isWinner = false;
            }
            else
            {
                Position cellPosition = new Position(x, y);
                _openCells.Add(cellPosition);
            }
            return isWinner;
        }
    

        //public bool HasWin(int x, int y)
        //{
        //    // Javi: Este algoritmo se tiene que hacer en la interfaz, y está incorrecto por ahora
        //    //si todas las celdas de numero estan abiertas, y no se ha explotado ninguna bomba
        //    for (int i = 0; i <= _bombs.Count; i++)
        //    {
        //        if (_openCells[i] == _bombs[i])
        //            return false;
        //    }
        //    return true;
        //}

    }
}