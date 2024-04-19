using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public class Player : Character
    {
        private string _Name = "";
        private Team _Team;
        private int _InitialX;
        private int _InitialY;


        public Player(Team team)
        {
            //_Name = name;
            _Team = team;
            _InitialX = 0;
            _InitialY = 0;
            
        }

        public string Name {get { return _Name; } set { _Name = value; } }
        public Team Team { get { return _Team; }}
        public int InitialX { get { return _InitialX; } set { _InitialX = value; } }
        public int InitialY { get { return _InitialY; } set { _InitialY = value; } }

        public override void ExecuteTurn()
        {
           
        }

        public Team GetTeam()
        {
            return _Team;
        }
    }
}
