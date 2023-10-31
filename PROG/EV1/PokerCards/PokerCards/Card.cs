using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerCards
{
    public enum Palo
    {
        UNKNOWN,
        DIAMANTES,
        TREBOLES,
        CORAZONES, 
        PICAS
    }

    public enum Color
    {
        UNKNOWN,
        ROJO,
        NEGRO
    }

    public enum Figuras
    {
        UNKNOWN,
        JACK,
        QUEEN,
        KING,
        AS,
        JOCKER,
        NONE
    }
        
    public class Card
    {
        private int _number;
        private Palo _palo ;
        //private Color _color;

       
        public Card(int number, Palo palo)
        {
            _number = number;
            _palo = palo;
        }

        public int GetNumber()
        {
            return _number;
        }

        public Palo GetPalo()
        {
            return _palo;
        }

        public Color GetColor()
        {
            if (IsValid())
            {
                if (_palo == Palo.TREBOLES || _palo == Palo.PICAS)
                    return Color.NEGRO;
                else
                    return Color.ROJO;
            }
            return Color.UNKNOWN;
        }

        public bool IsValid()
        {
            if (_number >= 0 && _number < 14)
                return true;
            if (_palo == Palo.UNKNOWN && _number == 0)
                return true;

            return false;
        }

        public bool IsFigure()
        {
            if (IsValid())
            {
                if (_number == 0)
                    return true;
                else if (_number == 1)
                    return true;
                else if (_number == 11)
                    return true;
                else if (_number == 12)
                    return true;
                else if (_number == 13)
                    return true;
            }
            return false;
        }

        public Figuras GetFigureType()
        {
            if (IsValid())
            {
                if (_number == 0)
                    return Figuras.JOCKER;
                else if (_number == 1)
                    return Figuras.AS;
                else if (_number > 2 && _number <= 10)
                    return Figuras.NONE;
                else if (_number == 11)
                    return Figuras.JACK;
                else if (_number == 12)
                    return Figuras.QUEEN;
                else if (_number == 13)
                    return Figuras.KING;
                else return Figuras.UNKNOWN;
            }
            else return Figuras.UNKNOWN;
        }





    }
}
