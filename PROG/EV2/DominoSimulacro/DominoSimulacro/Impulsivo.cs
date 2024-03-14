using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoSimulacro
{
    public class Impulsivo : Participante
    {
        public Impulsivo()
        {
        }

        public Impulsivo(List<Ficha> fichas) : base(fichas)
        {
            _nombre = "Impulsivo";
        }

        //juhador impulsivo juega la primera ficha que pueda
        //seria hacer un metodo para jugar la ficha tras haberlas ordenado y la primera que salga jugar
        //si existen fichas dobles se jugaran primero
        
    }
}
