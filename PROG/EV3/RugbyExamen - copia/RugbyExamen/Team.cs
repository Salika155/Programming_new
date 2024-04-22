using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public enum TeamType
    {
        Blue = -1,
        Red = 1,
        UNKNOWN
    }
    public class Team
    {
        
        private string _name;
        public Player[] team = new Player[10];
        private int _score;
        private TeamType _teamType;

        public Team(string name, TeamType teamType)
        {
            _name = name;
            _teamType = teamType;
        }

        public Team()
        {
        }

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        public TeamType TeamType
        {
            get { return _teamType; }
            set { _teamType = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void AddPlayers(Player player, TeamType teamType)
        {
            if (teamType == TeamType.Blue)
            {
                for (int i = 0; i <= 10; i++)
                {
                    team[i] = player;
                }
            }
            else if (teamType == TeamType.Red)
            {
                for (int i = 0; i <= 10; i++)
                {
                    team[i] = player;
                }
            }
        }

        public void AddScore(int points)
        {
            _score += points;
        }

        //public bool TeamHasBall(Game game)
        //{
        //    foreach (Player player in team)
        //    {
        //        if (game.HasBall(player))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //addjugadores


    }
    
}
