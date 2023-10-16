using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDelfin
{
    public enum CharacterType
    {
        POLICE,
        THIEF

    }
    public class Character
    {
        public string? name;
        //string name = "";
        public CharacterType type = CharacterType.POLICE;
        public double x = 0.0;
        public double y = 0.0;
        public double size = 1.0;
        public double velocity = 1.0;

        


    }
}
