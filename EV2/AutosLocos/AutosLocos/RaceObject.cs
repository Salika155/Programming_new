using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocos
{
    public enum ObjectType 
    {
        Obstacle,
        Rock,
        Charco,
        Bomb
    }

    public abstract class RaceObject
    {
        private string _name;
        private double _position;
        private ObjectType _type;

        public RaceObject(string name, double position)
        {
            _name = name;
            _position = position;
            _type = ObjectType.Obstacle;
        }
        public string Name { get => _name; }
        public double Position { get => _position; }
        public ObjectType Type => _type;

        public abstract ObjectType GetObjectType();

        

        public abstract bool IsEnable();

        public void Disable(int turnos)
        {
            
        }

        public abstract void Simulate(IRace race);
        

        
    }
}
