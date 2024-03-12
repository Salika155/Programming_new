using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoSimulacro
{
    public class Participante
    {
        public List<Ficha>? _fichas;
        public int _puntos;
        public string _nombre;

        public Participante()
        {
            _fichas = new List<Ficha>();
            _puntos = 0;
        }


    }
}
