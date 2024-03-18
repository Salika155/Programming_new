using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Autos_Locos
{
    public class Rock : Obstacle
    {
        private double _weight;

        //constructor de la clase Rock
        //le paso el nombre y la posicion
        //dentro solo llamo al valor weight que se calculara aqui
        public Rock(int position) : base("Roca Picuda", position)
        {
            _weight = Utils.GetRandomDouble(10, 30);
        }

        //simulacion de lo que hace la roca
        public override void Simulate(IRace race)
        {
            double rockPosition = Position;
            List<RaceObject> _racers = race.GetRacers();

            foreach (RaceObject raceObject1 in race.GetRacers()) 
            {
                double distance = Utils.CalculateDistance(rockPosition, raceObject1.Position);

                if (distance < 40)
                {
                    double delayProbability = 0.1 + (_weight / 100);
                    if (Utils.Probability(delayProbability))
                    {
                        raceObject1.Position -= 25;
                    }
                }
                //TODO: implementar el comportamiento de la roca
            }


        }
    }
}
