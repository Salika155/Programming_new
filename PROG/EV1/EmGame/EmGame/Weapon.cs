using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmGame
{
    public enum WeaponType
    {
        PUNCH,
        SWORD,
        BOW,
        ARROW,
        MAZE
    }
    public class Weapon
    {
        private WeaponType _weaponType;
        private int _reloadTime;

        public WeaponType GetWeaponType()
        {
            return _weaponType;
        }

        public int GetDamage()
        {
            if (_weaponType == WeaponType.PUNCH)
                return 5;
            if (_weaponType == WeaponType.ARROW)
                return 10;
            if (_weaponType == WeaponType.MAZE)
                return 15;
            if (_weaponType == WeaponType.BOW)
                return 20;
            if (_weaponType == WeaponType.SWORD)
                return 30;
            return 0;
        }
        public int GetReloadTime()
        {
            return _reloadTime;
        }
    }
}
