namespace DiccionarioApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();

            d.Add(1, "uno");
            d.Add(2, "dos");
            d.Add(3, "tres");

            //var filteredDictionary = d.Filter(
            //    (key, value) => key.ToString().Contains("1")
            //);

            //d.Remove(
            //    (key, value) => key.ToString().Contains("2")
            //);


            (key, value) =>
                {
                    return key.Contains("a") || key.Contains("A");
                }

                //(key, value)=>  key.Contains("a") || key.Contains("A");

            



            );
        }
    }
}