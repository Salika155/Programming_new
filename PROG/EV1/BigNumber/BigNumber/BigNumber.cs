using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNumber
{
    public class BigNumber
    {
        private List<int> _numbers = new List<int>();


        public BigNumber(long bignumber)
        {
            long number = bignumber;
        }

        public BigNumber(string bignumber)
        {
            string number = bignumber;
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

        public void GetDigitAt(long index)
        {
            return (index >= 0 && index < _numbers.Count) ? _numbers[index] : null;
               

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

        public BigNumber CloneBigNumber()
        {
            return new BigNumber(_numbers.ToString());
        }
             
        
    }

}
