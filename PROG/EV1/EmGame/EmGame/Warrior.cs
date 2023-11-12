using System;


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
        //private double _lucky;
        private TeamType _team;
        private int _cooldown;
        private Weapon _weapon;

        public Warrior()
        {

        }

        public Warrior(int x, int y, int life, double accuracity, int armor, /*double lucky,*/ TeamType type, Weapon weapon)
        {
            _x = x;
            _y = y;
            _life = life;
            _accuracity = accuracity;
            _armor = armor;
            //_lucky = lucky;
            _team = type;
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

        //public double GetLucky()
        //{
        //    return _lucky;
        //}

        public int GetCoolDown()
        {
            return _cooldown;
        }

        public Weapon GetWeapon()
        {
            return _weapon;
        }

        public TeamType GetTeamType()
        {
            if (_team == TeamType.HUMAN)
                return TeamType.HUMAN;
            if (_team == TeamType.DWARF)
                return TeamType.DWARF;
            if (_team == TeamType.ELF)
                return TeamType.ELF;
            if (_team == TeamType.ORC)
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
            _team = type;
        }

        public void SetCoolDown(int cooldown)
        {
            _cooldown = cooldown;
        }

        public void ExecuteTurn(WarZone warZone)
        {

            
        }

        public void Move(int x, int y)
        {
            _x = x;
            _y = y;
        }

        
    }
}
