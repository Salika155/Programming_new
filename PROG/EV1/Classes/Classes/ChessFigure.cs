using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum ChessFigureColor
    {
        BLACK,
        WHITE
    }

    public enum ChessFigureType
    {
        KNIGHT,
        BISHOP,
        PAWN,
        QUEEN,
        KING,
        TOWER
    }
       
    public class ChessFigure
    {
        private int _x;
        private int _y;
        private ChessFigureColor _ColorType;
        private ChessFigureType _FigureType;
        private int _movementCount; 

        public ChessFigure(int x, int y, ChessFigureColor colorType, ChessFigureType figureType)
        {
            _x = x;
            _y = y;
            _ColorType = colorType;
            _FigureType = figureType;
            _movementCount = 0;
        }

        public bool IsValid()
        {
            return ((_x >= 0 && _x <= 7) && (_y >= 0 && _y <= 7));
            //if (_FigureType == ChessFigureType.KING || _FigureType == ChessFigureType.QUEEN ||
            //    _FigureType == ChessFigureType.KNIGHT || _FigureType == ChessFigureType.PAWN ||
            //    _FigureType == ChessFigureType.TOWER || _FigureType == ChessFigureType.BISHOP)
            //{
            //    return true;
            //}
            //return false;
        }

        public int GetX()
        { 
            return _x; 
        }
        public int GetY()
        {
            return _y;
        }
        public ChessFigureColor GetColorType() 
        {
            return _ColorType;
        }

        public ChessFigureType GetFigureType() 
        {
            return _FigureType;
        }

        internal void MoveTo(int x, int y)
        {
            if ((x >= 0 && x <= 7) && (y >= 0 && y <= 7))
            {
                _x = x;
                _y = y;
                _movementCount++;
            }
        }

        public int GetMovementCount()
        {
            return _movementCount;
        }

        public bool HasBeenMoved()
        {
            return _movementCount > 0;
        }

        //public void ChessFigure promove()
        //{

        //}

        public void GetRectangle()
        {

        }

    }
}
