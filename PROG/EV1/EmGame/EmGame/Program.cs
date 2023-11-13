namespace EmGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmGame gm = new EmGame();
            WarZone warZone = new WarZone(16, 16);
           

            //warZone.CreateWarriors(1, TeamType.DWARF);
            //warZone.CreateWarriors(1, TeamType.HUMAN);
            //warZone.CreateWarriors(1, TeamType.ORC);
            //warZone.CreateWarriors(1, TeamType.ELF);

            gm.Start(4, 1, 1, 1);
 
            for (int i = 0; i < 5; i++)
            {

                //int x = UtilsEmGame.GetRandom(1, warZone.GetWith() + 1);
                //int y = UtilsEmGame.GetRandom(1, warZone.GetHeight() + 1);
                new Warrior(12, 5, 5, 5.0, 5, TeamType.HUMAN);
                warZone.CreateWarriors(5, TeamType.HUMAN);

            }
            warZone.PaintWarZone();

            bool gameRunning = true;
            List<TeamType> teams = new List<TeamType> { TeamType.HUMAN, TeamType.ELF, TeamType.DWARF, TeamType.ORC };
            while (gameRunning == true)
                gm.PlayTurn(warZone);
        }
    }
}