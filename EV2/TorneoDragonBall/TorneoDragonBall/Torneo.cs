using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoDragonBall
{
    public class Torneo : ITorneo
    {

        string nombre;
        private List<Persona> participantes = new List<Persona>();
        public void Init()
        {
            for (int i = 0; i < 16; i++)
            {
                Random random = new Random();
                switch (random.Next(0, 3))
                {
                    case 0:
                        participantes.Add(new Humano(i.ToString()));
                        break;
                    case 1:
                        participantes.Add(new GuerreroEspacio(i.ToString()));
                        break;
                    case 2:
                        participantes.Add(new SuperSaiyajin(i.ToString()));
                        break;
                    case 3:
                        participantes.Add(new Namekiano(i.ToString()));
                        break;
                }      
                
            }
        }

        public List<string> Execute()
        {
            List<string> result = new List<string>();

            while (participantes.Count > 1)
            {
                List<string> result;
            }
        }

        public delegate void TorneoDelegado(Persona persona );
    }

    internal class Namekiano : Persona
    {
        private string v;

        public Namekiano(string v)
        {
            this.v = v;
        }
    }
}
