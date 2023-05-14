
using UDK;
using BuscaminasBiblio;
using BuscaminasApp;
using Buscaminas;

namespace Buscaminas
{
    public class MineSweeper : IGameDelegate
    {
        IFontFace? fontFace;
        IBoard? board;
        int tickCount = 0;

        List<Position> openCells = new List<Position>();
        
        void IGameDelegate.OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            IBoard board = new Board1();
            int cellCountWith = 10;
            int cellCountHeigh = 10;


            var rect = new rect2d_f64(0.0, 0.0, cellCountWith, cellCountHeigh);

            canvas.Clear(new rgba_f64(0.9, 0.9, 0.9, 1.0));
            canvas.Camera.SetRect(rect, true);

            canvas.FillShader.SetColor(new rgba_f64(0.8, 0.8, 0.8, 1.0));
            canvas.Transform.SetTranslation(0, 0);
            canvas.DrawRectangle(rect);

            paintCells(canvas, cellCountHeigh, cellCountWith);
            
            rgba_f64 PickColor(int x, int y, IBoard board)
            {
                if (board.IsOpen(x, y))
                {
                    if (board.IsBombAt(x, y))
                        return new rgba_f64(0.5, 0, 0.1, 1);
                    return new rgba_f64(0.3, 0.3, 0.3, 1);
                }
                if (board.IsFlagAt(x, y))
                    return new rgba_f64(0.2, 0.7, 0, 1);
                return new rgba_f64(1, 0.5, 0.2, 1);
            }

            void RenderCells(ICanvas canvas, IBoard board)
            {
                for (int i = 0; i < board.GetWidth(); i++)
                {
                    for (int j = 0; j < board.GetHeight(); j++)
                    {
                        canvas.FillShader.SetColor(PickColor(i, j, board));
                        canvas.Transform.SetTranslation(i, j);
                        canvas.DrawRectangle(new rect2d_f64(0.1, 0.1, 0.8, 0.8));
                    }
                }
            }
        }

        private void paintCells(ICanvas canvas, int cellCountWith, int cellCountHeigh)
        {
            rect2d_f64 rect2D_F64 = new rect2d_f64(0.5, 0.5, 0.5, 1.0);

           for (int y = 0; y < cellCountHeigh; y++)
           {
                for (int x = 0; x < cellCountWith; x++)
                {
                    var cellRect = new rect2d_f64(0.1, 0.1, 0.8, 0.8);
                    

                    canvas.FillShader.SetColor(new rgba_f64(0.2, 0.2, 0.2, 1.0));
                    canvas.Transform.SetTranslation(x, y);
                    canvas.DrawRectangle(cellRect);
                    
                    canvas.FillShader.SetColor(new rgba_f64(1.0, 0.1, 0.5, 1.0));
                    canvas.Transform.Translate(0.1, 0.3);
                    
                    canvas.DrawText(new vec2d_f64(0.3, 0.0), "0", fontFace, new TextMode() { height = 0.6, bottomCoords = false }); 
                }
           }
        }

        void IGameDelegate.OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            var pos = gameEvent.coordinateConversor.ViewToWorld(mouse.X, mouse.Y);
            if (mouse.IsDown(MouseButton.Left))
            {
                tickCount++;

                int casillaX = (int)pos.x;
                int casillaY = (int)pos.y;
                //casillaY = board.GetHeight() - casillaY - 1;
                if (tickCount ==1)
                {
                    Board1.Equals(keyboard, tickCount);
                }
            }

            pos = gameEvent.coordinateConversor.ViewToWorld(mouse.X, mouse.Y);
            if (mouse.IsDown(MouseButton.Right))
            {
                Console.WriteLine();
                int casillaX = (int)pos.x;
                int casillaY = (int)pos.y;
            }
        }

        void IGameDelegate.OnLoad(GameDelegateEvent gameEvent)
        {
            fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/ArialCE.ttf"))?.CreateFontFace(64.0);
        }

        void IGameDelegate.OnUnload(GameDelegateEvent gameEvent)
        {
           
        }
    }
}
