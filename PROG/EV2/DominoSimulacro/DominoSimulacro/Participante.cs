using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoSimulacro
{
    public abstract class Participante
    {
        protected List<Ficha>? _hand = new();
        public int _puntos;
        public string _nombre;

        public Participante()
        {
            _hand = new List<Ficha>();
            _puntos = 0;
        }

        public Participante(List<Ficha> fichas)
        {
            _hand = fichas;
            _puntos = 0;
        }

        //añade una ficha a la mano
        public virtual void AddFicha(Ficha ficha)
        {
            if (ficha == null && ContainFicha(ficha))
                return;
            _hand.Add(ficha);
        }

        //comprueba si la ficha esta en la mano
        public virtual bool ContainFicha(Ficha? ficha)
        {
            return _hand.Contains(ficha);
        }

        //cuenta el numero de fichas en la mano
        public virtual int GetFichasCount()
        {
            return _hand.Count;
        }

        //elige una ficha de la mano
        public Ficha GetFichaAt(int index)
        {
            return _hand[index];
        }

        //quita una ficha de la mano
        public virtual void RemoveFicha(Ficha ficha)
        {
            if (ficha == null)
                return;
            _hand.Remove(ficha);
        }

        //añade puntos del jugador
        public virtual void AddPuntos(int puntos)
        {
            _puntos += puntos;
        }

        //obtiene los puntos del jugador
        public virtual int GetPuntos()
        {
            return _puntos;
        }

        public virtual void PlayFicha(Ficha ficha)
        {
            if (ficha == null)
                return;
        }

        //seria para jugar el turno, la accion de poner ficha, pero no lo tengo claro
        public void Jugar()
        {
            throw new NotImplementedException();
        }

        public virtual string GetNombre()
        {
            return _nombre;
        }

        //metodo para barajar la mano, puede ser util
        public void ShuffleHand()
        {
            Random rnd = new Random();
            int n = _hand.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Ficha value = _hand[k];
                _hand[k] = _hand[n];
                _hand[n] = value;
            }
        }

        //metodo para ordenar la mano, sera util luego para el tipo de jugador
        public void OrderHand(List<Ficha> _hand)
        {
            int n = _hand.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (_hand[j].GetSuma() > _hand[j + 1].GetSuma())
                    {
                        // intercambia fichas si la suma en posición j es mayor
                        // que la suma de la ficha en posición j+1
                        Ficha temp = _hand[j];
                        _hand[j] = _hand[j + 1];
                        _hand[j + 1] = temp;
                    }
                }
            }
        }

        //public int ChooseFichaToDraw()
        //{
        //    Random rnd = new Random();
        //    return rnd.Next(0, _hand.Count);
        //}

        //algoritmo de ordenacion en los jugadores pasandole una lambda ya que el swap y sort
        //va a ser igual en los dos jugadores, excepto en el tipo de ordenacion
    }
}
