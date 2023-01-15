using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib
{
    public class Board : IBoard
    {
        
        List<Figure> _figureList;

        public Board()
        {
            _figureList = new List<Figure>();

            //White
            Figure towerwa = new Figure();
            towerwa._x = 0;
            towerwa._y = 0;
            towerwa._color = ColorType.WHITE;
            towerwa._type = FigureType.TOWER;
            _figureList.Add(towerwa);

            Figure towerwb = new Figure();
            towerwb._x = 7;
            towerwb._y = 0;
            towerwb._color = ColorType.WHITE;
            towerwb._type = FigureType.TOWER;
            _figureList.Add(towerwb);

            Figure knightwa = new Figure();
            knightwa._x = 1;
            knightwa._y = 0;
            knightwa._color = ColorType.WHITE;
            knightwa._type = FigureType.KNIGHT;
            _figureList.Add(knightwa);

            Figure knightwb = new Figure();
            knightwb._x = 6;
            knightwb._y = 0;
            knightwb._color = ColorType.WHITE;
            knightwb._type = FigureType.KNIGHT;
            _figureList.Add(knightwb);

            Figure bishopwa = new Figure();
            bishopwa._x = 2;
            bishopwa._y = 0;
            bishopwa._color = ColorType.WHITE;
            bishopwa._type = FigureType.BISHOP;
            _figureList.Add(bishopwa);

            Figure bishopwb = new Figure();
            bishopwb._x = 5;
            bishopwb._y = 0;
            bishopwb._color = ColorType.WHITE;
            bishopwb._type = FigureType.BISHOP;
            _figureList.Add(bishopwb);

            Figure kingw = new Figure();
            kingw._x = 3;
            kingw._y = 0;
            kingw._color = ColorType.WHITE;
            kingw._type = FigureType.KING;
            _figureList.Add(kingw);

            Figure queenw = new Figure();
            queenw._x = 4;
            queenw._y = 0;
            queenw._color = ColorType.WHITE;
            queenw._type = FigureType.QUEEN;
            _figureList.Add(queenw);

            Figure poundw0 = new Figure();
            poundw0._x = 0;
            poundw0._y = 1;
            poundw0._color = ColorType.WHITE;
            poundw0._type = FigureType.PAWN;
            _figureList.Add(poundw0);

            Figure poundw1 = new Figure();
            poundw1._x = 1;
            poundw1._y = 1;
            poundw1._color = ColorType.WHITE;
            poundw1._type = FigureType.PAWN;
            _figureList.Add(poundw1);

            Figure poundw2 = new Figure();
            poundw2._x = 2;
            poundw2._y = 1;
            poundw2._color = ColorType.WHITE;
            poundw2._type = FigureType.PAWN;
            _figureList.Add(poundw2);

            Figure poundw3 = new Figure();
            poundw3._x = 3;
            poundw3._y = 1;
            poundw3._color = ColorType.WHITE;
            poundw3._type = FigureType.PAWN;
            _figureList.Add(poundw3);

            Figure poundw4 = new Figure();
            poundw4._x = 4;
            poundw4._y = 1;
            poundw4._color = ColorType.WHITE;
            poundw4._type = FigureType.PAWN;
            _figureList.Add(poundw4);

            Figure poundw5 = new Figure();
            poundw5._x = 5;
            poundw5._y = 1;
            poundw5._color = ColorType.WHITE;
            poundw5._type = FigureType.PAWN;
            _figureList.Add(poundw5);

            Figure poundw6 = new Figure();
            poundw6._x = 6;
            poundw6._y = 1;
            poundw6._color = ColorType.WHITE;
            poundw6._type = FigureType.PAWN;
            _figureList.Add(poundw6);

            Figure poundw7 = new Figure();
            poundw7._x = 7;
            poundw7._y = 1;
            poundw7._color = ColorType.WHITE;
            poundw7._type = FigureType.PAWN;
            _figureList.Add(poundw7);

            //black

            Figure towerba = new Figure();
            towerba._x = 7;
            towerba._y = 0;
            towerba._color = ColorType.BLACK;
            towerba._type = FigureType.TOWER;
            _figureList.Add(towerba);

            Figure towerbb = new Figure();
            towerbb._x = 7;
            towerbb._y = 0;
            towerbb._color = ColorType.BLACK;
            towerbb._type = FigureType.TOWER;
            _figureList.Add(towerbb);

            Figure knightba = new Figure();
            knightba._x = 7;
            knightba._y = 0;
            knightba._color = ColorType.BLACK;
            knightba._type = FigureType.KNIGHT;
            _figureList.Add(knightba);

            Figure knightbb = new Figure();
            knightbb._x = 7;
            knightbb._y = 0;
            knightbb._color = ColorType.BLACK;
            knightbb._type = FigureType.KNIGHT;
            _figureList.Add(knightbb);

            Figure bishopba = new Figure();
            bishopba._x = 7;
            bishopba._y = 0;
            bishopba._color = ColorType.BLACK;
            bishopba._type = FigureType.BISHOP;
            _figureList.Add(bishopba);

            Figure bishopbb = new Figure();
            bishopbb._x = 7;
            bishopbb._y = 0;
            bishopbb._color = ColorType.BLACK;
            bishopbb._type = FigureType.BISHOP;
            _figureList.Add(bishopbb);

            Figure kingb = new Figure();
            kingb._x = 7;
            kingb._y = 0;
            kingb._color = ColorType.BLACK;
            kingb._type = FigureType.KING;
            _figureList.Add(kingb);

            Figure queenb = new Figure();
            queenb._x = 7;
            queenb._y = 0;
            queenb._color = ColorType.BLACK;
            queenb._type = FigureType.QUEEN;
            _figureList.Add(queenb);

            Figure poundb0 = new Figure();
            poundb0._x = 6;
            poundb0._y = 0;
            poundb0._color = ColorType.BLACK;
            poundb0._type = FigureType.PAWN;
            _figureList.Add(poundb0);

            Figure poundb1 = new Figure();
            poundb1._x = 6;
            poundb1._y = 1;
            poundb1._color = ColorType.BLACK;
            poundb1._type = FigureType.PAWN;
            _figureList.Add(poundb1);

            Figure poundb2 = new Figure();
            poundb2._x = 6;
            poundb2._y = 2;
            poundb2._color = ColorType.BLACK;
            poundb2._type = FigureType.PAWN;
            _figureList.Add(poundb2);

            Figure poundb3 = new Figure();
            poundb3._x = 6;
            poundb3._y = 3;
            poundb3._color = ColorType.BLACK;
            poundb3._type = FigureType.PAWN;
            _figureList.Add(poundb3);

            Figure poundb4 = new Figure();
            poundb4._x = 6;
            poundb4._y = 4;
            poundb4._color = ColorType.BLACK;
            poundb4._type = FigureType.PAWN;
            _figureList.Add(poundb4);

            Figure poundb5 = new Figure();
            poundb5._x = 6;
            poundb5._y = 5;
            poundb5._color = ColorType.BLACK;
            poundb5._type = FigureType.PAWN;
            _figureList.Add(poundb5);

            Figure poundb6 = new Figure();
            poundb6._x = 6;
            poundb6._y = 6;
            poundb6._color = ColorType.BLACK;
            poundb6._type = FigureType.PAWN;
            _figureList.Add(poundb6);

            Figure poundb7 = new Figure();
            poundb7._x = 6;
            poundb7._y = 7;
            poundb7._color = ColorType.BLACK;
            poundb7._type = FigureType.PAWN;
            _figureList.Add(poundb7);

        }
    }
}
