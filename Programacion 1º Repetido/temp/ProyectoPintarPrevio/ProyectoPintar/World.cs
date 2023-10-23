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
                pj.x = Utils.GetRandom(0, width);  
                pj.y = Utils.GetRandom(0, height);
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
                canvas.DrawRectangle(c.x, c.y, 1.5, 1.5);
                
            }
        }

       public void DrawWorld(ICanvas canvas)
        {
            canvas.Clear(1.0, 1.0, 1.0, 1.0);
            canvas.Camera.SetRectangle(0.0, 0.0, width, height);
            DrawCharacters(canvas);

        }

        public void SetWorldBounds(double x, double y, double width, double height)
        {
            worldBorders = new Rectangle();
        }

        
    }
}
