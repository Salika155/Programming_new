using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
            // Asegurarse de que el número sea no negativo
            bignumber = GetAbsoluteValue(bignumber);

            // Determinar el signo original
            int sign = (bignumber == 0) ? 0 : 1;

            // Javi: Este bucle creo que está mal planteado
            while (bignumber != 0)
            {
                if (bignumber > 0)
                {
                    _numbers.Add((int)(bignumber % 10 * sign));
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
            bool isNegative = false;

            // Asegurarse de que el número sea no negativo
            int startIndex = 0;

            if (bignumber[0] == '-')
            {
                isNegative = true;
                startIndex = 1;
            }


            // Javi: Esto lo has probado??
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

        // Javi: Función estática
        private long GetAbsoluteValue(long number)
        {
            return number < 0 ? -number : number;
        }


        public string? ConvertToString()
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
        #region Funcion Add
        public static BigNumber? Add(BigNumber bigNumber1, BigNumber bigNumber2)
        {
            if (bigNumber1 == null || bigNumber2 == null)
                return null;

            BigNumber result = bigNumber1.CloneBigNumber();
            BigNumber operad2 = bigNumber2.CloneBigNumber();


            //creo una copia del bn1 como resultado, para asi no modificar el bn1 con las
            //operaciones de carry;

            long length1 = result.GetDigitCount();
            long length2 = bigNumber2.GetDigitCount();

            //bucle for para asegurarme que los dos numeros tendran el missmi numero de unidades
            //si uno es menor que el otro, le añadira 0 a esos valores.

            //si fuese necesario ajustar el tamaño del bn2, haciendo lo misom

            while (bigNumber2.GetDigitCount() < length1)
            {
                bigNumber2._numbers.Add(0);
            }

            while (result.GetDigitCount() < length2)
            {
                result._numbers.Add(0);
            }

            long carry = 0;

            // Javi: El algoritmo parece correcto, pero no creo que hiciese falta hacer un clone de los números de entrada
            for (int i = 0; i < result.GetDigitCount(); i++)
            {
                long digit1 = result.GetDigitAt(i);
                long digit2 = operad2.GetDigitAt(i);

                long sum = digit1 + digit2 + carry;

                carry = sum / 10;

                result._numbers[i] = (int)(sum % 10);
            }

           if (carry > 0)
            {
                result._numbers.Add((int)carry);
            }
            return result;

        }

        #endregion

        public static BigNumber? Substract(BigNumber bigNumber1, BigNumber bigNumber2)
        {
           
            return Add(bigNumber1, bigNumber2);

        }
        
        public static BigNumber? Multiply(BigNumber bigNumber1, BigNumber bigNumber2)
        {
            return Add(bigNumber1, bigNumber2);
        }

        public static BigNumber? Division(BigNumber bigNumber1, BigNumber bigNumber2)
        { 
            return Add(bigNumber1, bigNumber2);
        }

        public static BigNumber? Module(BigNumber bigNumber1, BigNumber bigNumber2)
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
