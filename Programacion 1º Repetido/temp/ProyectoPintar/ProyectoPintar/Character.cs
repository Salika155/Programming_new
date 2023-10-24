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

        public Character()
        {
        }

        public void Draw(ICanvas canvas)
        {
            canvas.FillShader.SetColor(red, green, blue, alpha);
            canvas.DrawRectangle(rectangulo.x, rectangulo.y, rectangulo.width, rectangulo.height);
        }

        public void MoveCharacterX(double x)
        {
            double nwBorderX = rectangulo.x + x;
            if (IsInsideWorldBorder(nwBorderX, rectangulo.y)) 
            {
                rectangulo.x = nwBorderX;
            }
        }

        public void MoveCharacterY(double y)
        {
           double nwBorderY = rectangulo.y + y;
            if(IsInsideWorldBorder(nwBorderY, rectangulo.x))
            {
                rectangulo.y = nwBorderY;
            }
        }

        public void SetCharacterPosition(double x, double y)
        {
            rectangulo.x = x;
            rectangulo.y = y;
        }

        public double GetCharacterWidth()
        {
            return rectangulo.width;
        }

        public double GetCharacterHeight()
        {
            return rectangulo.height;
        }

        public double GetCharacterPositionX()
        {
            return rectangulo.x;
        }

        public double GetCharacterPositionY()
        {
            return rectangulo.y;
        }

        public void SetCharacterWidth(double width)
        {
            rectangulo.width = width;
        }

        public void SetCharacterHeight(double height)
        {
            rectangulo.height = height;
        }

        private bool IsInsideWorldBorder(double x, double y)
        {
            return true;
        }
    }
   
}
