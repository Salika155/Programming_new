using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DominoSimulacro;

namespace DominoSimulacro
{
    public class Monto
    {
        public List<Ficha>? _fichas;

        public Monto()
        {
            _fichas = new List<Ficha>();
        }
        public Monto(List<Ficha> _Fichas)
        {
            _fichas = _Fichas;
        }  
        
        public void AddFicha(Ficha ficha)
        {
            if (ficha == null && ContainFicha(ficha))
                return;
            _fichas.Add(ficha);
        }

        public bool ContainFicha(Ficha ficha)
        {
            if (_fichas == null || ficha.GetSuma() < 0)
                return false;

            for (int i = 0; i < GetFichasCount(); i++)
            {
                var f = GetFichaAt(i);
                if (f.Equals(ficha))
                    return true;
            }
            return false;
        }

        public int IndexOfFicha(Ficha ficha)
        {
            if (ficha == null)
                return -1;

            for (int i = 0; i < GetFichasCount(); i++)
            {
                var f = GetFichaAt(i);
                if (f.Equals(ficha))
                    return i;
            }
            return -1;
        }

        public void RemoveFicha(Ficha ficha)
        {
            if (ficha == null)
                return;
            _fichas.Remove(ficha);
        }

        public void RemoveFichaAt(int index)
        {
            if (index >= 0 || index < _fichas.Count)
                _fichas.RemoveAt(index);
        }

        public Ficha? GetFichaAt(int index)
        {
            if (index < 0 && index > _fichas.Count)
                return null;
            return _fichas[index];
        }

        public int GetFichasCount()
        {
            return _fichas.Count;
        }

        public void Shuffle()
        {
            Random random = new Random();
            
            int n = _fichas.Count;
            while (n < 1000)
            {
                for (int i = n - 1; i > 0; i--)
                {
                    int j = random.Next(0, i + 1);
                    Ficha temp = _fichas[i];
                    _fichas[i] = _fichas[j];
                    _fichas[j] = temp;
                }
            }
        }
        public static Ficha? CreateFicha(int n1, int n2)
        {
            if (n1 >= 0 && n1 <= 6 && n2 >= 0 && n2 <= 6)
            {
                return new Ficha(n1, n2);
            }
            return null;
        }

        public static Ficha CreateFichas()
        {
            Monto monto = new Monto();
            for (int i = 0; i <= 6; i++)
            {
                for (int j = i; j <= 6; j++)
                {
                    monto.AddFicha(new Ficha(i, j));
                }
            }
            return null;
        }
    }
}
