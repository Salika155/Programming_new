using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    internal class Board
    {
        private List<IFigure> figures;

        public Board()
        {
            figures = new List<IFigure>();
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            figures.Add(new King(FigureColor.BLACK, new Position(4, 0)));
            figures.Add(new King(FigureColor.WHITE, new Position(4, 7)));
        }

        public void RemoveFigure(int x, int y)
        {
            for (int i = 0; i < figures.Count; i++)
            {
                if (figures[i].GetPosition().X == x && figures[i].GetPosition().Y == y)
                    figures.RemoveAt(i);
            }
        }

        public IFigure GetFigureAt(int x, int y)
        {
            foreach(var f in figures)
            {
                if (f.GetPosition().X == x && f.GetPosition().Y == y)
                    return f;
            }
            return null;
        }
    }
}
