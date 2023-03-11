using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoDragonBall
{
    public abstract class Persona
    {
        private string _nombre;
        private Raza _raza;
        private double _energia;
        private double _deseoEsquivar;
       

        public Persona (string nombre, Raza raza, double energia, double deseoEsquivar)
        {
            this._nombre = nombre;
            this._raza = raza;
            Random random= new Random();
            this._energia = random.Next(1000, 2000);
            this._deseoEsquivar = random.NextDouble() * (0.9 - 0.1) + 0.1;
        }

      
        protected Persona(string nombre, Raza raza)
        {
            this._nombre = nombre;
            this._raza = raza;
        }

        public string Nombre => _nombre;
        public Raza Raza => _raza;
        public double Energia => _energia;
        public double DeseoEsquivar => _deseoEsquivar;


        public virtual void QuitarEnergia(double cantidad)
        {
            _energia -= cantidad;
            if (_energia < 0) 
            {
                _energia= 0;
            }
        }

        public abstract void Atacar(Persona persona);

        public abstract double CapacidadDeEsquiva();

        public abstract double CapacidadDeParada();

        public bool QuiereEsquivar()
        {
            if (Utils.GetRandom(0, 1) > _deseoEsquivar)
                return false;
            return true;
        }
    }

   
}
