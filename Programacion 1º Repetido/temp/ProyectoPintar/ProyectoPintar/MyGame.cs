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
        List<Character> character = new List<Character>();

        public void CreateCharacters(int characterCount)
        {
            Character pj = new Character();
            character.Add(pj);
            pj.red = 1.0;
            pj.green = 1.0;
            pj.blue = 1.0;
            pj.alpha = 1.0;
        }

        public void OnAnimate(GameDelegateEvent gameEvent)
        {
            for (int i = 0; i < character.Count; i++)
            {
                Character c = character[i];
                c.x = c.x + Utils.GetRandom(-0.005, 0.005);
                c.y = c.y + Utils.GetRandom(-0.005, 0.005);
            }
        }

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            canvas.Clear(1.0, 1.0, 1.0, 1.0);
            canvas.Camera.SetRectangle(2.0, 0.0, 20.0, 20.0);

            for (int i = 0; i < character.Count; i++)
            {
                Character ch = this.character[i];
                ch.Draw(canvas);
            }
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            if (keyboard.IsKeyDown(Keys.Right))
            {
                this.character[0].x += 0.0007;
            }
            if (keyboard.IsKeyDown(Keys.Left))
            {
                this.character[0].x -= 0.0007;
            }
            if (keyboard.IsKeyDown(Keys.Up))
            {
                this.character[0].y += 0.0007;
            }
            if (keyboard.IsKeyDown(Keys.Down))
            {
                this.character[0].y -= 0.0007;
            }
        }

        public void OnLoad(GameDelegateEvent gameEvent)
        {
            character = new List<Character>();
            CreateCharacters(10);

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Character pj = new Character();
                pj.red = random.NextDouble();
                pj.green = random.NextDouble();
                pj.blue = random.NextDouble();
                pj.alpha = 1.0;
                character.Add(pj);
            }

            //Character pj2 = new Character();

            //pj2.red = 0.0;
            //pj2.green = 0.0;
            //pj2.blue = 1.0;
            //pj2.alpha = 1.0;
            //character.Add(pj2);

            //Character pj3 = new Character();

            //pj3.red = 0.0;
            //pj3.green = 1.0;
            //pj3.blue = 0.0;
            //pj3.alpha = 1.0;
            //character.Add(pj3);

            //Character pj4 = new Character();

            //pj4.red = 1.0;
            //pj4.green = 0.0;
            //pj4.blue = 0.0;
            //pj4.alpha = 1.0;
            //character.Add(pj4);
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {

        }

    }
}
