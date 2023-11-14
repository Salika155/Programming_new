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

        public void PaintWarZone()
        {
            for (int y = 0; y <= _height - 1; y++)
            {
                for (int x = 0; x <= _width - 1; x++)
                {
                    Warrior? warrior = GetWarriorAt(x, y);

                    if (warrior != null)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(" W ");
                        Console.ResetColor();
                    }
                 
                    else 
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(" I ");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine(); 
            }
        }

        private bool IsOccupied(int x, int y)
        {
           for (int i = 0; i < warriors.Count; i++)
           {
                var warrior = warriors[i];
                if (warrior.GetX() == x && warrior.GetY() == y)
                {
                    return true;
                } 
           }
            return false;
        }


        public void CreateWarriors(int count, TeamType type)
        {
            for(int i = 0; i < count; i++)
            {
                    int x = UtilsEmGame.GetRandom(1, _width);
                    int y = UtilsEmGame.GetRandom(1, _height);

                if (!IsOccupied(x, y))
                {
                    Warrior warrior = new Warrior(x, y, 10, 6.0, 6, type);
                    warriors.Add(warrior);
                    i++;
                }
                else
                {
                    Warrior warrior = new Warrior(x + 1, y + 1, 10, 6.0, 6, type);
                    warriors.Add(warrior);
                    i++;
                }
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

        public void MoveWarrior(int x, int y)//se supone warrior no hay que pasarselo
        {
            if (x > 0 && x <= _width && y > 0 && y >= _height)
            {
                for (int i = 0; i < warriors.Count; i++)
                {
                    Warrior warrior = warriors[i];

                    warrior.SetX(x);
                    warrior.SetY(y);
                    
                }
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
                warriors[i].ExecuteTurn(warZone);
            }

        }

        public Warrior? GetWarriorAt(int x, int y)
        {
            if (IsWarPosValid(x, y) && (!IsOccupied(x, y)))
                for (int i = 0; i < warriors.Count; i++)
                {
                        Warrior warrior = warriors[i];
                        if (warrior.GetX() == x && warrior.GetY() == y)
                        return warrior;
                }
            return null;
        }

        public int GetWarriorCount(TeamType team)
        {
            int count = 0;

            for (int i = 0; i < warriors.Count; i++)
            {
                Warrior warrior = warriors[i];
                if (warrior.GetTeamType() == team)
                {
                    count++;
                }
            }
            return count;
        

         //if (warriors != null)
         //    return warriors.Count;
         //return 0;
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
                if (warrior.GetTeamType() != team && warrior != null)
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

            if (IsWarPosValid(x, y) && (!IsOccupied(x, y)))
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
            List<Warrior> warSortbyDist = new List<Warrior>();

            for (int i = 0; i < warriors.Count - 1; i++)
            {
                for (int j = i + 1; j < warriors.Count - i - 1; j++)
                {
                    double d1 = GetDistance(warSortbyDist[i].GetX(), warSortbyDist[i].GetY(), x, y);
                    double d2 = GetDistance(warSortbyDist[j].GetX(), warSortbyDist[j].GetY(), x, y);

                    if (d1 < d2)
                    {
                        Warrior aux;
                        aux = warSortbyDist[i];
                        warSortbyDist[i] = warSortbyDist[j];
                        warSortbyDist[j] = aux;
                    }
                }
            }
            return warSortbyDist;
        }

        public List<Warrior> GetWarriorsSortedByDistance(List<Warrior> warSortbyDist, int x, int y)
        {
            for (int i = 0; i < warriors.Count - 1; i++)
            {
                for (int j = i + 1; j < warriors.Count; j++)
                {
                    double d1 = GetDistance(warSortbyDist[i].GetX(), warSortbyDist[i].GetY(), x, y);
                    double d2 = GetDistance(warSortbyDist[j].GetX(), warSortbyDist[j].GetY(), x, y);

                    if (d1 > d2)
                    {
                        Warrior aux;
                        aux = warSortbyDist[i];
                        warSortbyDist[i] = warSortbyDist[j];
                        warSortbyDist[j] = aux;
                    }
                }
            }
            return warSortbyDist;
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
            if (warriors == null || warriors.Count == 0)
                return;

            if (w1 < 0 || w1 >= warriors.Count || w2 < 0 || w2 >= warriors.Count)
                return;

            // Intercambiar guerreros en las posiciones w1 y w2
            Warrior temp = warriors[w1];
            warriors[w1] = warriors[w2];
            warriors[w2] = temp;
        }

        public List<Warrior> GetWarriorsAround(int x, int y)
        {
            return warriors;
        }

        public List<Warrior> GetEnemiesInRange(Warrior warrior)
        {
            return warriors;
        }

        public bool IsGameFinished(WarZone warZone)
        {
            return false;
        }

        //getwarriorcount y getwarriorat acceder a elementos de lista si no nos dejan, salen examen

        
    }
}
