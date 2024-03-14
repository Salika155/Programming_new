using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoSimulacro
{
    public class Conservador : Participante
    {
        public Conservador()
        {
        }

        public Conservador(List<Ficha> fichas) : base(fichas)
        {
            _nombre = "Conservador";
        }

        //jugador conservador juega la ficha con el valor mas alto
        //seria hacer un metodo para jugar la ficha tras haberlas ordenado y la ultima que salga jugar


    }
}
