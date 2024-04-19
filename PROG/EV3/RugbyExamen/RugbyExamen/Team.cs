using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public enum TeamType
    {
        Blue,
        Red
    }
    public class Team
    {
        private string _name;
        public Player[] team = new Player[10];
        //private int _score;
        private TeamType _teamType;

        public Team(string name, TeamType teamType)
        {
            _name = name;
            _teamType = teamType;
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }

            //addjugadores


        }
    }
}
