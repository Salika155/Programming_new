using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public class Conservador : Participante
    {
        private Action? _tiraFichasAltas;


        public Action? _tirarFichasAltas { get;  set; }
    }
}
