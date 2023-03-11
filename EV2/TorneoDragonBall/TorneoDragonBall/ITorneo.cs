using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneoDragonBall
{
    public enum Raza
    {
        Persona,
        Humano,
        GuerreroEspacio,
        SuperSaijayin,
        Namekiano
    }



    internal interface ITorneo
    {
        void Init();
        
        List<string> Execute();
        void Visit(Torneo.TorneoDelegado delegado);
    }
}
