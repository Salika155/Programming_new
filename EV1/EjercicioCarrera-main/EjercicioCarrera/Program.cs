namespace EjercicioCarrera
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Racer winner = null;
            List<Racer> list = Race.GenerateRacers();
            while (winner == null)
            {
                Race.SimulateRace(list);
                winner = Simulation.GetWinner(list);
            }
            Console.WritteLine("And the winner is;" + winner.name);
        }
    }
}