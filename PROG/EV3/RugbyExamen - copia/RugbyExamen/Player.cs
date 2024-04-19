using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public abstract class Player : Character
    {
        private string _name = "";
        private Team _team;
        private int _InitialX;
        private int _InitialY;


        public Player(string name, Team team, Position position) : base(position)
        {
            _name = name;
            _team = team;
            _InitialX = 0;
            _InitialY = 0;
            
        }

        public string Name {get { return Name; } set { Name = value; } }
        public Team Team { get { return _team; }}
        public int InitialX { get { return _InitialX; } set { _InitialX = value; } }
        public int InitialY { get { return _InitialY; } set { _InitialY = value; } }

        
        

       
    }
}
