using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UDK;

namespace ProyectoPintar
{
    public class World
    {
        private double width = 30.0;
        private double height = 10.0;
        

        private List<Character> character = new List<Character>();
        private Rectangle worldBorders;
        Random random= new Random();

        public void CreateCharacters(int characterCount)
        {
            for (int i = 0; i < characterCount; i++)
            {
                Character pj = new Character();
                double randomValue = Utils.GetRandom();

                if (randomValue <= 0.3)
                {
                    pj.red= 1.0;
                    pj.blue = 0.0;
                    pj.green = 0.0;
                }
                else if (randomValue <= 0.6)
                {
                    pj.blue = 1.0;
                    pj.green = 0.0;
                    pj.red = 0.0;
                }
                else 
                {
                    pj.green= 1.0;
                    pj.red = 0.0;
                    pj.blue = 0.0;
                }

                pj.alpha = 1.0;
                Rectangulo rectangle = new Rectangulo();
                rectangle.x = Utils.GetRandom(0, width);  
                rectangle.y = Utils.GetRandom(0, height);
                character.Add(pj);
            }
            
        }

        public void CreateWorld(double width, double height)
        {
            //return width; 
        }

        public int GetCharacterCount()
        {
            return character.Count;
        }

        public Character? GetCharacterAt(int index)
        {
            if (index < 0 || index >= character.Count)
                return null;

            return character[index];
        }

        public void DrawCharacters(ICanvas canvas)
        {
            for (int i = 0; i < character.Count; i++)
            {
                Rectangulo r = character[i].rectangulo;
                canvas.FillShader.SetColor(r.red, r.green, r.blue, r.alpha);
                canvas.DrawRectangle(r.x, r.y, 1.5, 1.5);
            }
        }

       public void DrawWorld(ICanvas canvas)
        {
            canvas.Clear(1.0, 1.0, 1.0, 1.0);
            canvas.Camera.SetRectangle(0.0, 0.0, width, height);
            canvas.FillShader.SetColor(0.5, 0.5, 1.0, 1.0);
            canvas.DrawRectangle(0.0, 0.0, width, height);

        }

        //public void SetWorldBounds(double x, double y, double width, double height)
        //{
        //    worldBorders = new Rectangle();
        //}

        public double GetWorldSizeX(double WorldSizeX)
        {
            return WorldSizeX;
        }

        public double GetWorldSizeY(double WorldSizeY) 
        {
            return WorldSizeY;
        }

        public double GetCharacterPosX(double CharacterPosX)
        {
            return CharacterPosX;
        }

        public double GetCharacterPosY(double CharacterPosY)
        {
            return CharacterPosY;
        }

        public double GetCharacterWidth(double CharacterWidth)
        { 
            return CharacterWidth; 
        }

        public double GetCharacterHeight(double CharacterHeight)
        {
            return CharacterHeight;
        }

        public void SetCharacterColor(double r, double g, double b, double a) 
        { 

        }

        public bool CheckCollision(double W1, double W2, double H1, double H2)
        {
            return false;
        }
    }
}
