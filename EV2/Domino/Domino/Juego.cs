using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public abstract class Juego : IJuego
    {
        List<Participante> _participanteList;
        List<MontoFichas> _montofichasList;
        List<Ficha> _fichasJugador;


        public Juego(int participante, List<MontoFichas> montoFichasList, List<Participante> participanteList)
        {
            _montofichasList = montoFichasList;
            _participanteList = participanteList;
        }

        public Juego()
        {

        }
        public abstract void InicioJuegoNuevo();


        public abstract void EjecutarPartida();



        /*public int DrawFicha(Participante participante)
        {
            
        }*/
            
        



       /* public int JugarFicha()
        {
            
             
        }*/

        /*public bool GetWinner()
        {

           
        }*/

        public void GetIndexOfFichas()
        {

        }

        public void SwapFichas()
        {

        }

        public int DrawFicha(Participante participante)
        {
            throw new NotImplementedException();
        }
    }
}
