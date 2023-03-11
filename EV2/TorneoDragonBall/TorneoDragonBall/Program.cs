namespace TorneoDragonBall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo t = new Torneo("Copa Celula", true);
            var v = t.Execute();
            for (int i = 0; i < v.Count; i++)
            {
                Console.WriteLine(v[i]);
            }
        }
    }
}