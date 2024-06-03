using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oca
{
    internal class Player
    {
        public string Name { get; }
        public int Position { get; set; }

        public Player(string name, int position)
        {
            Name = name;
            Position = 0;
        }

        public void Move(int squares)
        {
            Position += squares;
        }

    }
}
