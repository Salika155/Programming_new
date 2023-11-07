using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmGame
{
    public class WarZone
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
        public void CreateWarriors(int count, TeamType type)
        {
            for(int i = 0; i < count; i++)
            {
                Warrior warrior = new Warrior();
                warrior.SetTeamType(type);
                warriors.Add(warrior);
            }
            

        }
        public Warrior? RemoveWarriorAt(int index)
        {
            if (index >= 0 && index < warriors.Count)
            {
                Warrior removedWarrior = warriors[index];
                warriors.RemoveAt(index);
                return removedWarrior;
            }
            else
                return null;
        }

        public void MoveWarrior(Warrior warrior, int x, int y)
        {
            if ((x > 0 && x > _width) && (y > 0 && y < _height))
            {
                warrior.SetX(x);
                warrior.SetY(y);
            }
        }
        
        public int GetWith()
        {
            return _width;
        }
        
        public int GetHeight()
        {
            return _height;
        }

        public void ExecuteRound()
        {

        }

        public Warrior? GetWarriorAt(int x, int y)
        {

        }

        public int GetWarriorCount()
        {
            return 0;
        }

        public Warrior? GetWarriorAt(int index)
        {

        }

        public int GetEnemiesArroundCount(int x, int y, TeamType team)
        {
            return 0;
        }

        public bool IsBattleFinished()
        {
            return true;
        }

        public double GetDistance(Warrior w1, Warrior w2)
        {
            return GetDistance(w1.GetX(), w1.GetY(), w2.GetX(), w2.GetY());
        }

        public static double GetDistance(int x1, int y1, int x2, int y2)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        //getwarriorcount y getwarriorat acceder a elementos de lista si no nos dejan, salen examen

    }
}
