using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoSimulacro
{
    public class Juego
    {
        public List<Participante>? _participantes;
        public Monto montofichas { get; set; }
        public int numParticipantes { get; set; }

        public List<Participante> Participantes
        {
            get { return _participantes; }
            set { _participantes = value; }
        }

        public Monto Montofichas
        {
            get { return montofichas; }
            set { montofichas = value; }
        }
        public Juego(Monto monto)
        {
            _participantes = new List<Participante>();
            montofichas = monto;
        }

        public Juego()
        {
        }

        public void IniciarJuego()
        {
            montofichas = new Monto();
            //montofichas.CreateFichas();
            montofichas.Shuffle();
        }

        public void CreateParticipantes()
        {
            for (uint i = 0; i < numParticipantes; i++)
            {
                _participantes.Add(new Impulsivo());
                _participantes.Add(new Conservador());
            }
        }

        public void RepartirFichas()
        {
            for (int i = 0; i < 7; i++)
            {
                foreach (var p in _participantes)
                {
                    p.AddFicha(montofichas.GetFichaAt(0));
                    montofichas.RemoveFicha(montofichas.GetFichaAt(0));
                }
            }
        }

        public void Jugar()
        {
            while (montofichas.GetFichasCount() > 0)
            {
                foreach (var p in _participantes)
                {
                    p.Jugar();
                }
            }
        }

        public void MostrarGanador()
        {
            int max = 0;
            string ganador = "";
            foreach (var p in _participantes)
            {
                if (p.GetPuntos() > max)
                {
                    max = p.GetPuntos();
                    ganador = p.GetNombre();
                }
            }
            Console.WriteLine("El ganador es: " + ganador);
        }
    }


}
