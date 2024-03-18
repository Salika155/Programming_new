using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Autos_Locos
{
    public enum ObjectType
    {
        Driver,
        Car,
        Obstacle
    }

    public abstract class RaceObject
    {
        private string _name;
        private double _position;
        //private bool _isAlive;
        private bool _isAlive;

        protected int _turnsDisabled;

        public string Name
        {
            get => _name;  
        }

        public double Position
        { 
            get => _position; 
            set => _position = value;
        } 

        //al tener la propiedad abstracta, las clases que hereden de esta clase
        //deberan implementar el metodo
        //esta clase debe quedar abstracta tambien
        public abstract bool IsAlive { get; }

        public RaceObject(string name, double position)
        {
            _name = name;
            _position = position;
            _isAlive = true;
            _turnsDisabled = 0;
            //aqui tengo que tomar decision de si activarlo o no
            //y los turnos que pasaria desactivado
        }

        public abstract ObjectType GetObjectType();

        public abstract bool IsEnabled();
        
        //decisiones objetos carrera
        //cada objeto tomara su decision
        public abstract void Simulate(IRace race);

        //para desactivar el objeto de carrera
        public void Disable(int turns)
        {
            if (turns > 0)
                _turnsDisabled += turns;
            return;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
