using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ArrayUtils
    {

        public static int FindMaxValorInArray(int[] array)
        {
            if (array == null || array.Length == 0)
                return -1;

            int max = 0;

            foreach (var m in array)
            {
                if (m > max)
                    max = m;
            }
            return max;
        }

        public static double[] RemoveAllOccurrences(double[] array, double value)
        {

        }
    }
}
