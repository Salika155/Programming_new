using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    public enum FigureColor
    {
        BLACK,
        WHITE,
        UNKNOWN
    }

    public enum FigureType
    {
        Pawn,
        Bishop,
        Knight,
        Rook,
        Queen,
        King
    }

    internal interface IFigure
    {
        FigureColor GetFigureColor();
        FigureType GetFigureType();
        Position GetPosition();
        void MoveTo(Position position);
        List<Position> GetAvailablePosition();
        bool HasBeenMoved();

    }
}
