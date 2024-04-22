using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyExamen
{
    public class Utils
    {
        private static Random r = new();

        public static int GetRandom(int min, int max)
        {
            return r.Next(min, max);
        }

        public static bool IsInRange(int x, int y, int x2, int y2, int range)
        {
            return Math.Abs(x - x2) <= range && Math.Abs(y - y2) <= range;
        }

        public static void ConfigurarDefensa(Player player, int index)
        {
            var dir = player.Team.TeamType;
            int y = 0;

            if (dir == TeamType.Blue)
            {
                y = 19;
            }
            
            if (index == 0)
            {
                player.Position.x = 0;
                player.Position.y = 0;
            }  
        }
    }
}
