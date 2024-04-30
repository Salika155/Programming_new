﻿using System.Collections.Generic;

namespace RugbyExamen
{
    public delegate void Visitor(Character character);

    //public enum CharacterType
    //{
    //    Striker,
    //    Defense,
    //    SpecialDefense,
    //    Dementor
    //}

    public class Game
    {
        private IBoardGame _boardGame = new BoardGameBasedInList();
        private List<Character> _charList = new List<Character>();
        private Position _size;
        private Team _team1 = new Team();
        private Team _team2 = new Team();
        //private Team[_team1, team2]
        private int _duration;
        private Ball _ball;
        private int _turns;
        
        public Position Size
        { get => _size; }
        

    public Game(string TeamBlue, string TeamRed)
        {
            _size = new Position(10, 20);
            _duration = 1000;
            //_ball = new Ball(GetRandomPositionOnGame());
            _team1 = new Team(TeamBlue, TeamType.Blue);
            _team2 = new Team(TeamRed, TeamType.Red);
            //CreateBoard();
            //PlayersPositioned();
            //DementorsPositioned();
            //BallPositioned();
        }

        private void GeneratePlayers()
        {
            _charList.Add(new Defense("a", _team1, 3, 1));
            _charList.Add(new Defense("b", _team1, 3, 2));

            //var list = _boardGame.IsAvailable();
            //var availablePositions = new List<Position>(list);
            var availablePositions = GetAvailableCells();
            for (int i = 0; i < 4; i++) 
            {
                var index = Utils.GetRandom(0, availablePositions.Count - 1);
                var coordenadas = availablePositions[index];
                var dementor = new Dementor("Dementor " + i, coordenadas);
                _boardGame.AddPlayer(dementor);
                availablePositions.RemoveAt(index);
            }
        }

        private void MeterLosJugadoresACampo()
        {
            Visit(pj => _boardGame.AddPlayer(pj));
            //Visit(_boardGame.AddPlayer);
            
        }

        private List<Character> GetPersonajesDeUnEquipo(Team team)
        {
            var ret = new List<Character>();

            foreach (var character in _charList)
            {
                if (character is Player pj && pj.Team == team)
                {
                    ret.Add(character);
                }
            }
            return ret;
        }

        public void Visit(Action<Character> visitor)
        {
            if (visitor == null)
            {
                return;
            }
            foreach (var p in _charList)
            {
                visitor(p);
            }
        }

        List<Position> GetAvailableCells()
        {
            List<Position> availableCells = new List<Position>();
            for (int x = 0; x < IBoardGame.WIDTH; x++)
            {
                for (int y = 0; y < IBoardGame.HEIGHT; y++)
                {
                    if (IsAvailable(x, y))
                    {
                        availableCells.Add(new Position(x, y));
                    }
                }
            }
            return availableCells;
        }

        public bool IsAvailable(int x, int y)
        {
            if (x < 0 || x >= 10)
                return false;
            if (y < 0 || y >= 20)
                return false;
            if (_boardGame.GetCharacterAt(x, y) != null)
                return false;
            return true;
        }

        public void Start()
        {
            GeneratePlayers();
            MeterLosJugadoresACampo();
        }

        public void Jugar()
        {
            for (int round = 0; round < _duration; round++)
            {
                Hacerquelosjugadoresrealicensujugada();
                if (GetJugadorQueHaMarcado != null)
                {
                    Sumarpuntuaciondegolalequipocorrespondiente();
                    ReiniciarPosicionJugadores();
                }

            }

        }

        private Player? GetJugadorQueHaMarcado()
        {
            Ball ball = _boardGame.GetBall();

            foreach (Character pj in _charList)
            {
                //pattermatter
                if (pj is Player player)
                {
                    if (player.HaMarcado(_boardGame.GetBall()))
                        return player;
                }
            }
            return null;

        }

        private bool HayGol()
        {
            return GetJugadorQueHaMarcado() != null;
            //Ball ball = _boardGame.GetBall();

            //foreach (Character pj in _charList)
            //{
            //    //pattermatter
            //    if (pj is Player player)
            //    {
            //        if (player.HaMarcado(ball))
            //            return true;
            //    }
            //}
            //return false;

        }

        private void ReiniciarPosicionJugadores()
        {
            var list = GetPersonajesDeUnEquipo(_team1);
            int defensaIndex = 0;
            int delanteroIndex = 0;

            {
                foreach (var pj in list)
                {
                   if (pj is SpecialDefense)
                   {
                        
                   }
                   else if (pj is Defense)
                   {
                        Utils.ConfigurarDefensa((Player)pj, defensaIndex++);
                   }
                   else if (pj is Striker)
                   {
                        
                   }
                }
            }
        }

        public void PonerAlosJugadoresEnPosicionDeOrigen()
        {

        }

