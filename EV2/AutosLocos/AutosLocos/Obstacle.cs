using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocos
{
    public class Obstacle : RaceObject
    {
        private string _name;
        private double _position;
        private ObjectType _type;

        public Obstacle(string name, double position, ObjectType type) :base(name, position)
        {
            _name = name;
            _position = position;
            _type = type;
        }

       

        public string Name { get => _name; }
        public double Position { get => _position; }
        public ObjectType Type { get => _type; }

        public override ObjectType GetObjectType()
        {
            throw new NotImplementedException();
        }

        public override bool IsEnable()
        {
            throw new NotImplementedException();
        }

        public override void Simulate(IRace race)
        {
            throw new NotImplementedException();
        }
    }
}
