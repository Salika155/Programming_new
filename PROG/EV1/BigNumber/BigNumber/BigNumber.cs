using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNumber
{
    public class BigNumber
    {
        private List <BigNumber> _list = new List <BigNumber> ();



        public BigNumber(long bignumber)
        {

        }

        public BigNumber(string bignumber)
        {

        }

        public void Set(long bignumber)
        {

        }

        public void Set(string bignumber)
        {

        }

        public string ToString()
        {
            return string.Empty;
        }

        public void GetDigitCount()
        {

        }

        public void GetDigitAt(List<BigNumber> index)
        {

        }

        public static BigNumber Add(BigNumber bigNumber1, BigNumber bigNumber2)
        {
            return Add(bigNumber1, bigNumber2);
        }

        public static BigNumber Substract(BigNumber bigNumber1, BigNumber bigNumber2)
        {
            return Add(bigNumber1, bigNumber2);

        }
        
        public static BigNumber Multiply(BigNumber bigNumber1, BigNumber bigNumber2)
        {
            return Add(bigNumber1, bigNumber2);
        }

        public static BigNumber Division(BigNumber bigNumber1, BigNumber bigNumber2)
        { 
            return Add(bigNumber1, bigNumber2);
        }

        public static BigNumber Module(BigNumber bigNumber1, BigNumber bigNumber2)
        {
            return Add(bigNumber1, bigNumber2);
        }

        public void CloneBigNumber()
        {

        }
             
        
    }

}
