namespace ClasesDelfin
{
    public class Program
    {
        static void Main(string[] args)
        {
            Delfin d1;
            Delfin d2;

            d1 = new Delfin();
            d1.size = 100.0;
            d1.life = 100.0;
            d1.name = "Eustaquio";
            d1.color = ColorType.BLACK;

            d2 = new Delfin();
            d2.size = 20.0;
            d2.life = 30.0;
            d2.name = "Paco";
            d2.color = ColorType.WHITE;

            Delfin d3;
            d3 = d1;
            d3.life = 50.0;
            //crear proyecto nuevo y empezamos a hacer esto
        }
    }
}