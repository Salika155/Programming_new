using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public class Impulsivo : Participante
    {
        private Action? _tirarFichasDobles;

        public Action? TirarFichasDobles { get; set; }

       
    }
}
