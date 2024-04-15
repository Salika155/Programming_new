namespace ExamenDomino;

class Program
{
    static void Main(string[] args)
    {
        DominoGame dominoGame = new();
        var part1 = new ConservativePart
        {
            Name = "Juan"
        };
        var part2 = new ImpulsivePart
        {
            Name = "Pedro"
        };
        var part3 = new ConservativePart
        {
            Name = "Maria"
        };
        var part4 = new ImpulsivePart
        {
            Name = "Ana"
        };
        dominoGame.AddParticipants(new List<Participant> {part1, part2, part3, part4});
        dominoGame.StartGame();
        Console.WriteLine("El ganador o la ganadora es " + dominoGame.SimulateGame()?.Name + ".");
    }
}