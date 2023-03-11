using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public enum FichaType
    {
        fichaNormal,
        fichaDoble
    }

    public class Ficha
    {
        private int _numArriba;
        private int _numAbajo;

        public Ficha(int numArriba, int numAbajo)
        {
            _numArriba = numArriba;
            _numAbajo = numAbajo;
        }

        public Ficha()
        {

        }

       //valores de ficha tienen que estar entre 0 y 6

        public bool esFichaDoble()
        {
            if (_numArriba == _numAbajo)
                return false;
            return true;
        }


    }
}
