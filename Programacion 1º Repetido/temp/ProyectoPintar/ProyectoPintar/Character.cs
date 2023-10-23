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
        public Rectangulo rectangulo = new Rectangulo();

        public double red, green, blue, alpha;
        

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
       
        public void SetCharacterColor(double b, double g, double r, double a)
        {

        }

        public void SetCharacter(double x, double y, double b, double g, double r, double a)
        {

        }

        
        public double GetRectangleWidth(double width)
        {
            return rectangulo.width;
        }
        public double GetRectangleHeight(double height)
        {
            return rectangulo.height;
        }

    }
    public class Rectangulo
    {
        public double x;
        public double y;
        public double width;
        public double height;

        //public void Draw(ICanvas canvas)
        //{

        //}

        //public void SetPositionX(double positionX)
        //{

        //}

        //public void SetPositionY(double positionY)
        //{

        //}

        //public void SetWidth(double width)
        //{

        //}

        //public void SetHeight(double height)
        //{

        //}

        //public double GetPositionX(double positionX)
        //{
        //    return positionX;
        //}

        //public double GetPositionY(double positionY)
        //{
        //    return positionY;
        //}

        //public double GetWidth(double widtth)
        //{
        //    return widtth;
        //}

        //public double GetHeight(double height)
        //{
        //    return height;
        //}

    }
}
