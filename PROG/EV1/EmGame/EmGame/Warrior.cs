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
        private Weapon _weapon;

        public Warrior()
        {

        }

        public Warrior(int x, int y, int life, double accuracity, int armor, double lucky, TeamType type, Weapon weapon)
        {
            _x = x;
            _y = y;
            _life = life;
            _accuracity = accuracity;
            _armor = armor;
            _lucky = lucky;
            _type = type;
            _weapon = weapon;
        }

        public int GetX()
        {
            return _x;
        }

        public int GetY() 
        {
            return _y;
        }

        public int GetLife() 
        {
            return _life;
        }

        public int GetArmor() 
        {
            return _armor;
        }

        public double GetAccuracity()
        {
            return _accuracity;
        }

        public double GetLucky()
        {
            return _lucky;
        }

        public TeamType GetTeamType()
        {
            if (_type == TeamType.HUMAN)
                return TeamType.HUMAN;
            if (_type == TeamType.DWARF)
                return TeamType.DWARF;
            if (_type == TeamType.ELF)
                return TeamType.ELF;
            if (_type == TeamType.ORC)
                return TeamType.ORC;
            return 0;
        }

        public void SetX(int x)
        {
            _x = x;
        }

        public void SetY(int y)
        {
            _y = y;
        }

        public void SetTeamType(TeamType type)
        {
            _type = type;
        }

        public void ExecuteTurn(WarZone warZone)
        {
            
        }
    }
}
