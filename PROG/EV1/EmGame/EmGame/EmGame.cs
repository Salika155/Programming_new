using System;
using System.Reflection;

namespace EmGame
{
    public class EmGame
    {
        List<Warrior> warriors = new List<Warrior>();
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

        //decidir que equipo ha ganado la partida
        public TeamType GetWinner()
        {
            if (warriors.Count == 1)
            {
                warriors[0].SetTeamType(TeamType.WINNER);
                return TeamType.WINNER;
            }

            Warrior? winningWarrior = GetWinningWarrior();

            if (winningWarrior != null)
            {
                winningWarrior.SetTeamType(TeamType.WINNER);
                return winningWarrior.GetTeamType();
            }

            return TeamType.UNKNOWN;
        }


        private Warrior? GetWinningWarrior()
        {
            Warrior? winningWarrior = null;

            for (int i = 0; i < warriors.Count; i++)
            {
                Warrior currentWarrior = warriors[i];

                if ((winningWarrior == null) || (currentWarrior.GetLife() > winningWarrior.GetLife()))
                {
                    winningWarrior = currentWarrior;
                }
            }
            return winningWarrior;
        }


        //como decir a los guerreros te toca el turno de jugar

        public void PlayTurn(WarZone warZone)
        {
            int count = warriors.Count;

            for (int i = 0; i < count; i++)
            {
                Warrior warrior = warriors[i];
                warrior.ExecuteTurn(warZone);
            }
        }
    }
}
