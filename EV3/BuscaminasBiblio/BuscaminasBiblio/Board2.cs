using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasBiblio
{
    // Javi: Clase sin hacer
    public class Board2 : IBoard
    {
        Bomb[] bombs = new Bomb[10];
        Cell[] cells = new Cell[100];
        Flag[] flags = new Flag[100];

        private int _width;
        private int _height;

        public bool IsOpen(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void CreateBoard(int width, int height)
        {
            _width = width;
            _height = height;
           
        }

        //public void DeleteFlagAt(int x, int y, Flag[] flags)
        //{
        //    for (int i = 0; i < flags.Length; i++)
        //    {
        //        if (flags[i].position.x == x && flags[i].position.y == y)
        //        {
        //            Flag[] newFlags = new Flag[flags.Length - 1];
        //            for (int j  = 0, k = 0; j < flags.Length; j++)
        //            {
        //                if (j != 1)
        //                {
        //                    newFlags[k] = flags[j];
        //                    k++;
        //                }
        //            }
        //            flags = newFlags;
        //            break;
        //        }
        //    }
        //}


        public int GetBombProximity(int x, int y)
        {
            throw new NotImplementedException();
            //int count = 0;

            //for (int i = x - 1; i <= x + 1; i++)
            //{
            //    for (int j = y - 1; j <= y + 1; j++)
            //    {
            //        if (IsBomb(IsOpen))
            //            count++;
            //    }
            //}
            //return count;
        }

        public bool IsBomb(Func<int, int, bool> isOpen)
        {
            throw new NotImplementedException();
        }

        public int GetHeight()
        {
            return _height;
        }

        public int GetWidth()
        {
            return _width;
        }

        public bool HasWin(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void Init(int x, int y, int bombCount)
        {
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    
                }
            }
        }

        public bool IsBombAt(int x, int y)
        {
            for (int i = 0; i <= bombs.Length; i++)
            {
                if (bombs[i].position.x == x && bombs[i].position.y == y)
                    return true;
            }
            return false;
        }

        public bool IsFlagAt(int x, int y)
        {
            for (int i = 0; i <= flags.Length; i++)
            {
                if (flags[i].position.x == x && flags[i].position.y == y)
                    return true;
            }
            return false;
        }

        public bool IsOpen(int x, int y, int IsOpen)
        {
            for (int i = 0; i <= cells.Length; i++)
            {
                if (cells[i].position.x == x && cells[i].position.y == y)
                    return true;
            }
            return false;
        }

        public bool OpenCell(int x, int y)
        {
            //abre una celda, puede ser un numero o una bomba
            if (IsFlagAt(x, y) == false)
                return true;
            return false;
        }

        public void PutFlagAt(int x, int y)
        {
            for (int i = 0; i < cells.Length; i++)
                if (cells[i].position.x != x && cells[i].position.y != y)
                {
                    cells[i].SetFlag();
                }
        }

        void IBoard.DeleteFlagAt(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