        private void Sumarpuntuaciondegolalequipocorrespondiente()
        {
            Player player = GetJugadorQueHaMarcado();
            if (player == null)
                return;

            if (player is SpecialDefense)
                player.Team.Score += 1;
            else if (player is Defense)
                player.Team.Score += 1;
            else 
                player.Team.Score += 10;
                
            
        }

        private void Hacerquelosjugadoresrealicensujugada()
        {
            foreach (var pj in _charList)
            {
                pj.ExecuteTurn(_boardGame);
            }
        }
    }
}

//● El partido se juega en un grid de 10x20
//● En cada equipo juegan 10 jugadores. 4 delanteros, 4 defensas y 2 defensas especiales.
//● También hay 4 dementores.
//● Inicialmente (y después de cada gol) los jugadores se sitúan de la siguiente manera

//● Los dementores comienzan en una casilla random donde no haya nada.
//● Si un jugador marca, esto es, llega al fin del campo contrario con la pelota:
//○ Si es un defensa, se le suma 3 puntos a su equipo
//○ Si es un delantero, se le suma 10 puntos a su equipo.
//● Al iniciar el partido (o después de que algún jugador marque gol) el balón comienza en una
//casilla random.Si le cae a un jugador, se queda con la pelota
//● El partido termina al cabo de los 1000 turnos.
//● Los jugadores tienen las siguientes características
//○ Nombre y equipo, que se tiene que poner mediante constructor
//○ Sólo puede realizar una acción en su turno
//● En su turno, un defensa:
//○ Si tiene la pelota
//■ Puede avanzar una casilla en cualquier dirección, pero no ha de estar
//ocupada esa casilla
//■ [IMPRESCINDIBLE] Puede pasársela a un compañero.Tiene entre un 20%
//y un 80% de acertar.Si falla, la pelota caerá en una casilla aleatoria a dos
//casillas de distancia del compañero al que le ha intentado pasar el balón.
//○ Si no tiene la pelota
//■ Si tiene el balón a su alcance (en una casilla contigua a él/ella) y no lo tiene
//nadie, lo coge.
//■ [IMPRESCINDIBLE] Si tiene al lado a un contrincante que tenga la pelota,
//tiene entre un 40% y un 60% de quitársela (depende de la habilidad de los
//dos jugadores). Si se la quita, la pelota cae en una casilla aleatoria dentro
//de una distancia de dos casillas del defensa.
//■ Puede decidir ir por alguien del equipo contrario
//■ Puede decidir ir por la pelota, esté suelta, o en un jugador contrario
//● En su turno, un delantero:
//○ Si tiene la pelota
//■ Puede avanzar una casilla en cualquier dirección, pero no ha de estar
//ocupada.Esta es su decisión predilecta. Intentará ir directamente a marcar
//puntos. Además, si toma esta decisión, tiene un 20% de probabilidades de
//hacer que le toque otra vez, y luego otro 20%, y luego otro 20%, …, de
//manera que, con muchísima suerte, un jugador delantero puede marcar
//conforme consiga la pelota.
//■ Puede pasársela a un compañero.Tiene entre un 20% y un 40% de acertar
//(depende de la habilidad del jugador). Si falla, la pelota caerá en una casilla
//aleatoria a dos casillas de distancia de su objetivo inicial.
//○ Si no tiene la pelota
//■ Intentará ponerse en una posición lejos de los contrincantes y los
//dementores y cerca de la zona de puntuación
//● Los defensas especiales, hacen lo mismo que los defensas normales, pero además, si
//tienen un contrincante a su alcance, pueden desactivarlo un turno de manera gratuita.Sólo
//un contrincante por turno.
//● En su turno, un dementor puede decidir:
//○ Desactivar a un jugador que tenga al alcance dos turnos.
//○ Moverse hacia un jugador, el que tenga más cercano, pero a más de una casilla de él.
//○ Si no puede moverse hacia el jugador (por estar la casilla ocupada), se puede
//mover una casilla aleatoria en cualquier dirección de las que tiene alrededor.
//○ Hay un 20% de probabilidades de que un dementor pueda volver a decidir qué
//hacer. Es decir, que puede que un dementor haga una acción, o dos, o tres, o …
//● El orden de acción de todos los jugadores (y dementores) se establece al inicio de manera
//aleatoria y no varía.Los turnos no va por equipos, cada jugador de manera individual, tiene
//su momento de actuar dentro del turno.
//Hay que hacer que los jugadores y dementores, de entre todas las posibilidades que tienen para
//hacer, seleccionen una mediante una probabilidad.

//La jerarquía de clases es la siguiente:
//● Partido.Tiene una lista de Personajes.Tiene un método llamado iniciar.Tiene un método
//llamado Ejecutar.Tiene que tener la posibilidad de imprimir todos los personajes, o de
//recorrerlos mediante una lambda.
//● Pelota
//● Equipo(cada equipo tiene su nombre)
//● Personaje Tiene un método llamado Ejecutar Turno(que es abstracto)
//○ Dementor
//○ Jugador.Tiene una referencia a su equipo
//■ Delantero
//■ Defensa
//● Defensa especia