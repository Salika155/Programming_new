namespace Arrays
{
    internal class Program
    {
        Index Index = new Index();
        public static void Main()
        {
            // Ejemplo de uso de la función Sort
            //int[] array = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
            //ArrayHelper.Sort(array);
            //Console.WriteLine(string.Join(", ", array)); // Resultado esperado: 1, 1, 2, 3, 3, 4, 5, 5, 5, 6, 9

            // Ejemplo de uso de la función IndexOf
            //int index = ArrayHelper.IndexOf(array, 4);
            //Console.WriteLine(index); // Resultado esperado: 5

            // Ejemplo de uso de la función BinarySearch
            //int result = ArrayHelper.BinarySearch(array, 9);
            //Console.WriteLine(result); // Resultado esperado: 10

            // Ejemplo de uso de la función RotateLeft
            //ArrayHelper.RotateLeft(array, 3);
            //Console.WriteLine(string.Join(", ", array)); // Resultado esperado: 3, 4, 1, 5, 9, 2, 6, 5, 3, 5, 1

            // Ejemplo de uso de la función Add
            //array = ArrayHelper.Add(array, 8);
            //Console.WriteLine(string.Join(", ", array)); // Resultado esperado: 3, 4, 1, 5, 9, 2, 6, 5, 3, 5, 1, 8

            //Ejemplo de uso de la función Remove
            //array = ArrayHelper.Remove(array, 5);
            //Console.WriteLine(string.Join(", ", array)); // Resultado esperado: 3, 4, 1, 9, 2, 6, 5, 3, 5, 1, 8

            // Ejemplo de uso de la función RemoveAt
            //array = ArrayHelper.RemoveAt(array, 2);
            //Console.WriteLine(string.Join(", ", array)); // Resultado esperado: 3, 4, 9, 2, 6, 5, 3, 5, 1, 8

            // Ejemplo de uso de la función RotateLeft (versión 2)
            //IEnumerable<int> collection = ArrayHelper.RotateLeft(array, 4);
            //Console.WriteLine(string.Join(", ", collection)); // Resultado esperado: 6, 5, 3, 5, 1, 8, 3, 4, 9, 2

        }

        public static class ArrayExtensions
        {
            public static void Sort<T>(T[] array, Comparison<T> comparison)
            {
                Array.Sort(array, comparison);
            }

            public static int IndexOf<T>(T[] array, T item, EqualityComparer<T> comparer = null)
            {
                comparer ??= EqualityComparer<T>.Default;
                for (int i = 0; i < array.Length; i++)
                {
                    if (comparer.Equals(array[i], item))
                    {
                        return i;
                    }
                }
                return -1;
            }

            public static int BinarySearch<T>(T[] array, T item, IComparer<T> comparer = null)
            {
                comparer ??= Comparer<T>.Default;
                return Array.BinarySearch(array, item, comparer);
            }

            public static void RotateLeft<T>(T[] array, int k)
            {
                k %= array.Length;
                if (k < 0) k += array.Length;
                T[] buffer = new T[k];
                Array.Copy(array, buffer, k);
                Array.Copy(array, k, array, 0, array.Length - k);
                Array.Copy(buffer, array, k);
            }

            public static void RotateRight<T>(T[] array, int k)
            {
                RotateLeft(array, array.Length - k);
            }

            public static T[] Add<T>(T[] array, T item)
            {
                T[] result = new T[array.Length + 1];
                Array.Copy(array, result, array.Length);
                result[array.Length] = item;
                return result;
            }

            public static T[] Remove<T>(T[] array, T item, EqualityComparer<T> comparer = null)
            {
                comparer ??= EqualityComparer<T>.Default;
                int index = IndexOf(array, item, comparer);
                if (index < 0) return array;
                T[] result = new T[array.Length - 1];
                Array.Copy(array, result, index);
                Array.Copy(array, index + 1, result, index, array.Length - index - 1);
                return result;
            }

            public static T[] RemoveAt<T>(T[] array, int index)
            {
                T[] result = new T[array.Length - 1];
                Array.Copy(array, result, index);
                Array.Copy(array, index + 1, result, index, array.Length - index - 1);
                return result;
            }

            public static IEnumerable<T> RotateLeft<T>(IEnumerable<T> collection, int k)
            {
                k %= collection.Count();
                if (k < 0) k += collection.Count();
                return collection.Skip(k).Concat(collection.Take(k));
            }

            public static IEnumerable<T> RotateRight<T>(IEnumerable<T> collection, int k)
            {
                return RotateLeft(collection, collection.Count() - k);
            }


        }
    }
}
        