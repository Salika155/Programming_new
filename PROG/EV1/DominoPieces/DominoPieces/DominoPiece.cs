using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DominoPieces
{
    public class DominoPiece
    {
        

        private int _value1;
        private int _value2;


        static DominoPiece()
        {
            _value1 = 1;
            _value2 = 2;
        }

        public DominoPiece(int v1, int v2)
        {
            _value1 = v1;
            _value2 = v2;
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

        public void SetValue1(int v1)
        {
            _value1 = v1;
        }

        public void SetValue2(int v2)
        {
            _value2 = v2;
        }
    }
}
