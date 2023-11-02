using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class DominoPiece
    {
        DominoPiece f = new DominoPiece();

        private int _value1;
        private int _value2;


        public DominoPiece()
        {
            _value1 = 1;
            _value2 = 2;
        }


        private DominoPiece(int v1, int v2)
        {
            _value1 = v1;
            _value2 = v2;
        }

        //si existe constructor privado, necesario un metodo public static createalgo


        public int GetValue1()
        {
            return _value1;
        }

        public int GetValue2()
        {
            return _value2;
        }

        public int GetTtotalValue()
        {
            return _value1 + _value2;
        }

        public bool IsDouble()
        {
            return _value1 == _value2;
        }

        public bool IsEqual(DominoPiece other)
        {
            return (_value1 == other._value1 && _value2 == other._value2) ||
                (_value2 == other._value2 && _value1 == other._value1);
        }

        //static DominoPiece? create piece
        //public static DominoPiece CreatePiece()
        //{
        //    return new DominoPiece();
        //}

        public static DominoPiece? CreatePiece(int v1, int v2)
        {
            if (v1 < 0 || v1 > 6)
                return null;
            if (v2 < 0 || v2 > 6)
                return null;

            return new DominoPiece(v1, v2);
        }



    }
}


