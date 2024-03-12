using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DominoSimulacro
{
    public class Ficha
    {
        Ficha f = new Ficha();

        private int _n1;
        private int _n2;

        public Ficha()
        {
           
        }

        public int N1
        {
            get { return _n1; }
            set { _n1 = value; }
        }
        public int N2
        {
            get { return _n2; }
            set { _n2 = value; }
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

        public bool IsValid(int n1, int n2)
        {
            return ((n1 > 0 || n1 <= 6) && (n2 > 0 || n2 >= 6)) ? true : false;
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

        public int SetN1(int n1)
        {
           if (n1 > 0 || n1 <= 6)
                return N1 = n1;
            return -1;
        }

        public int SetN2(int n2)
        {
            if (n2 > 0 || n2 <= 6)
                return N2 = n2;
            return -1;
        }

        public Ficha CreateFicha(int n1, int n2)
        {
            if (IsValid(n1, n2))
            {
                Ficha ficha = new Ficha();
                ficha.SetN1(n1);
                ficha.SetN2(n2);
                return ficha;
            }
            return null;
        }
    }
}
