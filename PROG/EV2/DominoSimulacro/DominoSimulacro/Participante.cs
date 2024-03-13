using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoSimulacro
{
    public abstract class Participante
    {
        public List<Ficha>? _fichas;
        public int _puntos;
        public string _nombre;

        public Participante()
        {
            _fichas = new List<Ficha>();
            _puntos = 0;
        }

        public Participante(List<Ficha> fichas)
        {
            _fichas = fichas;
            _puntos = 0;
        }

        public void AddFicha(Ficha ficha)
        {
            if (ficha == null && ContainFicha(ficha))
                return;
            _fichas.Add(ficha);
        }

        private bool ContainFicha(Ficha? ficha)
        {
            return _fichas.Contains(ficha);
        }

        public int GetFichasCount()
        {
            return _fichas.Count;
        }

        public Ficha GetFichaAt(int index)
        {
            return _fichas[index];
        }

        public void RemoveFicha(Ficha ficha)
        {
            if (ficha == null)
                return;
            _fichas.Remove(ficha);
        }

        public void AddPuntos(int puntos)
        {
            _puntos += puntos;
        }

        public int GetPuntos()
        {
            return _puntos;
        }

        public void PlayFicha(Ficha ficha)
        {
            if (ficha == null)
                return;
        }

        internal void Jugar()
        {
            throw new NotImplementedException();
        }

        internal string GetNombre()
        {
            return _nombre;
        }
    }
}
