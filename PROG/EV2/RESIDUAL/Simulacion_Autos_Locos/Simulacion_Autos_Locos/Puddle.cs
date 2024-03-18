using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Autos_Locos
{
    public class Puddle : Obstacle
    {
        public Puddle(int position) : base("El Charco", position)
        {

        }

        public override void Simulate(IRace race)
        {
            double puddlePosition = Position;

            for (int i = 0; i < race.GetObjectsCount(); i++)
            {
                RaceObject raceObject = race.GetObjectAt(i);

                double distance = Utils.CalculateDistance(puddlePosition, raceObject.Position);

                if (distance < 20) 
                { 
                    double disableProbability = 0.2;
                    if (Utils.Probability(disableProbability))
                    {
                        int disableTurns = Utils.GetRandomInt(0, 3);
                        raceObject.Disable(disableTurns);
                    }
                }
            }
        }
    }
}
