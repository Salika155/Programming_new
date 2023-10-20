using DAM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tom_Jerry
{
    internal class Chasey : DAM.IGameDelegate
    {
        float blue = 0.0f;
        float x = 0.0f;
         
        
        Character cat;
        Character mouse;

      
        public void OnDraw(IAssetManager manager, IWindow window, ICanvas canvas)
        {
            canvas.SetCamera(-1.0f, -1.0f, 1.0f, 1.0f, true);
            canvas.Clear(0.0f, 0.0f, blue, 1.0f);
            this.blue += 0.001f;


            double time = 0.0;
            double asin = Math.Sin(time);
            double parp;

            canvas.FillRectangle(x, -0.2f, 0.4f, 0.4f, 1.0f, 0.0f, 0.0f, 0.0f);
            this.x += 0.001f;

            float arw = 10;
            float ar = ((float)window.Width) / (float)window.Height;
            float arh = arw / ar;


            canvas.FillRectangle(cat.x - (cat.width / 2), cat.y - (cat.width / 2), cat.width, cat.height, cat.r, cat.g, cat.b, cat.a);

            canvas.FillRectangle(mouse.x - (mouse.width / 2), mouse.y - (mouse.width / 2), mouse.width, mouse.height, mouse.r, mouse.g, mouse.b, mouse.a);

            cat.Render(canvas /*arw, arh*/);
            mouse.Render(canvas/* arw, arh*/);


        }

        public void OnKeyboard(IAssetManager manager, IWindow window, IKeyboard keyboard, IMouse mouse)

        {
            if (keyboard.IsKeyDown(Keys.Right))
                this.mouse.x += 0.001f;
            if (keyboard.IsKeyDown(Keys.Left))
                this.mouse.x -= 0.001f;
            if (keyboard.IsKeyDown(Keys.Down))
                this.mouse.y -= 0.001f;
            if (keyboard.IsKeyDown(Keys.Up))
                this.mouse.y += 0.001f;

            if (keyboard.IsKeyDown(Keys.D))
                this.cat.x += 0.0001f;
            if (keyboard.IsKeyDown(Keys.A))
                this.cat.x -= 0.0001f;
            if (keyboard.IsKeyDown(Keys.W))
                this.cat.y += 0.0001f;
            if (keyboard.IsKeyDown(Keys.S))
                this.cat.y -= 0.0001f;
            if (keyboard.IsKeyDown(Keys.Escape))
                window.Close();

            //if (this.cat.x > 1.0f - (this.cat.width / 2))
            //    this.cat.x = 1.0f;
            //if (this.cat.x < -1.0f - (this.cat.width / 2))
            //    this.cat.x = 1.0f;
            //if (this.cat.x > 1.0f - (this.cat.width / 2))
            //    this.cat.x = -1.0f;
            //if (this.cat.x < 1.0f - (this.cat.height / 2))
            //    this.cat.x = -1.0f;

        }

        public void OnLoad(IAssetManager manager, IWindow iwindow)


            
    //cargar imagen
    {
            //Window.ToggleFullScreen();
            cat = new Character();
            {
                this.cat.image = manager.LoadImage("resources/catt.png");
                cat.x = 0.0f;
                cat.y = 0.0f;
                cat.width = 0.3f;
                cat.height = 0.3f;
                cat.r = 0.3f;
                cat.g = 0.3f;
                cat.b = 0.3f;
                cat.a = 1.0f;
                
            }    

            
            mouse = new Character();
            {
                this.mouse.image = manager.LoadImage("resources/mousse.png");
                mouse.x = 0.0f;
                mouse.y = 0.0f;
                mouse.width = 0.1f;
                mouse.height = 0.1f;
                mouse.r = 0.5f;
                mouse.g = 0.1f;
                mouse.b = 0.2f;
                mouse.a = 1.0f;
               
            }

            
        }


        public void OnUnload(IAssetManager manager, IWindow window)
        {
           
        }
    }
}
