﻿using System.Collections.Generic;

namespace RugbyExamen
{
    public delegate bool Visitor(Character character);

    //public enum CharacterType
    //{
    //    Striker,
    //    Defense,
    //    SpecialDefense,
    //    Dementor
    //}

    public class Game
    {
        private List<Character> _chars = new List<Character>();
        
        private Team _team1;
        private Team _team2;
        private int _duration;
        private Ball _ball;
        
        

        public Game(string TeamBlue, string TeamRed)
        {
            _board = new int[20, 10];
            _duration = 1000;
            Ball ball = new Ball(0, 0);
            _team1 = new Team(TeamBlue, TeamType.Blue);
            _team2 = new Team(TeamRed, TeamType.Red);
            CreateBoard();
            PlayersPositioned();
            DementorsPositioned();
            BallPositioned();
        }

        private void CreateBoard()
        {
           for (int y = 0; y < 10; y++)
           {
               for (int x = 0; x < 20; x++)
               {
                    _board[y, x] = 0;
               }
           }
        }

        public List<Character> Chars { get => _chars; set => _chars = value; }


        public void Star()
        {
            for (int i = 0; i < _duration; i++)
            {
               foreach (Character character in _chars)
               {
                    character.ExecuteTurn();
               }

               if (IsGameOver())
               {
                    //PrintScore();
                    break;
               }
            }
        }

        public void Exec()
        {
            PlayersPositioned();
            DementorsPositioned();
            BallPositioned();
        }

        private bool IsGameOver()
        {
            return _turns == _duration;
        }   

        private static void BallPositioned()
        {
            
        }

        private static void DementorsPositioned()
        {
            throw new NotImplementedException();
        }

        private void PlayersPositioned()
        {
            int[] positionsX = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] positionsY = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Team _team1 = new Team("Blue", TeamType.Blue);
            Team _team2 = new Team("Red", TeamType.Red);

            for (int i = 0; i < 10; i++)
            {
                Defense defense1Team1 = new Defense(_team1);
                defense1Team1.X = positionsX[i];
                defense1Team1.Y = positionsY[i];
                _chars.Add(defense1Team1);

                Defense defense2Team1 = new Defense(_team1);
                defense2Team1.X = positionsX[i];
                defense2Team1.Y = positionsY[i];
                _chars.Add(defense2Team1);

                Defense defense1Team2 = new Defense(_team2);
                defense1Team2.X = positionsX[i];
                defense1Team2.Y = positionsY[i];
                _chars.Add(defense1Team2);

                Defense defense2Team2 = new Defense(_team2);
                defense2Team2.X = positionsX[i];
                defense2Team2.Y = positionsY[i];
                _chars.Add(defense2Team2);

                Striker striker1Team1 = new Striker(_team1);
                striker1Team1.X = positionsX[i];
                striker1Team1.Y = positionsY[i];
                _chars.Add(striker1Team1);

                Striker striker2Team1 = new Striker(_team1);
                striker2Team1.X = positionsX[i];
                striker2Team1.Y = positionsY[i];
                _chars.Add(striker2Team1);

                Striker striker3Team1 = new Striker(_team1);
                striker3Team1.X = positionsX[i];
                striker3Team1.Y = positionsY[i];
                _chars.Add(striker3Team1);

                Striker striker4Team1 = new Striker(_team1);
                striker4Team1.X = positionsX[i];
                striker4Team1.Y = positionsY[i];
                _chars.Add(striker4Team1);

                Striker striker1Team2 = new Striker(_team2);
                striker1Team2.X = positionsX[i];
                striker1Team2.Y = positionsY[i];
                _chars.Add(striker1Team2);

                Striker striker2Team2 = new Striker(_team2);
                striker2Team2.X = positionsX[i];
                striker2Team2.Y = positionsY[i];
                _chars.Add(striker2Team2);

                Striker striker3Team2 = new Striker(_team2);
                striker3Team2.X = positionsX[i];
                striker3Team2.Y = positionsY[i];
                _chars.Add(striker3Team2);

                Striker striker4Team2 = new Striker(_team2);
                striker4Team2.X = positionsX[i];
                striker4Team2.Y = positionsY[i];
                _chars.Add(striker4Team2);

                SpecialDefense specialDefense1Team1 = new SpecialDefense(_team1);
                specialDefense1Team1.X = positionsX[i];
                specialDefense1Team1.Y = positionsY[i];
                _chars.Add(specialDefense1Team1);

                SpecialDefense specialDefense2Team1 = new SpecialDefense(_team1);
                specialDefense2Team1.X = positionsX[i];
                specialDefense2Team1.Y = positionsY[i];
                _chars.Add(specialDefense2Team1);

                SpecialDefense specialDefense1Team2 = new SpecialDefense(_team2);
                specialDefense1Team2.X = positionsX[i];
                specialDefense1Team2.Y = positionsY[i];
                _chars.Add(specialDefense1Team2);

                SpecialDefense specialDefense2Team2 = new SpecialDefense(_team2);
                specialDefense2Team2.X = positionsX[i];
                specialDefense2Team2.Y = positionsY[i];
                _chars.Add(specialDefense2Team2);



                
            }


        }

        public bool PlayerHasBall(int x, int y)
        {
            foreach (var character in _chars)
            {

            }
            return false;



        }

        public static Character GetCharacterAt(List<Character> character, int x, int y)
        {
            for (int i = 0; i < character.Count; i++)
            {
                Character character1 = character[i];
                if (character1.X == x && character1.Y == y)
                {
                    return character1;
                }
            }
            return null;
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