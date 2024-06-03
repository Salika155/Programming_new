

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pruebas de los métodos
            int[] numbers = { 1, 5, 3, 8, 2 };
            double[] doubles = { 1.5, 2.5, 3.5, 2.5 };
            string[] strings = { "banana", "apple", "orange", "grape" };

            Console.WriteLine("Valor más alto en el array de enteros: " + ArrayUtils.FindMaxValorInArray(numbers));

            Console.WriteLine("Array de doubles después de eliminar 2.5:");
            foreach (double d in ArrayUtils.RemoveAllOccurrences(doubles, 2.5))
                Console.Write(d + " ");
            Console.WriteLine();

            Console.WriteLine("Array de strings ordenado:");
            foreach (string s in ArrayUtils.SortStrings(strings))
                Console.Write(s + " ");
            Console.WriteLine();

            Console.WriteLine("Posición del string con longitud más grande: " + ArrayUtils.FindLongestStringIndex(strings));
        }
    }
}
