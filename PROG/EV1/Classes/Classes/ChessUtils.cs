using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Classes
{
    // Javi: A ver, en general este archivo tiene buena pinta, pero creo que hay funciones que no has probado
    public class ChessUtils
    {
        // Javi: Esto no debería ir aquí
        private static List<ChessFigure> figures = new List<ChessFigure>();

        public static bool CanKnightMoveTo(ChessFigure figure, int targetX, int targetY, ChessFigureColor color)
        {

            if (!IsOnTheTable(figures, targetX, targetY))
                return false;

            int x = figure.GetX();
            int y = figure.GetY();

            // Javi: Esto tiene buena pinta
            if (!HasTargetFigureTheSameColor(targetX, targetY, x, y, color))
            {
                if (CanFiguresMoveLikeKnightTo(targetX, targetY, x + 1, y - 2) == true)
                    return true;
                if (CanFiguresMoveLikeKnightTo(targetX, targetY, x - 1, y - 2) == true)
                    return true;
                if (CanFiguresMoveLikeKnightTo(targetX, targetY, x + 1, y + 2) == true)
                    return true;
                if (CanFiguresMoveLikeKnightTo(targetX, targetY, x - 1, y + 2) == true)
                    return true;
                if (CanFiguresMoveLikeKnightTo(targetX, targetY, x - 2, y + 1) == true)
                    return true;
                if (CanFiguresMoveLikeKnightTo(targetX, targetY, x - 2, y - 1) == true)
                    return true;
                if (CanFiguresMoveLikeKnightTo(targetX, targetY, x + 2, y + 1) == true)
                    return true;
                if (CanFiguresMoveLikeKnightTo(targetX, targetY, x + 2, y - 1) == true)
                    return true;
            }
            return false;
        }

        public static bool CanBishopMoveTo(ChessFigure figure, int targetX, int targetY, ChessFigureColor color)
        {
            if (!IsOnTheTable(figures, targetX, targetY))
                return false;

            int x = figure.GetX();
            int y = figure.GetY();

            // Javi: imposible, esto debería estar en un bucle
            if (!HasTargetFigureTheSameColor(targetX, targetY, x, y, color))
            {
                while(x != targetX || y != targetY)
                {
                    x += targetX > x ? 1 : -1;
                    y += targetY > y ? 1 : -1;
                }
                if (!CanFiguresMoveLikeBishopTo(targetX, targetY, x, y))
                    return false;
            }
            return true;
        }

        public static bool CanKingMoveTo(ChessFigure figure, int targetX, int targetY, ChessFigureColor color)
        {
            if (!IsOnTheTable(figures, targetX, targetY))
                return false;

            int x = figure.GetX();
            int y = figure.GetY();

            if (!HasTargetFigureTheSameColor(targetX, targetY, x, y, color))
            {
                int dx, dy;
                dx = targetX > x ? 1 : (targetX < x ? -1 : 0);
                dy = targetY > y ? 1 : (targetY < y ? -1 : 0);

                while (x != targetX || y != targetY)
                {
                    x += dx;
                    y += dy;

                    if(CanFigureMoveAround(targetX, targetY, x, y) == true)
                        return true;
                }
            }
            return false;
        }

        public static bool CanTowerMoveTo(ChessFigure figure, int targetX, int targetY, ChessFigureColor color)
        {
            if (!IsOnTheTable(figures, targetX, targetY))
                return false;

            int x = figure.GetX();
            int y = figure.GetY();

            if (!HasTargetFigureTheSameColor(targetX, targetY, x, y, color))
            {
                int dx, dy;
                dx = targetX > x ? 1 : (targetX < x ? -1 : 0);
                dy = targetY > y ? 1 : (targetY < y ? -1 : 0);

                while (x != targetX || y != targetY)
                {
                    x += dx;
                    y += dy;

                    if (CanFiguresMoveLikeTowerTo(targetX, targetY, x, y))
                        return true;
                }
            }
            return false;
        }

        public static bool CanQueenMoveTo(ChessFigure figure, int targetX, int targetY, ChessFigureColor color)
        {
            if (!IsOnTheTable(figures, targetX, targetY))
                return false;

            int x = figure.GetX();
            int y = figure.GetY();

            if (!HasTargetFigureTheSameColor(targetX, targetY, x, y, color))
            {
                int dx, dy;
                dx = targetX > x ? 1 : (targetX < x ? -1 : 0);
                dy = targetY > y ? 1 : (targetY < y ? -1 : 0);

                while (x != targetX || y != targetY)
                {
                    x += dx;
                    y += dy;

                if ((CanBishopMoveTo(figure, targetX, targetY, color) == true) ||
                (CanTowerMoveTo(figure, targetX, targetY, color) == true))
                        return true;
                }
            }
            return false;
            #region anteriorcodigo
            //ChessFigure? f;
            //int xx;
            //int yy;

            //xx = x + 1;
            //yy = y + 1;

            //if (targetX > x && targetY > y)
            //{
            //    while (xx != targetX && yy != targetY)
            //    {
            //        f = GetFigureAt(figures, xx, yy);
            //        if (f != null)
            //            return false;
            //        xx++;
            //        yy++;
            //    }
            //    return true;
            //}

            //xx = x + 1;
            //yy = y + 0;

            //if (targetX > x && targetY > y)
            //{
            //    while (xx != targetX && yy != targetY)
            //    {
            //        f = GetFigureAt(figures, xx, yy);
            //        if (f != null)
            //            return false;
            //        xx++;
            //        yy++;
            //    }
            //    return true;
            //}

            //xx = x - 1;
            //yy = y + 0;

            //if (targetX > x && targetY > y)
            //{
            //    while (xx != targetX && yy != targetY)
            //    {
            //        f = GetFigureAt(figures, xx, yy);
            //        if (f != null)
            //            return false;
            //        xx++;
            //        yy++;
            //    }
            //    return true;
            //}

            //xx = x + 0;
            //yy = y + 1;

            //if (targetX > x && targetY > y)
            //{
            //    while (xx != targetX && yy != targetY)
            //    {
            //        f = GetFigureAt(figures, xx, yy);
            //        if (f != null)
            //            return false;
            //        xx++;
            //        yy++;
            //    }
            //    return true;
            //}

            //xx = x + 0;
            //yy = y - 1;

            //if (targetX > x && targetY > y)
            //{
            //    while (xx != targetX && yy != targetY)
            //    {
            //        f = GetFigureAt(figures, xx, yy);
            //        if (f != null)
            //            return false;
            //        xx++;
            //        yy++;
            //    }
            //    return true;
            //}

            //xx = x - 1;
            //yy = y - 1;

            //if (targetX < x && targetY < y)
            //{
            //    while (xx != targetX && yy != targetY)
            //    {
            //        f = GetFigureAt(figures, xx, yy);
            //        if (f != null)
            //            return false;
            //        xx--;
            //        yy--;
            //    }
            //    return true;
            //}

            //xx = x + 1;
            //yy = y - 1;

            //if (targetX > x && targetY < y)
            //{
            //    while (xx != targetX && yy != targetY)
            //    {
            //        f = GetFigureAt(figures, xx, yy);
            //        if (f != null)
            //            return false;
            //        xx++;
            //        yy--;
            //    }
            //    return true;
            //}

            //xx = x - 1;
            //yy = y + 1;

            //if (targetX < x && targetY > y)
            //{
            //    while (xx != targetX && yy != targetY)
            //    {
            //        f = GetFigureAt(figures, xx, yy);
            //        if (f != null)
            //            return false;
            //        xx--;
            //        yy++;
            //    }
            //    return true;
            //}
            //return false;
            #endregion
        }

        public static bool CanPawnMoveTo(ChessFigure figure, int targetX, int targetY, ChessFigureColor color)
        {
            if (!IsOnTheTable(figures, targetX, targetY))
                return false;

            int x = figure.GetX();
            int y = figure.GetY();

            if (!HasTargetFigureTheSameColor(targetX, targetY, x, y, color))
            {
                int dy = (color == ChessFigureColor.WHITE) ? 1 : -1;

                while (y + dy == targetY)
                {
                    if (CanFiguresMoveLikePawnTo(targetX, targetY, x, y + dy))
                        return true;
                }
            }
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

        public static bool CanFiguresMoveLikeKnightTo(int targetX, int targetY, int xx, int yy)
        {
            ChessFigure? f = GetFigureAt(figures, xx, yy);
            return xx == targetX && yy == targetY && f == null;
        }

        public static bool CanFiguresMoveLikeBishopTo(int targetX, int targetY, int xx, int yy)
        {
            if (targetX > xx && targetY > yy)
            {
                while (xx != targetX || yy != targetY)
                {
                    ChessFigure? f = GetFigureAt(figures, xx, yy);
                    if (f != null)
                        return false;
                    xx++;
                    yy++;
                }
                return true;
            }
            return false;
        }

        public static bool CanFigureMoveAround(int targetX, int targetY, int xx, int yy)
        {
            ChessFigure? f = GetFigureAt(figures, xx, yy);
            return xx == targetX && yy == targetY && f == null;
        }

        public static bool CanFiguresMoveLikeTowerTo(int targetX, int targetY, int xx, int yy)
        {
            if (targetX > xx && targetY > yy)
            {
                while (xx != targetX && yy != targetY)
                {
                    ChessFigure? f = GetFigureAt(figures, xx, yy);
                    if (f != null)
                        return false;
                    xx++;
                    yy++;
                }
                return true;
            }
            return false;
        }

        public static bool CanFiguresMoveLikePawnTo(int targetX, int targetY, int xx, int yy)
        {
            int deltaX = targetX - xx;
            int deltaY = targetY - yy;

            if (deltaY <= 0 && deltaX != 0 && deltaY != 1)
            {
                return false;
            }
            return true;
    
        }

        public static bool HasTargetFigureTheSameColor(int targetX, int targetY, int xx, int yy, ChessFigureColor color)
        {
            if (!IsOnTheTable(figures, targetX, targetY))
                return false;

                while (xx != targetX || yy != targetY)
                {
                    ChessFigure? f = GetFigureAt(figures, xx, yy);
                    if (f != null)
                    {
                        if (f.GetColorType() == color)
                            return true;
                        else
                        return false;
                    }
                    xx++;
                    yy++;
                }
                return false;
        }
    }
}
