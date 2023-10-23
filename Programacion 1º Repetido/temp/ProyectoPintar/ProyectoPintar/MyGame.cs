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
        World world;
        List<Character> characters = new List<Character>();

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            world.DrawWorld(canvas);
            for (int i = 0; i < characters.Count; i++) 
            {
                characters[i].Draw(canvas);
            }
            world.DrawCharacters(canvas);

        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {

            if (characters == null)
                return;

            for (int i = 0; i < characters.Count; i++)
            {
                    if (keyboard.IsKeyDown(Keys.Right))
                    {
                        characters[0].MoveCharacterX(0.0007);
                    }
                    if (keyboard.IsKeyDown(Keys.Left))
                    {
                        characters[0].MoveCharacterX(-0.0007);
                    }
                    if (keyboard.IsKeyDown(Keys.Up))
                    {
                        characters[0].MoveCharacterY(0.0007);
                    }
                    if (keyboard.IsKeyDown(Keys.Down))
                    {
                        characters[0].MoveCharacterY(-0.0007);
                    }
            }
        }

        public void OnLoad(GameDelegateEvent gameEvent)
        {
            world = new World();
            
            world.CreateCharacters(6);

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
                Rectangulo r = characters[i].rectangulo;


                if (r != null) 
                {
                    //    if (c.x < 0.0) c.x = 0.0;
                    //    if (c.x > world.width) c.x = world.width;
                    //    if (c.y < 0.0) c.y = 0.0;
                    //    if (c.y > world.height) c.y = world.height;
                }
                r.x = r.x + Utils.GetRandom(-0.005, 0.005);
                r.y = r.y + Utils.GetRandom(-0.005, 0.005);

                
            }

        }
    }
}
