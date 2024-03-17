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
        public Bomb(int turns, double position) : base("Bob-ombs", position)
        {
            _turnsToExplosion = turns;
        }

        public override void Simulate(IRace race)
        {
            if (_turnsToExplosion == 0)
            {
                
            }

        }
    }
    
    
}
