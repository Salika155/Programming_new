using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_program_eva
{

    public enum playType
    {
        ROCK,
        PAPER,
        SCISSORS,
        LIZARD,
        SPOCK,
    }
    internal class Game
    {
        public static int GetResultRPSLS(playType play1, playType play2)
        {
            if (play1 == play2)
                return 0;

            if (play1 == playType.PAPER)
            {
                if (play2 == playType.ROCK || play2 == playType.SPOCK)
                    return -1;
            }
            else if (play1 == playType.SCISSORS || play2 == playType.LIZARD)
                return 1;

            if (play1 == playType.ROCK)
            {
                if (play2 == playType.)
            }

        }
    }
}
