using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public class Defense : Player
    {
        private double _habilidadDeRobarPelota;

        public Defense(string name, Team team, Position position, double habilidadDeRobarPelota) : base(name, team, position)
        {
            _habilidadDeRobarPelota = habilidadDeRobarPelota;
            if (_habilidadDeRobarPelota < 0.4)
                _habilidadDeRobarPelota = 0.4;
            
            
        }

        

        //public Defense(string name, Team team, int initialX, int initialY) : this(name, team, initialX, initialY)
        //{
        //}

        public override void ExecuteTurn(IBoardGame boardGame)
        {
            bool tengoPelota = TengoLaPelota(boardGame);
            if (tengoPelota)
            {
                var dados = Utils.GetRandomReal(0, 1);
                if (dados < 0.6)
                {
                    Avanzar(boardGame);
                }
                else
                {
                    PasarPelota(boardGame);
                }
            }
            else
            {
                var pelota = boardGame.GetBall();
                bool pelotaAlcance = Utils.EstaAlAlcanceDelJugador(this, boardGame);
                bool pelotaSinDueño = pelota.PlayerThatHaveTheBall == null;
                if (pelotaAlcance)
                {
                   if (pelotaSinDueño)
                   {
                        pelota.PlayerThatHaveTheBall = this;
                   }
                   else
                   {
                        if (dados < _habilidadDeRobarPelota && pelota.PlayerThatHaveTheBall.Team != Team)
                            pelota.PlayerThatHaveTheBall = this;
                   }
                }
                else
                {
                    var dados = Utils.GetRandomReal(0, 1);
                    if(dados < 0.5)
                    {
                        IrAPorAlguienDelEquipoContrario();
                    }
                    else
                    {
                        IrAPorLaPelota(boardGame);
                    }
                    
                }
            }
        }

        private void IrAPorLaPelota(IBoardGame boardGame)
        {
            var pelota = boardGame.GetBall();
            //if (pelota.Position.x > Position.x)
            //{
            //    Position.x++;
            //}
            //if(pelota.Position.x < Position.x)
            //{
            //    Position.x--;
            //}
            var lista = Utils.GetPosicionADistancia(Position, 1);
            lista = Utils.Filtrar(lista, boardGame);
            lista.Sort((a, b) =>
            {     
                if (a.GetDistance(pelota.Position) > b.GetDistance(pelota.Position))
                    return -1;
                if (b.GetDistance(pelota.Position) < a.GetDistance(pelota.Position))
                    return 1;
                return 0;
            });
            if (lista.Count > 0)
            {
                Position.x = lista[0].x;
                Position.y = lista[0].y;
            }
            

        }

        private void IrAPorAlguienDelEquipoContrario()
        {
            throw new NotImplementedException();
        }

        private void EjecutarTurnoSinPelota(IBoardGame boardGame)
        {
            throw new NotImplementedException();
        }

        private void Avanzar(IBoardGame boardGame)
        {
            throw new NotImplementedException();
        }

        private void PasarPelota(IBoardGame boardGame)
        {
            throw new NotImplementedException();
        }
    }
}
