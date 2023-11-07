namespace EmGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmGame gm = new EmGame();
            WarZone warZone = new WarZone(10, 10);

            //warZone.CreateWarriors(1, TeamType.DWARF);
            //warZone.CreateWarriors(1, TeamType.HUMAN);
            //warZone.CreateWarriors(1, TeamType.ORC);
            //warZone.CreateWarriors(1, TeamType.ELF);

            gm.Start(1, 1, 1, 1);

            bool gameRunning = true;
            List<TeamType> teams = new List<TeamType> { TeamType.HUMAN, TeamType.ELF, TeamType.DWARF, TeamType.ORC };
            while (gameRunning == true)
                gm.PlayTurn(warZone);




        }
    }
}