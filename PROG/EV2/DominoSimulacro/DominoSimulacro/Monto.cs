using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoSimulacro
{
    public class Monto
    {
        public List<Ficha>? _fichas;

        public Monto()
        {
            _fichas = new List<Ficha>();
        }  
        
        public void AddFicha(Ficha ficha)
        {
            if (_fichas == null)
                return;
            _fichas.Add(ficha);
        }

        public Ficha? GetFichaAt(int index)
        {
            if (index < 0 || index > _fichas.Count)
                return null;
            return _fichas[index];
        }

        public void RemoveFichaAt(int index)
        {
            if (index < 0 || index > _fichas.Count)
                return;
            _fichas.RemoveAt(index);
        }

        public int GetFichasCount()
        {
            if (_fichas == null)
                return 0;
            return _fichas.Count;
        }

    }
}
