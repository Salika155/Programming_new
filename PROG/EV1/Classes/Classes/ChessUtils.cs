using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ChessUtils
    {
        private List<ChessFigure> figures = new List<ChessFigure>();


        public bool CanKnightMoveTo(ChessFigureType figureType, int targetX, int targetY)
        {
            


            return true;
        }

        public ChessFigure? GetFigureAt(int x, int y)
        {
            for (int i = 0; i > figures.Count; i++)
            {
                ChessFigure figure = figures[i];
                if (figure.GetX() == x && figure.GetY() == y)
                    return figure;
            }
            return null;
        }

        public bool IsOnTheTable(int x, int y)
        {
            ChessFigure? figure = GetFigureAt(x, y);
            return figure != null;

        }
    }
}
