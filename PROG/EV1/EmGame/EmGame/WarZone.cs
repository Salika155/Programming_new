using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmGame
{
    internal class WarZone
    {
        List<Warrior> warriors;
        private int _width;
        private int _height;

        public WarZone(int width, int height)
        {
            this._width = width;
            this._height = height;
            warriors= new List<Warrior>();
        }
        public void CreateWarriors(int count, TeamType TeamType)
        {
            Warrior warrior = new Warrior();

        }
        public void RemoveAt(int index)
        {
            warriors.RemoveAt(index);
        }

        public void MoveWarrior(Warrior warrior, int x, int y)
        {

        }
        
        
        
    }
}
