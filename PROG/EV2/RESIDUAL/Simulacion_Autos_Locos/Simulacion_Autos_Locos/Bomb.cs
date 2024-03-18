using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Autos_Locos
{
    public class Bomb : Obstacle
    {
        private int _turnsToExplosion;
        private bool _exploded = false;

        public Bomb(int turns, double position) : base("Bob-ombs", position)
        {
            _turnsToExplosion = turns;
        }

        public override void Simulate(IRace race)
        {
            if (_turnsToExplosion == 0)
            {
                Explode(race);
            }
            else
            {
                _turnsToExplosion--;
            }
        }

        private void Explode(IRace race) 
        {
            double bombPosition = this.Position;

            foreach (var racer in race.GetRacers())
            {
                double distance = Utils.CalculateDistance(bombPosition, racer.Position);
                if (distance < 20)
                {
                    double displacement = Utils.GetRandomInt(-50, 50);
                    racer.Position += displacement;
                    racer.Disable(3);
                }
            }
            _exploded = true;
        }
    }
}
