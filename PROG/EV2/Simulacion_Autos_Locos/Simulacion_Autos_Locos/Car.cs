using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Autos_Locos
{
    public class Car : RaceObject
    {
        protected double _finetunning;
        private double _velocity;
        public List<Driver> _drivers;


        protected Car(double finetunning, double velocity, List<Driver> drivers, string name) : base(name, 0)
        {
            _finetunning = finetunning;
            _velocity = velocity;
            _drivers = drivers;
        }

        public override bool IsAlive
        {
            get { return _turnsDisabled <= 0; }
        }

        public override ObjectType GetObjectType()
        {
            return ObjectType.Car;
        }

        public override bool IsEnabled()
        {
            return true;
        }

        public override void Simulate(IRace race)
        {
            if (_turnsDisabled > 0)
                Position += _velocity * _finetunning;
            else
                _turnsDisabled--;
        }
    }
}
