namespace Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Race race = new Race();

            game.Simulate(race);

            
            //Console.WriteLine($"El equipo ganador es: {winningTeam}");

        }
    }
}