using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RugbyExamen
{
    public class Striker : Player
    {
        public Striker(Team team) : base(team)
        {

        }

        public override void ExecuteTurn()
        {
            if (HasBall() && CanGoToGoal())
            {
                GoToGoal();
            }
            else if(!HasBall())
            {
                GoToBall();
            }
            else
            {
                TryToPass();
            }

        }

        private static void TryToPass()
        {
            
        }

        private void GoToBall()
        {
            int currentX = this.X;
            int currentY = this.Y;

            int ballX = 0;
            int ballY = 0;

            int moveX = Math.Sign(ballX - currentX);
            int moveY = Math.Sign(ballY - currentY);

            if (IsCellEmpty(currentX + moveX, currentY + moveY))
            {
                this.X += moveX;
                this.Y += moveY;
            }
            else
            {

            }
        }

        private static void GoToGoal()
        {
           
        }

        public static bool CanGoToGoal(Character character, TeamType team, int[,] board)
        {
            int goal = (team == TeamType.Blue) ? 0 : 19;

            if ((team == TeamType.Blue && character.Y < goal) || (team == TeamType.Red && character.Y > goal))
            {
                int nextY = (team == TeamType.Blue) ? character.Y + 1 : character.Y - 1;
                if (board[character.X, nextY] == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool HasBall(Character character, Ball ball)
        {
            return character._x == ball.X && character.Y == ball.Y;
            
        }

        public static bool IsCellEmpty(Character character)
        {
            
        }

        
    }
}
