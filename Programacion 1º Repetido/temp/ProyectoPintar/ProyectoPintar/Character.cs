using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDK;

namespace ProyectoPintar
{

    //public enum CharacterType
    //{
    //    POLI,
    //    CACO
    //}

    public class Character
    {
        public double x;
        public double y;
        public double red, green, blue, alpha;
        public Rectangle? rectangle;
        //public CharacterType type;

        public class Rectangle
        {
            public double x;
            public double y;
            public double width;
            public double height;

        }

        
    }

}
