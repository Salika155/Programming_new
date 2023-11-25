using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Classes
{
    public class ChessUtils
    {
        private static List<ChessFigure> figures = new List<ChessFigure>();


        public static bool CanKnightMoveTo(ChessFigure figure, int targetX, int targetY)
        {

            if (!IsOnTheTable(figures, targetX, targetY))
                return false;

            int x = figure.GetX();
            int y = figure.GetY();

            ChessFigure? f;
            int xx;
            int yy;

            xx = x + 1;
            yy = y - 2;
            f = GetFigureAt(figures, xx, yy);
            if (xx == targetX && yy == targetY)
                return true;

            xx = x - 1;
            yy = y - 2;
            f = GetFigureAt(figures, xx, yy);
            if (xx == targetX && yy == targetY)
                return true;

            xx = x + 1;
            yy = y + 2;
            f = GetFigureAt(figures, xx, yy);
            if (xx == targetX && yy == targetY)
                return true;

            xx = x - 1;
            yy = y + 2;
            f = GetFigureAt(figures, xx, yy);
            if (xx == targetX && yy == targetY)
                return true;

            xx = x - 2;
            yy = y + 1;
            f = GetFigureAt(figures, xx, yy);
            if (xx == targetX && yy == targetY)
                return true;

            xx = x - 2;
            yy = y - 1;
            f = GetFigureAt(figures, xx, yy);
            if (xx == targetX && yy == targetY)
                return true;

            xx = x + 2;
            yy = y + 1;
            f = GetFigureAt(figures, xx, yy);
            if (xx == targetX && yy == targetY)
                return true;

            xx = x + 2;
            yy = y - 1;
            f = GetFigureAt(figures, xx, yy);
            if (xx == targetX && yy == targetY)
                return true;
            return false;

        }

        public static bool CanBishopMoveTo(ChessFigure figure, int targetX, int targetY)
        {

            if (!IsOnTheTable(figures, targetX, targetY))
                return false;

            int x = figure.GetX();
            int y = figure.GetY();

            ChessFigure? f;
            int xx;
            int yy;

            xx = x + 1;
            yy = y + 1;

            if (targetX > x && targetY > y)
            {
                while (xx != targetX && yy != targetY)
                {
                    f = GetFigureAt(figures, xx, yy);
                    if (f != null)
                        return false;
                    xx++;
                    yy++;
                }
                return true;
            }

            xx = x - 1;
            yy = y - 1;

            if (targetX < x && targetY < y)
            {
                while (xx != targetX && yy != targetY)
                {
                    f = GetFigureAt(figures, xx, yy);
                    if (f != null)
                        return false;
                    xx--;
                    yy--;
                }
                return true;
            }

            xx = x + 1;
            yy = y - 1;

            if (targetX > x && targetY < y)
            {
                while (xx != targetX && yy != targetY)
                {
                    f = GetFigureAt(figures, xx, yy);
                    if (f != null)
                        return false;
                    xx++;
                    yy--;
                }
                return true;
            }

            xx = x - 1;
            yy = y + 1;

            if (targetX < x && targetY > y)
            {
                while (xx != targetX && yy != targetY)
                {
                    f = GetFigureAt(figures, xx, yy);
                    if (f != null)
                        return false;
                    xx--;
                    yy++;
                }
                return true;
            }

            return false;
        }

        public static bool CanKingMove(ChessFigure figure, int targetX, int targetY)
        {
            if (!IsOnTheTable(figures, targetX, targetY))
                return false;

            int x = figure.GetX();
            int y = figure.GetY();
            
            ChessFigure? f;
            int xx;
            int yy;

            xx = x + 1;
            yy = y + 0;
            f = GetFigureAt(figures, xx, yy);
            if (xx == targetX && yy == targetY)
                return true;

            xx = x - 1;
            yy = y + 0;
            f = GetFigureAt(figures, xx, yy);
            if (xx == targetX && yy == targetY)
                return true;

            xx = x + 1;
            yy = y + 1;
            f = GetFigureAt(figures, xx, yy);
            if (xx == targetX && yy == targetY)
                return true;

            xx = x + 0;
            yy = y + 1;
            f = GetFigureAt(figures, xx, yy);
            if (xx == targetX && yy == targetY)
                return true;

            xx = x - 1;
            yy = y + 1;
            f = GetFigureAt(figures, xx, yy);
            if (xx == targetX && yy == targetY)
                return true;

            xx = x - 1;
            yy = y - 1;
            f = GetFigureAt(figures, xx, yy);
            if (xx == targetX && yy == targetY)
                return true;

            xx = x + 0;
            yy = y - 1;
            f = GetFigureAt(figures, xx, yy);
            if (xx == targetX && yy == targetY)
                return true;

            xx = x + 1;
            yy = y - 1;
            f = GetFigureAt(figures, xx, yy);
            if (xx == targetX && yy == targetY)
                return true;

            return false;
        }
        
        public static ChessFigure? GetFigureAt(List<ChessFigure> figures, int x, int y)
        {
            for (int i = 0; i < figures.Count; i++)
            {
                ChessFigure figure = figures[i];
                if (figure.GetX() == x && figure.GetY() == y)
                    return figure;
            }
            return null;
        }

        public static bool IsOnTheTable(List<ChessFigure> figures, int x, int y)
        {
            if (figures == null /*|| figures */)
                return false;

            ChessFigure? figure = GetFigureAt(figures, x, y);
            return figure != null;

        }
    }
}
