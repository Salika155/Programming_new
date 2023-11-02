using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum FigureColor
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
        private FigureColor _ColorType;
        private ChessFigureType _FigureType;


        public bool IsValid()
        {
            return true;
        }

        public int GetX()
        { 
            return _x; 
        }
        public int GetY()
        {
            return _y;
        }
        public FigureColor GetColorType() 
        {
            return _ColorType;
        }

        public ChessFigureType GetFigureType() 
        {
            return _FigureType;
        }

        internal void MoveTo(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
