using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public class Player : Character
    {
        private string _Name { get; set; }
        private TeamType _Team { get; set; }
        private int _InitialX;
        private int _InitialY;
        

        public Player(string name, TeamType team, int x, int y)
        {
            _Name = name;
            _Team = team;
            _InitialX = x;
            _InitialY = y;
        }

        public string Name {get { return _Name; }}
        public TeamType Team { get { return _Team; }}
        public int InitialX { get { return _InitialX; }}
        public int InitialY { get { return _InitialY; }}

    }
}
