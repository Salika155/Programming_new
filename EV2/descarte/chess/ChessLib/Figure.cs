using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib

{ 

     public enum FigureType
    {
        KING,
        QUEEN,
        BISHOP,
        KNIGHT,
        TOWER,
        PAWN,
    }

    public enum ColorType
    {
        WHITE,
        BLACK,
    }


    public class Figure
    {
            public int _x, _y;
            public ColorType _color;
            public FigureType _type;
        

        public class Color
        {

        }

        public abstract class GetAvailablePosition
        {

        }




    }
}
