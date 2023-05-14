namespace MontyHall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contest contest = new Contest();
            Console.WriteLine("Bienvenido al juego Monty Hall");
            Console.WriteLine("Elija una puerta: 1, 2 o 3");
            int doorSelected = int.Parse(Console.ReadLine());

            
            contest.ChooseDoor(doorSelected);

            
            
        }
    }
}