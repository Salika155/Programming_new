using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoDragonBall
{
    public class Humano : Persona 
    {
        private double _ataqueGolpes;
        private double _capacidadEsquivar;
        private double _capacidadParar;
        private double _energia;

        public Humano(string nombre) : base(nombre, Raza.Humano, 
            Utils.GetRandom(1000, 2000), Utils.GetRandom(0.1, 0.9))
        {
            _ataqueGolpes = Utils.GetRandom(0.1, 0.8);
            _capacidadEsquivar = Utils.GetRandom(0.4, 0.6);
            _capacidadParar = Utils.GetRandom(0.7, 0.9);
            _energia = Utils.GetRandom(1000, 2000);
        }



        public double AtaqueGolpes { get { return _ataqueGolpes; } }
        public double CapacidadEsquivar { get { return _capacidadEsquivar; } }
        public double CapacidadParar { get { return _capacidadParar; } }

        public override void QuitarEnergia(double cantidad)
        {
            _energia -= cantidad;
            if (_energia < 0.0)
            {
                _energia = 0.0;
            }
        }

        public override void Atacar(Persona persona)
        {
            double EnergiaInicial = persona.Energia;
            persona.QuitarEnergia(1);

            if (persona.QuiereEsquivar() && persona.CapacidadDeEsquiva() > new Random().NextDouble())
            {
                return;
            }
            else if (persona.CapacidadDeParada() > new Random().NextDouble())
            {
                persona.QuitarEnergia(0.5);
            }
            else
            {
                persona.QuitarEnergia(3);
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
    }

}
