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
        private double width = 40.0;
        private double height = 25.0;
        private Rectangulo? worldMap;
        

        private List<Character> character = new List<Character>();
        
        Random random= new Random();

        public void CreateWorld(double width, double height)
        {
            worldMap = new Rectangulo();
            worldMap.SetPositionX(0);
            worldMap.SetPositionY(0);
            worldMap.SetWorldWidth(width);
            worldMap.SetWorldHeight(height);
        }


        public void CreateCharacters(int characterCount)
        {
            for (int i = 0; i < characterCount; i++)
            {
                Character pj = new  Character();
                double randomValue = Utils.GetRandom();

                if (randomValue <= 0.33)
                {
                    pj.red= 1.0;
                    pj.blue = 0.0;
                    pj.green = 0.0;
                }
                else if (randomValue <= 0.66 && randomValue > 0.33)
                {
                    pj.blue = 1.0;
                    pj.green = 0.0;
                    pj.red = 0.0;
                }
                else if (randomValue <= 1 && randomValue > 0.66)
                {
                    pj.green= 1.0;
                    pj.red = 0.0;
                    pj.blue = 0.0;
                }

                pj.alpha = 1.0;
                Rectangulo rectangulo = new Rectangulo();
                
                rectangulo.x = Utils.GetRandom(0, width);  
                rectangulo.y = Utils.GetRandom(0, height);
                pj.rectangulo= rectangulo;
                character.Add(pj);
            }
            
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
                Character c = character[i];
                canvas.FillShader.SetColor(c.red, c.green, c.blue, c.alpha);
                canvas.DrawRectangle(c.rectangulo.x, c.rectangulo.y, 1.5, 1.5);
            }
        }

       public void DrawWorld(ICanvas canvas)
        {
            canvas.Clear(1.0, 1.0, 1.0, 1.0);
            canvas.Camera.SetRectangle(0.0, 0.0, width, height);
            canvas.FillShader.SetColor(0.5, 0.5, 1.0, 1.0);
            canvas.DrawRectangle(0.0, 0.0, width, height);
        }

        public void SetWorldBounds(double x, double y, double width, double height)
        {
            worldMap = new Rectangulo();
            worldMap.x = x;
            worldMap.y = y;
            worldMap.width = width;
            worldMap.height = height;
        }


        public double GetWorldSizeX()
        {
            return width;
        }

        public double GetWorldSizeY() 
        {
            return height;
        }

        public void SetWorldWidth(double width)
        {
            this.width = width;
        }

        public void SetWorldHeight(double height)
        {
            this.height = height;
        }

       
    }
}
