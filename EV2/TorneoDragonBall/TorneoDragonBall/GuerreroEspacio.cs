using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoDragonBall
{
    internal class GuerreroEspacio : Persona
    {
        private double _ataqueRayo;
        private double _ataqueGolpes;
        private double _capacidadEsquivar;
        private double _capacidadParar;
        private double _energia;

        public GuerreroEspacio(string nombre, Raza superSaijayin) : base(nombre, Raza.GuerreroEspacio, 
            Utils.GetRandom(1000, 2000), Utils.GetRandom(0.1, 0.9))

        {
            _ataqueRayo = Utils.GetRandom(0.3, 0.6);
            _ataqueGolpes = Utils.GetRandom(0.1, 0.8);
            _capacidadEsquivar = Utils.GetRandom(0.2, 0.4);
            _capacidadParar = Utils.GetRandom(0.4, 0.9);        
        }

        protected GuerreroEspacio(string nombre, Raza raza) : base(nombre, raza)
        {
            _ataqueRayo = Utils.GetRandom(0.3, 0.6);
            _ataqueGolpes = Utils.GetRandom(0.1, 0.8);
            _capacidadEsquivar = Utils.GetRandom(0.2, 0.4);
            _capacidadParar = Utils.GetRandom(0.4, 0.9);
        }

        public double AtaqueRayo { get { return _ataqueRayo;} }
        public double BaqueGolpes { get { return _ataqueGolpes; } }
        public double CapacidadEsquivar { get { return _capacidadEsquivar; } }
        public double CapacidadParar { get { return _capacidadParar;} }


        public override void QuitarEnergia(double cantidad)
        {
            _energia -= cantidad;
            if (_energia < 0.0)
            { 
                _energia = 0.0; 
            }
        }
        public override double CapacidadDeEsquiva()
        {
            return _capacidadEsquivar;
        }

        public override double CapacidadDeParada()
        {
            return _capacidadParar;
        }

        
        public override void Atacar(Persona persona)
        {
            
            double EnergiaInicial = persona.Energia;
            persona.QuitarEnergia(1);

            if (persona.QuiereEsquivar() && persona.CapacidadDeEsquiva() > new Random().NextDouble())
            {
                return;
            }
            else if 
                (persona.CapacidadDeParada() > new Random().NextDouble())
            {
                persona.QuitarEnergia(25);
            }
            else
            {
                persona.QuitarEnergia(300);
            }

            
        }
    }
}
