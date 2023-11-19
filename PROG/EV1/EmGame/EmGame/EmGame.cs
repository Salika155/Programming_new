using System;
using System.Reflection;

namespace EmGame
{
    public class EmGame
    {
        public void Start(int a, int b, int c, int d, WarZone warZone)
        {

            int count = 2;

            for (int i = 0; i < count; i++)
            {
                warZone.CreateWarriors(count, TeamType.HUMAN);
                warZone.CreateWarriors(count, TeamType.DWARF);
                warZone.CreateWarriors(count, TeamType.ORC);
                warZone.CreateWarriors(count, TeamType.ELF);
            }
        }

        public TeamType GetWinner()
        {
            List <Warrior> warriors = new List <Warrior>();
            for (int i = 0; i < warriors.Count; i++)
            {
                if (warriors.Count == 1)
                {
                    warriors[0].SetTeamType(TeamType.WINNER);
                    return TeamType.WINNER;
                }
                else
                {

                }

            }
            return TeamType.WINNER;
            
        }


        //como decir a los guerreros te toca el turno de jugar

        public void PlayTurn(WarZone warZone)
        {

        }
    }
}
