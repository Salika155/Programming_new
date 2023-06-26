namespace Arrays
{
    internal class Program
    {
        Index Index = new Index();
        public static void Main()
        {

            int[] array = { 1, 2, 3, 5, 8, 10 };
            for (int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine(array[i]);
            }
            
        }
    }
}
        