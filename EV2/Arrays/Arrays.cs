using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Arrays
    {

        //funcion sort
        public static void Sort<T>(T[] array, Comparison<T> comparison = null)
        {
            if (comparison == null)
            {
                comparison = Comparer<T>.Default.Compare;
            }
            Array.Sort(array, comparison);
        }


        //funcion indexof
        public static int IndexOf<T>(T[] array, T value)
        {
            return Array.IndexOf(array, value);
        }

        //funcion binary search

        public static int BinarySearch<T>(T[] array, T value, IComparer<T> comparer = null)
        {
            if (comparer == null)
            {
                comparer = Comparer<T>.Default;
            }
            return Array.BinarySearch(array, value, comparer);
        }

        //funcion rotate left/right 

        public static void RotateLeft<T>(T[] array, int count)
        {
            if (array == null || array.Length == 0 || count == 0)
            {
                return;
            }
            count = count % array.Length;
            T[] temp = new T[count];
            Array.Copy(array, temp, count);
            Array.Copy(array, count, array, 0, array.Length - count);
            Array.Copy(temp, array, count);
        }

        public static void RotateRight<T>(T[] array, int count)
        {
            if (array == null || array.Length == 0 || count == 0)
            {
                return;
            }
            count = count % array.Length;
            T[] temp = new T[count];
            Array.Copy(array, array.Length - count, temp, 0, count);
            Array.Copy(array, 0, array, count, array.Length - count);
            Array.Copy(temp, 0, array, 0, count);
        }

        //funcion add

        public static T[] Add<T>(T[] array, T value)
        {
            if (array == null)
            {
                return new T[] { value };
            }
            T[] newArray = new T[array.Length + 1];
            Array.Copy(array, newArray, array.Length);
            newArray[newArray.Length - 1] = value;
            return newArray;
        }

        //funcion remove

        public static T[] Remove<T>(T[] array, T value)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }
            int index = Array.IndexOf(array, value);
            if (index == -1)
            {
                return array;
            }
            T[] newArray = new T[array.Length - 1];
            Array.Copy(array, 0, newArray, 0, index);
            Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);
            return newArray;
        }


        //funcion remove at

        public static T[] RemoveAt<T>(T[] array, int index)
        {
            if (array == null || array.Length == 0 || index < 0 || index >= array.Length)
            {
                return array;
            }
            T[] newArray = new T[array.Length - 1];
            Array.Copy(array, 0, newArray, 0, index);
            Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);
            return newArray;
        }
    }
}
