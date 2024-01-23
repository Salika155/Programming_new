namespace DiccionarioApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();

            d.Filter(

                (key, value) =>
                {
                    return key.Contains("a") || key.Contains("A");
                }

                //(key, value)=>  key.Contains("a") || key.Contains("A");

            



            );
        }
    }
}