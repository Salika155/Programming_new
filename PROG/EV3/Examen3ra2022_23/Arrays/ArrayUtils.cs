using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
            if (array == null)
                return array;

            int count = 0;

            foreach (var n in array)
            {
                if (n == value)
                    count++;
            }

            double[] arraynuevo = new double[array.Length - count];
            var index = 0;
            foreach (var n in array)
            {
                if (n != value)
                    arraynuevo[index] = n;
                index++;
            }
            return arraynuevo;
        }

        //public static double[] RemoveAllOccurrences(double[] array, double value)
        //{
        //    if (array == null)
        //        return array;

        //    int countOcurrences = 0;

        //    foreach (var o in array)
        //    {
        //        if (o == value)
        //        {
        //            countOcurrences++;
        //        }
        //    }

        //    double[] arraysinocurrencias = new double[array.Length - countOcurrences];
        //    int index = 0;

        //    foreach (var i in array)
        //    {
        //        if (i != value)
        //            arraysinocurrencias[index] = i;
        //        index++;
        //    }
        //    return arraysinocurrencias;
        //}

        public static string[] SortStrings(string[] array)
        {
            if (array == null)
                throw new ArgumentException("El array no puede ser nulo");

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (CompareStrings(array[i], array[j]) > 0)
                    {
                        string temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }


        public static int CompareStrings(string str1, string str2)
        {
            // Calcular la longitud mínima de las dos cadenas para evitar IndexOutOfRangeException
            int minLength = (str1.Length < str2.Length) ? str1.Length : str2.Length;

            // Comparar carácter por carácter hasta la longitud mínima
            for (int i = 0; i < minLength; i++)
            {
                if (str1[i] < str2[i])
                    return -1;  // str1 es menor que str2
                if (str1[i] > str2[i])
                    return 1;   // str1 es mayor que str2
            }

            // Si todos los caracteres son iguales, comparar las longitudes de las cadenas
            if (str1.Length < str2.Length)
                return -1;  // str1 es menor que str2 porque es más corto
            if (str1.Length > str2.Length)
                return 1;   // str1 es mayor que str2 porque es más largo

            return 0;  // Las cadenas son iguales
        }

        public static int FindLongestStringIndex(string[] array)
        {
        if (array == null || array.Length == 0)
            throw new ArgumentException("El array no puede ser nulo o vacío");

        int maxLength = 0;
        int maxIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length > maxLength)
            {
                maxLength = array[i].Length;
                maxIndex = i;
            }
        }

        return maxIndex;
    }

    }
}
