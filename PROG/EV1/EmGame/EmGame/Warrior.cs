using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmGame
{
    public enum TeamType
    {
        HUMAN,
        DWARF,
        ORC,
        ELF
    }
    public class Warrior
    {
        private int _x;
        private int _y;
        private int _life;
        private double _accuracity;
        private int _armor;
        private double _lucky;
        private TeamType _type;

    }
}
