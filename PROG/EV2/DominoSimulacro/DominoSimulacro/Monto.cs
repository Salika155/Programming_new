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
        private List<Ficha>? _monto;
        public int montoCount { get { return _monto.Count; } }

        public Monto()
        {
            _monto = new List<Ficha>();
        }
        public Monto(List<Ficha> _Fichas)
        {
            _monto = _Fichas;
        }

        //crea el monto de fichas para iniciar el juego
        public void CreateMonto()
        {
            Monto monto = new Monto();
            for (int i = 0; i <= 6; i++)
            {
                for (int j = 0; j <= 6; j++)
                {
                    monto.AddFicha();
                }
            }
        }

        //baraja las fichas en el tablero
        public void Shuffle()
        {
            Random random = new Random();

            int n = _monto.Count;
            while (n < 1000)
            {
                for (int i = n - 1; i > 0; i--)
                {
                    int j = random.Next(0, i + 1);
                    Ficha temp = _monto[i];
                    _monto[i] = _monto[j];
                    _monto[j] = temp;
                }
            }
        }

        //añade una ficha al monto, para añadir las fichas del 0:0 al 6:6
        public void AddFicha()
        {
            for (int i = 0; i <= 6; i++)
            {
                for (int j = i; j <= 6; j++)
                {
                    Ficha? ficha = CreateFicha(i, j);
                    if (ficha != null && !ContainFicha(ficha))
                        _monto.Add(ficha);
                }
            }
        }

        //comprueba que la ficha exista en el monto para no añadir repes
        public bool ContainFicha(Ficha ficha)
        {
            if (_monto == null || ficha.GetSuma() < 0)
                return false;

            for (int i = 0; i < GetFichasCount(); i++)
            {
                var f = GetFichaAt(i);
                if (f.Equals(ficha))
                    return true;
            }
            return false;
        }

        //comprueba si la ficha esta en el monto
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

        //quita una ficha del monto
        public void RemoveFicha(Ficha ficha)
        {
            if (ficha == null)
                return;
            _monto.Remove(ficha);
        }

        //quita una ficha del monto por su index
        public void RemoveFichaAt(int index)
        {
            if (index >= 0 || index < _monto.Count)
                _monto.RemoveAt(index);
        }

        //elige una ficha del monto
        public Ficha? GetFichaAt(int index)
        {
            if (index < 0 && index > _monto.Count)
                return null;
            return _monto[index];
        }

        //cuenta el numero de fichas en el monto
        public int GetFichasCount()
        {
            return _monto.Count;
        }

        //crea una ficha para añadirla al monto
        public static Ficha? CreateFicha(int n1, int n2)
        {
            if (n1 >= 0 && n1 <= 6 && n2 >= 0 && n2 <= 6)
            {
                return new Ficha(n1, n2);
            }
            return null;
        }
    }
}
