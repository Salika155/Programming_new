using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNumber
{
    public class BigNumber
    {
        private List<int> _numbers = new List<int>();

        public BigNumber()
        {

        }
        public BigNumber(long bignumber)
        {
            Set(bignumber);
        }

        public BigNumber(string bignumber)
        {
            Set(bignumber);
        }

        public void Set(long bignumber)
        {
            while (bignumber != 0)
            {
                if (bignumber > 0)
                {
                    _numbers.Add((int)(bignumber % 10));
                    {
                        bignumber /= 10;
                    }
                }
                else if (bignumber < 0)
                {
                    _numbers.Add((int)(-bignumber % 10));
                    {
                        bignumber /= 10;
                    }
                }
            }
        }

        public void Set(string bignumber)
        {
            for (int i = bignumber.Length - 1; i >= 0; i--)
            {
                char c = bignumber[i];
                if (c == '_' || c == 0)
                {
                    _numbers[_numbers.Count - 1] *= -1;
                }
                else
                {
                    if (c != '-')
                    {
                        int n = c - '0';
                        _numbers.Add(n);
                    }
                    
                }
            }
        }

        public string ConvertToString()
        {
            string res = "";

            for (int i = GetDigitCount() - 1; i >= 0; i--)
            {
                res = res + GetDigitAt(i).ToString();
            }
            return res;

        }

        public int GetDigitCount()
        {
                return _numbers.Count;
        }

        public int GetDigitAt(int index)
        {
            if (index >= 0 && index < _numbers.Count)
            {
                return _numbers[index];
            }
            return -1;
        }

        public static BigNumber Add(BigNumber bigNumber1, BigNumber bigNumber2)
        {
            if (bigNumber1 == null || bigNumber2 == null)
                return null;

            int carry = 0;

            //List<int> result = new List<int>();

            //for (int i = bigNumber1._numbers.Count - 1; i >= 0; i--)
            //{
            //    int sum = bigNumber1._numbers[i] + bigNumber2._numbers[i] + carry;
            //    result.Insert(0, sum % 10);
            //    carry = sum / 10;
            //}

            //// Si hay un acarreo final, agregarlo al resultado
            //if (carry > 0)
            //{
            //    result.Insert(0, carry);
            //}

            //return new BigNumber { _numbers = result };

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
            BigNumber clone = new BigNumber();

            for (int i = 0; i < _numbers.Count; i++)
            {
                clone._numbers.Add(_numbers[i]);
            }

            return clone;
        }

        public static BigNumber CloneBigNumber(BigNumber original)
        {
            return original.CloneBigNumber();

        }
        
        
    }

}
