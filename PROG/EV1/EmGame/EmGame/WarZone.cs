using System;


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

        public void CreateWarriors(int humans, int orcs, int dwarfs, int elves)
        {
            CreateWarriors(humans, TeamType.HUMAN);
            CreateWarriors(orcs, TeamType.ORC);
            CreateWarriors(dwarfs, TeamType.DWARF);
            CreateWarriors(elves, TeamType.ELF);
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

        public void MoveWarrior(Warrior warrior, int x, int y)//se supone warrior no hay que pasarselo
        {
            if (x > 0 && x > _width && y > 0 && y < _height)
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

        public void ExecuteRound(WarZone warZone)
        {
            for (int i = 0; i < warriors.Count; i++)
            {
                Warrior warrior = warriors[i];
                warrior.ExecuteTurn(warZone);
            }

        }

        public Warrior? GetWarriorAt(int x, int y)
        {
            if (IsWarPosValid(x, y))
                for (int i = 0; i < warriors.Count; i++)
                {
                        Warrior warrior = warriors[i];
                        if (warrior.GetX() == x && warrior.GetY() == y)
                        return warrior;
                }
            return null;
        }

        public int GetWarriorCount()
        {
            if (warriors != null)
                return warriors.Count;
            return -1;
        }

        public Warrior? GetWarriorAt(int index)
        {
            //if (index >= 0 || index < warriors.Count)
            //{
            //    return warriors[index];
            //}
            //return null;
            return (index >= 0 && index < warriors.Count) ? warriors[index] : null;
        }

        public int GetEnemiesAroundCount(int x, int y, TeamType team)
        {
            int x0 = x - 1; int y0 = y - 1; int x1 = x + 1; int y1 = y + 1;
            //si el tipo es diferente al del equipo del warrior, es un enemigo
            List<Warrior> warriorsenemies = GetWarriorsInside(x0, y0, x1, y1);

            int enemyCount = 0;

            for (int i = 0; i < warriorsenemies.Count; i++)
            {
                var warrior = warriorsenemies[i];
                if (warrior.GetTeamType() != team)
                {
                    enemyCount++;
                }  
            }
            return enemyCount;
        }

        public bool IsBattleFinished()
        {
            //si el warrior ha atacado, o gastado la accion, la batalla finaliza
            return true;
        }

        public static double GetDistance(Warrior w1, Warrior w2)
        {
            return GetDistance(w1.GetX(), w1.GetY(), w2.GetX(), w2.GetY());
        }

        public static double GetDistance(int x, int y, Warrior warrior)
        {
            return GetDistance(x, y, warrior.GetX(), warrior.GetY());

        }

        public static double GetDistance(int x1, int y1, int x2, int y2)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public bool IsWarPosValid(int x, int y)
        {
            return ((x > 0 && x <= _width)&&(y > 0 && y <= _height));
        }

        public int GetPlayersArroundCount(int x, int y)
        {
            List<Warrior> warriorsAround = new List<Warrior>();

            if (IsWarPosValid(x, y))
            {
                int x0 = x - 1; int y0 = y - 1; int x1 = x + 1; int y1 = y + 1;
                return GetWarriorsInside(x0, y0, x1, y1).Count();
            }
            return 0;
        }

        public List<Warrior> GetWarriorsInside(int x, int y, int width, int height)
        {
            int i = x;
            int j = y;

            List<Warrior> warriorsAt = new List<Warrior>();

            while (i <= _width && j <= _height)
            {
                i++;
                j++;
                if (j == height)
                    j = y;

                if (GetWarriorAt(i, j) == null)
                    continue;
                warriorsAt.Add(GetWarriorAt(i, j));
            }
            return warriorsAt;
        }

        public List<Warrior> GetWarriorsSortedByDistance(int x, int y)
        {
            return warriors;

        }

        public List<Warrior> GetWarriorsSortedByDistance(List<Warrior> warriors,int x, int y)
        {
            return warriors;

        }

        public List<Warrior> DuplicateWarriors()
        {
            List<Warrior> duplicatedWarriors = new List<Warrior>();

            for (int i = 0; i < warriors.Count; i++)
            {
                Warrior originalWarrior = warriors[i];

                // Crea un nuevo guerrero y asigna sus propiedades con los valores del guerrero original
                Warrior duplicatedWarrior = new Warrior();
                originalWarrior.GetX();
                originalWarrior.GetY();
                originalWarrior.GetLife();
                originalWarrior.GetAccuracity();
                originalWarrior.GetArmor();
                originalWarrior.GetTeamType();

                duplicatedWarriors.Add(duplicatedWarrior);
            }
            
            return duplicatedWarriors;
        }

       

        public static void SwapWarriors(List<Warrior> warriors, int w1, int w2)
        {
            for (int i = 0; i < warriors.Count; i++)
                if () ;

        }


        public List<Warrior> GetWarriorsAround(int x, int y)
        {
            return warriors;
        }

        public List<Warrior> GetEnemiesInRange(Warrior warrior)
        {
            return warrior;
        }

        public bool IsGameFinished(WarZone warZone)
        {
            return true;
        }

        //getwarriorcount y getwarriorat acceder a elementos de lista si no nos dejan, salen examen

    }
}
