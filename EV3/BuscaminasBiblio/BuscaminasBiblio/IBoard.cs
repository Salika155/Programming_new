using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasBiblio
{
    internal interface IBoard
    {
       private int GetWidth();

        private int GetHeight();

        private void CreateBoard(double width, double height);

       private void Init(int x, int y, int bombCount);

        private bool IsBombAt(int x, int y);

        private int GetBombProximity(int x, int y);

        bool IsFlagAt(int x, int y);

        void PutFlagAt(int x, int y);

        void DeleteFlagAt(int x, int y);

        bool HasWin(int x, int y);

        bool IsOpen(int x, int y);

        bool OpenCell(int x, int y);
    }
}
