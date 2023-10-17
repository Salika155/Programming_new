using UDK;

namespace ProyectoPintar
{
    internal class Program
    {
        public class Character
        {
            public double x;
            public double y;
            public double red, green, blue, alpha;

        }

        public class MiJuego : UDK.IGameDelegate

        {
            List<Character> character = new List<Character>();

            public void OnAnimate(GameDelegateEvent gameEvent)
            {
                for (int i = 0; i < character.Count; i++)
                {
                    Character c = character[i];
                    c.x = c.x + Utils.GetRandom(-0.01, 0.01);
                    c.y = c.y + Utils.GetRandom(-0.01, 0.01);
                }
            }

            public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
            {
                canvas.Clear(0.0, 0.0, 0.0, 1.0);
                canvas.Camera.SetRectangle(0.0, 0.0, 10.0, 10.0);


                for (int i = 0; i < character.Count; i++)
                {
                    Character c = character[i];
                    canvas.FillShader.SetColor(c.red, c.green, c.blue, c.alpha);
                    canvas.DrawRectangle(c.x, c.y, 2.0, 2.0);
                    
                }
            }

            public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
            {
                if (keyboard.IsKeyDown(Keys.Right))
                {
                    character[0].x += 0.0007;
                }
                if (keyboard.IsKeyDown(Keys.Left))
                {
                    character[0].x -= 0.0007;
                }
                if (keyboard.IsKeyDown(Keys.Up))
                {
                    character[0].y += 0.0007;
                }
                if (keyboard.IsKeyDown(Keys.Down))
                {
                    character[0].y -= 0.0007;
                }
            }

            public void OnLoad(GameDelegateEvent gameEvent)
            {

                Character pj1 = new Character();
                
                pj1.red = 1.0;
                pj1.green = 0.0;
                pj1.blue = 0.0;
                pj1.alpha = 1.0;
                character.Add(pj1);

                Character pj2 = new Character();
                
                pj2.red = 0.0;
                pj2.green = 0.0;
                pj2.blue = 1.0;
                pj2.alpha = 1.0;
                character.Add(pj2);

                Character pj3 = new Character();
               
                pj3.red = 0.0;
                pj3.green = 1.0;
                pj3.blue = 0.0;
                pj3.alpha = 1.0;
                character.Add(pj3);

                Character pj4 = new Character();
                
                pj4.red = 1.0;
                pj4.green = 0.0;
                pj4.blue = 0.0;
                pj4.alpha = 1.0;
                character.Add(pj4);

            }

            public void OnUnload(GameDelegateEvent gameEvent)
            {
                
            }
        }

        static void Main(string[] args)
        {
            MiJuego juego = new MiJuego();
            UDK.Game.Launch(juego);
           
        }
    }
}