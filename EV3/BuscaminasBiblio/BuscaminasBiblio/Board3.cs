using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasBiblio
{
    public class Board3 : IBoard
    {
        void IBoard.CreateBoard(int width, int height)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        void IBoard.PutFlagAt(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
