using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        public Rectangle rectangle;
        public double red, green, blue, alpha;
        internal double x;
        internal double y;

        //public CharacterType type;

        public void Draw(ICanvas canvas)
        {

        }

        public void MoveCharacterX(double x1, double x2)
        {

        }

        public void MoveCharacterY(double y1, double y2)
        {

        }

        public void SetCharacterPos(double x, double y)
        {

        }

        public void SetCharacterPosX(double x)
        {

        }

        public void SetCharacterPosY(double y)
        {

        }

        public void SetCharacterSize(double x, double y)
        {

        }

        public void SetCharacterColor(double b, double g, double r, double a)
        {

        }

        public void SetCharacter(double x, double y, double b, double g, double r, double a)
        {

        }

        public double GetRectanglePositionX(double positionX)
        {
            return positionX;
        }

        public double GetRectanglePositionY(double positionY)
        {
            return positionY;
        }

        public double GetRectangleWidth(double width)
        {
            return width;
        }
        public double GetRectangleHeight(double height)
        {
            return height;
        }

    }
}
