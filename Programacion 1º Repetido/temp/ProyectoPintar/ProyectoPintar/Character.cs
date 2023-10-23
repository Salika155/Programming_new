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
            canvas.FillShader.SetColor(red, green, blue, alpha);
            canvas.DrawRectangle(rectangulo.x, rectangulo.y, rectangulo.width, rectangulo.height);
        }

        public void MoveCharacterX(double x)
        {
            this.rectangulo.x += x;
        }

        public void MoveCharacterY(double y)
        {
            rectangulo.y += y;
        }

        public void SetCharacterPosition(double x, double y)
        {
            rectangulo.x += x;
            rectangulo.y += y;
        }

        public void SetCharacterPositionX(double x)
        {
            rectangulo.x += x;
        }

        public void SetCharacterPositionY(double y) 
        {
            rectangulo.y += y;
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
   
}
