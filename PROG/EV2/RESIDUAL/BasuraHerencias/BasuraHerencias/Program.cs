namespace BasuraHerencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rect2D rect = new Rect2D();
            //rect.GetArea();

            IShape rect = new Rect2D();

            if(rect is Rect2D)
            {
                rect = (Rect2D)rect;
            }
            rect.GetArea();
        }
    }
}