namespace EmGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmGame gm = new EmGame();
            WarZone warZone = new WarZone(100, 100);

            warZone.CreateWarriors(4, TeamType.DWARF);
            warZone.CreateWarriors(4, TeamType.HUMAN);
            warZone.CreateWarriors(4, TeamType.ORC);
            warZone.CreateWarriors(4, TeamType.ELF);

            gm.Start(4, 4, 4, 4);

            bool gameRunning = true;
            List<TeamType> teams = new List<TeamType> { TeamType.HUMAN, TeamType.ELF, TeamType.DWARF, TeamType.ORC };
            while (gameRunning == true)
                gm.PlayTurn(warZone, TeamType teams);




        }
    }
}