using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oca
{
    internal class Game
    {
        private List<Player> players;
        private Board board;
        private Dice dice;

        public Game()
        {
            players = new List<Player>();
            board = new Board();
            dice = new Dice();
        }


        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void Execute()
        {
            while(true)
            {
                foreach(var p in players)
                {
                    int roll = dice.RollDice();
                    p.Move(roll);
                    p.Position = board.GetNextSquare(p.Position);

                    if (p.Position == Board.SquaresTotal)
                    {
                        Console.WriteLine("has ganado");
                    }
                }
            }
        }
    }
}
