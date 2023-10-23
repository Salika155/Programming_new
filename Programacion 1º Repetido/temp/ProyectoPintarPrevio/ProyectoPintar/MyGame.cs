using UDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoPintar
{
    internal class MyGame : UDK.IGameDelegate
    {
        World? world;
        List<Character> characters = new List<Character>();

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            world.DrawWorld(canvas);
            world.DrawCharacters(canvas);
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            if (characters == null)
                return;

                if (characters.Count > 0)
                {
                    if (keyboard.IsKeyDown(Keys.Right))
                    {
                        characters[0].x += 0.0007;
                    }
                    if (keyboard.IsKeyDown(Keys.Left))
                    {
                        characters[0].x -= 0.0007;
                    }
                    if (keyboard.IsKeyDown(Keys.Up))
                    {
                        characters[0].y += 0.0007;
                    }
                    if (keyboard.IsKeyDown(Keys.Down))
                    {
                        characters[0].y -= 0.0007;
                    }
                }
        }

        public void OnLoad(GameDelegateEvent gameEvent)
        {
            world = new World();
            world.CreateCharacters(10);

            //Character pj2 = new Character();
            //pj2.red = 0.0;
            //pj2.green = 0.0;
            //pj2.blue = 1.0;
            //pj2.alpha = 1.0;
            //character.Add(pj2);
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {

        }

        public void OnAnimate(GameDelegateEvent gameEvent)
        {
            for (int i = 0; i < characters.Count; i++) 
            {
                Character c = characters[i];

                if (c.rectangle != null) 
                {
                    for (int j = 0; j < characters.Count; j++)
                    {
                        if (i != j)
                        {
                            Character otherCharacter = characters[j];
                            //if (Intersect.CheckCollision(c.x, c.y, c.rectangle.Width, c.rectangle.Height, otherCharacter.x, otherCharacter.y, otherCharacter.rectangle.Width, otherCharacter.rectangle.Height))
                            {
                               
                            }
                        }
                    }
                }
                
                c.x = c.x + Utils.GetRandom(-0.005, 0.005);
                c.y = c.y + Utils.GetRandom(-0.005, 0.005);

            }
        }
    }
}
