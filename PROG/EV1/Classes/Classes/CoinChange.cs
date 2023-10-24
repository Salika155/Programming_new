using System.Reflection.Metadata.Ecma335;

namespace Classes
{
    public enum Moneda
    {
        c500,
        c200,
        c100,
        c50,
        c20,
        c10,
        c5,
        c2,
        c1,
        c05,
        c02,
        c01,
        c005,
        c002,
        c001,
    }
    public class CoinChange
    {
        private Moneda moneda;
        public static int ToNumber(Moneda coin)
        {
            if ( coin == Moneda.c500 )
            {
                return 50000;
            }
            if ( coin == Moneda.c200 )
            {
                return 20000;
            }
            if ( coin == Moneda.c100 )
            {
                return 10000;
            }
            if ( coin == Moneda.c50 )
            {
                return 5000;
            }
            if ( coin == Moneda.c20 )
            {
                return 2000;
            }
            if ( coin  == Moneda.c10 )
            {
                return 1000;
            }
            if ( coin == Moneda.c5 )
            {
                return 500;
            }
            if ( coin == Moneda.c2)
                return 200;
            if ( coin == Moneda.c1 )
            {
                return 100;
            }
            if ( coin == Moneda.c05 )
            {
                return 50;
            }
            if ( coin == Moneda.c02 )
            {
                return 20;
            }
            if ( coin == Moneda.c01 )
            {
                return 10;
            }
            if ( coin == Moneda.c005 )
            {
                return 5;
            }
            if ( coin == Moneda.c002)
            {
                return 2;
            }
            if ( coin == Moneda.c001 )
            {
                return 1;
            }
            return 0;
        }

        public static Moneda ToMoneda(int cent)
        {
            if ( cent == 50000)
            {
                return Moneda.c500;
            }
            if ( cent == 20000)
            {
                return Moneda.c200;
            }
            if ( cent == 10000)
            {
                return Moneda.c100;
            }
            if ( cent == 5000)
            {
                return Moneda.c50;
            }
            if ( cent == 2000)
            {
                return Moneda.c20;
            }
            if ( cent == 1000)
            {
                return Moneda.c10;
            }
            if ( cent == 500)
            {
                return Moneda.c5;
            }
            if ( cent == 200)
            {
                return Moneda.c2;
            }
            if ( cent == 100)
            {
                return Moneda.c1;
            }
            if ( cent == 50)
            {
                return Moneda.c05;
            }
            if ( cent == 20)
            {
                return Moneda.c02;
            }
            if ( cent == 10)
            {
                return Moneda.c01;
            }
            if ( cent == 5)
            {
                return Moneda.c005;
            }
            if ( cent == 2)
            {
                return Moneda.c002;
            }
            if ( cent == 1)
            {
                return Moneda.c001;
            }
            return;
        }
    }
}
