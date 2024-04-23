using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public class Utils
    {
        private static Random r = new();

        //GENERAR ARRAY O LISTA DE TODAS LAS CASILLAS DONDE PUEDO CAER
        //CON UN NUMERO RANDOM ELIJO UNO DE ELLOS, Y ESO ES LO QUE DEVUELVO

        public static List<Position> GetPosicionADistancia(Position centro, int distancia)
        {
            //mayusc tabulador
            List<Position> ret = new List<Position>();
            {
                //{
                //    int y = centro.y + distancia;
                //    for (int x = centro.x - distancia; x <= centro.x + distancia; x++)
                //        ret.Add(new Position(x, centro.y - distancia));
                //}

                //{
                //    int x = centro.x - distancia;
                //    for (int y = centro.y - (distancia - 1); y <= centro.y + (distancia - 1); y++)
                //        ret.Add(new Position(y, centro.x - distancia));
                //}
                //{
                //    int y = centro.y - distancia;
                //    for (int x = centro.x - distancia; x <= centro.x + distancia; x++)
                //        ret.Add(new Position(x, centro.y - distancia));
                //}

                //{
                //    int x = centro.x + distancia;
                //    for (int y = centro.y - (distancia - 1); y <= centro.y + (distancia - 1); y++)
                //        ret.Add(new Position(y, centro.x - distancia));
                //}

                int x0 = centro.x - distancia;
                int y0 = centro.y - distancia;
                int x1 = centro.x + distancia;
                int y1 = centro.y - distancia;
                int x2 = centro.x + distancia;
                int y2 = centro.y + distancia;
                int x3 = centro.x - distancia;
                int y3 = centro.y + distancia;
                for (int i = 0; i < distancia * 2; i++, x0++, y1++, x2--, y3--)
                {
                    ret.Add(new Position());
                    ret.Add(new Position());
                    ret.Add(new Position());
                    ret.Add(new Position());
                    ret.Add(new Position());
                    ret.Add(new Position());
                    ret.Add(new Position());
                    ret.Add(new Position());

                }
            }
            
            return ret;
        }

        public static List<Position> Filtrar(List<Position> posiciones, IBoardGame board)
        {
            List<Position> ret = new List<Position>();
            foreach (var coord in posiciones)
            {
                var pj = board.GetCharacterAt(coord);
                if (pj is Player jugador)
                    ret.Add(coord);
            }
            
            return ret;
        }
            
        

        public static (int X, int Y) GetPosicionA2CasillasDeDistanciaVersionAngel()
        {
            var position = GetPosicionA2CasillasDeDistancia();
            return (position.x, position.y);
        }

        private static object GetPosicionA2CasillasDeDistancia()
        {
            throw new NotImplementedException();
        }

        public static int GetRandom(int min, int max)
        {
            return r.Next(min, max);
        }

        public static bool IsInRange(int x, int y, int x2, int y2, int range)
        {
            return Math.Abs(x - x2) <= range && Math.Abs(y - y2) <= range;
        }

        public static void ConfigurarDefensa(Player player, int index)
        {
            var dir = player.Team.TeamType;
            int y = 0;

            if (dir == TeamType.Blue)
            {
                y = 19;
            }
            
            if (index == 0)
            {
                player.Position.x = 0;
                player.Position.y = 0;
            }  
        }

        internal static double GetRandomReal(int v1, int v2)
        {
            return 0.5;
        }

        public static bool EstaAlAlcanceDelJugador(Player player, IBoardGame boardGame)
        {
            var casillas = GetPosicionADistancia(player.Position, 1);
            var casillasFiltradas = Filtrar(casillas, boardGame);
            var posicionPelota = boardGame.GetBall().Position;
            foreach (var casilla in casillasFiltradas)
            {
                //if (casilla.x == posicionPelota.x && casilla.y == posicionPelota.y)
                //    return true;
                //return false;
                if (casilla == posicionPelota)
                    return true;
                return false;
            }
        }
    }
}
