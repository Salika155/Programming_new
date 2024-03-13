using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoSimulacro
{
    public class Impulsivo : Participante
    {
        public Impulsivo() : base()
        {
            _nombre = "Impulsivo";
        }


        //public void Jugar()
        //{
        //    int max = 0;
        //    int index = 0;
        //    for (int i = 0; i < _fichas.Count; i++)
        //    {
        //        if (_fichas[i].N1 + _fichas[i].N2 > max)
        //        {
        //            max = _fichas[i].N1 + _fichas[i].N2;
        //            index = i;
        //        }
        //    }
        //    _fichas.RemoveAt(index);
        //}
    }
}
