using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class ClaseArrays
    {
        public int IndexOf(int value, int[] array)
        {
            for (int i = 0; i < array.Length; i++) 
            {
                if (value == array[i])
                {
                    return i;
                }
            }
            return -1;
        }

        //for dentro de for, compara numero con valores siguientes, si es mayor lo cambia
        public void Sort(int[] array) 
        {
            for (int i = 0; i < array.Length - 1; i++) 
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    array[i] = array[j];
                    array[j] = array[i + 1];
                }
            }
        }


    }
}
