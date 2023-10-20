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

       
        public void DrawCharacters(ICanvas canvas, List<Character> character)
        {
            foreach(Character c in character) 
            {
                canvas.FillShader.SetColor(c.red, c.green, c.blue, c.alpha);
                canvas.DrawRectangle(c.x, c.y, 1.5, 1.5);
            }
            
        }

        public List<Character> GetCharacters()
        {
            return character;
        }

        //internal void DrawCharacters()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
