using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocos
{
    public enum CarType
    {
        GlamourCar,
        PiereCar,
        TroglodtyteCar,
        WoodCar
    }

    public abstract class Car : RaceObject
    {
        private string _name;
        protected double _finetunning;
        private CarType _type;
        private double _velocity;
        private double ritmo;

        public Car(string name, double finetunning, double velocity, CarType type) : base(name, 0)
        {
            Random random = new Random();
            _name = name;
            _finetunning = random.Next(1, 3);
            _velocity = (Velocity + finetunning);
            _type = type;
        }
        //public Car(string name, double finetunning, double velocity, CarType type)
        //{
        //    Random random = new Random();
        //    _name = name;
        //    _finetunning = random.Next(1, 3);
        //    _velocity = (Velocity + finetunning);
        //    _type = type;
        //}

        public Car(string name, double position, double ritmo) : base(name, position)
        {
            this.ritmo = ritmo;
        }

        public Car(string name, double position, CarType type) : base(name, position)
        {
            Type1 = type;
        }

        /*public Car()
        {
            Type type = typeof(Car);
        }*/

        public string Name { get { return _name; } }
        public CarType Type { get { return _type; } }

        public double FineTunning { get { return _finetunning; } }
        public double Velocity { get { return _velocity; } }

        public CarType Type1 { get; }
    }
}
