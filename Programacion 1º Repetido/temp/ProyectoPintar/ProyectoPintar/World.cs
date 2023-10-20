using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDK;

namespace ProyectoPintar
{
    public class World
    {
        double width;
        double height;

        private List<Character> character = new List<Character>();
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
            //mejor un for
            for (int i = 0; i < character.Count; i++)
            {
                Character c = character[i];
                canvas.FillShader.SetColor(c.red, c.green, c.blue, c.alpha);
                canvas.DrawRectangle(c.x, c.y, 1.5, 1.5);
   
            }
        }

       public void DrawWorld(ICanvas canvas, World world)
        {

        }

        
    }
}
