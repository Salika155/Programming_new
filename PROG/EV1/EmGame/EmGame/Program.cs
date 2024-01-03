namespace EmGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmGame emGame = new EmGame();
            WarZone warZone = new WarZone(16, 16);


            //warZone.CreateWarriors(1, TeamType.DWARF);
            //warZone.CreateWarriors(1, TeamType.HUMAN);
            //warZone.CreateWarriors(1, TeamType.ORC);
            //warZone.CreateWarriors(1, TeamType.ELF);


            emGame.Start(0, 0, 0, 0, warZone);
            //for (int i = 0; i < 4; i++)
            //{
            //    warZone.CreateWarriors(1, TeamType.HUMAN);
            //    warZone.CreateWarriors(0, TeamType.DWARF);
            //    warZone.CreateWarriors(1, TeamType.ORC);
            //    warZone.CreateWarriors(0, TeamType.ELF);

            //}
            warZone.PaintWarZone();

            //bool gameRunning = true;
            //List<TeamType> teams = new List<TeamType> { TeamType.HUMAN, TeamType.ELF, TeamType.DWARF, TeamType.ORC };
            //while (gameRunning == true)
            //    gm.PlayTurn(warZone);

            EmGame.GetWinner();
        }
    }
}