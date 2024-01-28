using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraDeDios
{

    public delegate int ComparatorDelegate<T>(T n1, T n2);
    public class Utils
    {
        public static void Swap<T>(ref T a, ref T b)
        {

            T aux = a;
            a = b;
            b = aux;
        }

        public static void Sort<T>(T[] array, ComparatorDelegate<T> comparer)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer(array[i], array[j]) < 0)
                    {
                        Swap(ref array[i],ref array[j]);
                        
                    }
                }
            }
        }
    }
}







