using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;

namespace BuscaminasBiblio
{
    // Javi: Clase sin hacer
    public class Board3 : IBoard
    {
        private Cell [,] _cells;
        private int _width;
        private int _height;
        private Flag [,] _flags;
        private Bomb[,] _bombs;

        public Board3(Cell[,] cells, Bomb[,] bombs, int with, int height, Flag[,] flags)
        {
            _width = with;
            _height = height;
            _cells = new Cell[_width, _height];
            _bombs = new Bomb[_width, _height];
            _flags= new Flag[_width, _height];

            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    _cells[i, j] = new Cell();
                }
            }

            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    _bombs[i, j] = new Bomb();
                }
            }

            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    _flags[i, j] = new Flag();
                }
            }

        }

        void IBoard.CreateBoard(int width, int height)
        {
            _width = width;
            _height = height;

            _cells = new Cell[_width, _height];
            _flags = new Flag[_width, _height];
            _bombs = new Bomb[_width, _height];

            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    _cells[i, j] = new Cell();
                }
            }
        }

        void IBoard.DeleteFlagAt(int x, int y)
        {
            throw new NotImplementedException();
        }

        int IBoard.GetBombProximity(int x, int y)
        {
            throw new NotImplementedException();
        }

        int IBoard.GetHeight()
        {
            throw new NotImplementedException();
        }

        int IBoard.GetWidth()
        {
            throw new NotImplementedException();
        }

        bool IBoard.HasWin(int x, int y)
        {
            throw new NotImplementedException();
        }

        void IBoard.Init(int x, int y, int bombCount)
        {
            throw new NotImplementedException();
        }

        bool IBoard.IsBombAt(int x, int y)
        {
            throw new NotImplementedException();
        }

        bool IBoard.IsFlagAt(int x, int y)
        {
            throw new NotImplementedException();
        }

        bool IBoard.IsOpen(int x, int y)
        {
            throw new NotImplementedException();
        }

        bool IBoard.OpenCell(int x, int y)
        {
            Cell cell = _cells[x, y];
            throw new NotImplementedException();
        }

        void IBoard.PutFlagAt(int x, int y)
        {
            _flags[x, y] = new Flag();
        }

    }
}
