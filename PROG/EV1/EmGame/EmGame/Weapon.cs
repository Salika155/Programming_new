using System;

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
        private int _damage;
        private int _reloadTime;
        private double _distance;

        public Weapon(WeaponType weaponType, int reloadTime, double distance)
        {
            _weaponType = weaponType;
            _reloadTime = reloadTime;
            _distance = distance;
        }

        public WeaponType GetWeaponType()
        {
            if (_weaponType == WeaponType.PUNCH)
                return WeaponType.PUNCH;
            if (_weaponType == WeaponType.ARROW)
                return WeaponType.ARROW;
            if (_weaponType == WeaponType.MAZE)
                return WeaponType.MAZE;
            if (_weaponType == WeaponType.BOW)
                return WeaponType.BOW;
            if (_weaponType == WeaponType.SWORD)
                return WeaponType.SWORD;
            return 0;
        }

        public int GetDamage()
        {
            return _damage;
        }
        public int GetReloadTime()
        {
            return _reloadTime;

        }

        public double GetWeaponDistance()
        {
            return _distance;
        }

        public void SetWeapon()
        {
            if (_weaponType == WeaponType.PUNCH)
            {
                _reloadTime = 1;
                _distance = 1.5;
                _damage = 5;
            }
                
            if (_weaponType == WeaponType.ARROW)
            {
                _reloadTime = 4;
                _distance = 8.5;
                _damage = 20;
            }
                
            if (_weaponType == WeaponType.MAZE)
            {
                _reloadTime = 2;
                _distance = 2.9;
                _damage = 15;
            }
                
            if (_weaponType == WeaponType.BOW)
            {
                _reloadTime = 3;
                _distance = 1.5;
                _damage = 10;
            }
                
            if (_weaponType == WeaponType.SWORD)
            {
                _reloadTime = 5;
                _distance = 4.3;
                _damage = 30;
            }
        }

        //public void SetDamage()
        //{
        //    if (_weaponType == WeaponType.PUNCH)
        //        return 5;
        //    if (_weaponType == WeaponType.ARROW)
        //        return 20;
        //    if (_weaponType == WeaponType.MAZE)
        //        return 15;
        //    if (_weaponType == WeaponType.BOW)
        //        return 10;
        //    if (_weaponType == WeaponType.SWORD)
        //        return 30;
        //    return 0;
        //}

        
    }
}
