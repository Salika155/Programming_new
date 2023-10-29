using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DominoPieces
{
    internal class DominoPiece
    {
        DominoPiece d = new DominoPiece();

        private int _value1;
        private int _value2;


        static DominoPiece()
        {
            _value1 = 0;
            _value2 = 0;
        }

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
            if (_value1 == _value2)
                return true;
            return false;
        }

    }
}
