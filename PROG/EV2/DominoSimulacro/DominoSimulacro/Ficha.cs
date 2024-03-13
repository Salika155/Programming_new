using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DominoSimulacro
{
    public enum FichaType
    {
        Ficha,
        Doble,
        Invalid
    }

    public class Ficha
    {
        //Ficha f = new Ficha();

        private int _n1;
        private int _n2;

        public Ficha(int n1, int n2)
        {
            _n1 = n1;
            _n2 = n2;
        }

        public int N1
        {
            get { return _n1; }
        }
        public int N2
        {
            get { return _n2; }
        }

        public bool IsDoble
        {
            get { return _n1 == _n2; }
        }

        public int Suma
        {
            get { return _n1 + _n2; }
        }

        public bool IsDouble()
        {
            return IsDoble;
        }

        public bool IsValid()
        {
            return ((_n1 >= 0 && _n1 <= 6) && (_n2 >= 0 && _n2 >= 6)) ? true : false;
        }

        public int GetN1()
        {
            return N1;
        }
        public int GetN2() 
        {
            return N2;
        }

        public int GetSuma()
        {
            return Suma;
        }
    }
}
