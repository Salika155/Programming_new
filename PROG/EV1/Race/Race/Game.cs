using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Race
{
    public class Game
    {
        
        Race race = new Race();

        public void Simulate(Race race)
        {

            int count = 2;

            for (int i = 0; i < count; i++)
            {
                race.CreateRunners(count, teamType.A);
                race.CreateRunners(count, teamType.B);
                race.CreateRunners(count, teamType.C);
                race.CreateRunners(count, teamType.D);
            }
        }

        public teamType GetWinner()
        {
            for (int i = 0; i < race.GetRunner().Count; i++)
            {
                var runner = race.GetRunner()[i];
                if (runner.GetPosition() >= race.GetMeta())
                {
                    // Corredor ha superado o igualado la meta, y también revisamos su equipo
                    if (race.AllRunnersInTeamHaveFinished(runner.GetTeam()))
                    {
                        return runner.GetTeam();
                    }
                }
            }

            return teamType.WINNER; // Ningún equipo ha tenido a todos sus corredores cruzando la meta

        }

        public void ExecuteTurn(Race race)
        {
            double x = Utils.GetRandomDouble(1, race.GetMeta() + 1);
            race.MoveRunner((int)x);

        }
    }
}
