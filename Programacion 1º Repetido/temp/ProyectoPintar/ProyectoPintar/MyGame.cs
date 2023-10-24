using UDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UDK.IFont;


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
            if (characters == null || characters.Count == 0)
                return;

            Character c = characters[0];

            for (int i = 0; i < characters.Count; i++)
            {
                    if (keyboard.IsKeyDown(Keys.Right))
                    {
                        c.MoveCharacterX(0.0007);
                    }
                    if (keyboard.IsKeyDown(Keys.Left))
                    {
                        c.MoveCharacterX(-0.0007);
                    }
                    if (keyboard.IsKeyDown(Keys.Up))
                    {
                        c.MoveCharacterY(0.0007);
                    }
                    if (keyboard.IsKeyDown(Keys.Down))
                    {
                        c.MoveCharacterY(-0.0007);
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
                Rectangulo r = characters[i].rectangulo;

                if (r != null) 
                {
                    if (r.x < 0.0) r.x = 0.0;
                    if (r.x > world.GetWorldSizeX()) r.x = world.GetWorldSizeX();
                    if (r.y < 0.0) r.y = 0.0;
                    if (r.y > world.GetWorldSizeY()) r.y = world.GetWorldSizeY();
                }
                characters[i].MoveCharacterX(Utils.GetRandom(-0.005, 0.005));
                characters[i].MoveCharacterY(Utils.GetRandom(-0.005, 0.005));
            }
        }
    }
}
