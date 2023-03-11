using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraExamen
{

    public enum carreraType
    {
        Mario,
        Luigi,
        Wario,
        Waluigi
    }
    public abstract class Carrera
    {
        private string _nombre;
        private double _position = 0.0;
        private carreraType _type;

        public string Nombre => _nombre;
        public double Position => _position;
        public carreraType Type => _type;

        public abstract double Velocidad();

        public bool Concentrado()
        {
            int avanza = (int)Utils.GetRandom(0, 1);
            if (avanza > 0)
                return true;
            return false;
        }
    }
}
