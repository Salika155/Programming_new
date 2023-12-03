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
            return false;
        }
        public static bool CanBishopMoveTo(ChessFigure figure, int targetX, int targetY)
        {

            if (!IsOnTheTable(figures, targetX, targetY))
                return false;

            int x = figure.GetX();
            int y = figure.GetY();

            if (CanFiguresMoveLikeBishopTo(targetX, targetY, x + 1, y + 1) == true)
                return true;
            if (CanFiguresMoveLikeBishopTo(targetX, targetY, x - 1, y - 1) == true)
                return true;
            if (CanFiguresMoveLikeBishopTo(targetX, targetY, x + 1, y - 1) == true)
                return true;
            if (CanFiguresMoveLikeBishopTo(targetX, targetY, x - 1, y + 1) == true)
                return true;
            return false;
        }
        public static bool CanKingMoveTo(ChessFigure figure, int targetX, int targetY)
        {
            if (!IsOnTheTable(figures, targetX, targetY))
                return false;

            int x = figure.GetX();
            int y = figure.GetY();


            if (CanFigureMoveAround(targetX, targetY, x + 1, y + 0) == true)
                return true;
            if (CanFigureMoveAround(targetX, targetY, x - 1, y + 0) == true)
                return true;
            if (CanFigureMoveAround(targetX, targetY, x + 1, y + 1) == true)
                return true;
            if (CanFigureMoveAround(targetX, targetY, x + 0, y + 1) == true)
                return true;
            if (CanFigureMoveAround(targetX, targetY, x - 1, y + 1) == true)
                return true;
            if (CanFigureMoveAround(targetX, targetY, x - 1, y - 1) == true)
                return true;
            if (CanFigureMoveAround(targetX, targetY, x + 0, y - 1) == true)
                return true;
            if (CanFigureMoveAround(targetX, targetY, x + 1, y - 1) == true)
                return true;
            return false;
        }
        public static bool CanTowerMoveTo(ChessFigure figure, int targetX, int targetY)
        {
            if (!IsOnTheTable(figures, targetX, targetY))
                return false;

            int x = figure.GetX();
            int y = figure.GetY();


            if (CanFiguresMoveLikeTowerTo(targetX, targetY, x + 1, y + 0) == true)
                return true;
            if (CanFiguresMoveLikeTowerTo(targetX, targetY, x - 1, y - 0) == true)
                return true;
            if (CanFiguresMoveLikeTowerTo(targetX, targetY, x + 0, y - 1) == true)
                return true;
            if (CanFiguresMoveLikeTowerTo(targetX, targetY, x + 0, y + 1) == true)
                return true;
            return false;

        }
        public static bool CanQueenMoveTo(ChessFigure figure, int targetX, int targetY)
        {
            if (!IsOnTheTable(figures, targetX, targetY))
                return false;

            int x = figure.GetX();
            int y = figure.GetY();

            if ((CanBishopMoveTo(figure, targetX, targetY) == true) ||
            (CanTowerMoveTo(figure, targetX, targetY) == true) || 
            (CanKingMoveTo(figure,targetX, targetY) == true))
                return true;
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

        public static bool CanPawnMoveTo(ChessFigure figure, int targetX, int targetY)
        {
            if (!IsOnTheTable(figures, targetX, targetY))
                return false;

            int x = figure.GetX();
            int y = figure.GetY();

            return true;
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
            return false;
        }

        public static bool HasTargetFigureTheSameColor(int targetX, int targetY, int xx, int yy)
        {

        }
    }
}
