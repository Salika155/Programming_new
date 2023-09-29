using System.Runtime.CompilerServices;

namespace ClasesDelfin
{
    public class Program
    {
        static void Main(string[] args)
        {
            Delfin d1;
            Delfin d2;

            d1 = new Delfin(1000, 8000);
            d1.size = 140.0;
            //d1.life = 30.0
            d1.name = "Eustaquio";
            d1.color = ColorType.BLACK;


            d2 = new Delfin(1000, 8000);
            d2.size = 60.0;
            //d2.life = 50.0
            d2.name = "Parkour";
            d2.color = ColorType.WHITE;

            Delfin d3;
            d3 = d1;
            //d3.life = 80.0
            //crear proyecto nuevo y empezamos a hacer esto

            //preguntar porcentaje vida delfin
            //crear variable para almacenar vida y preguntarle a la funcion para obtener esa vida.

            double l;
            l = d1.GetLifePercent();
            double l2;
            l2 = d2.GetLifePercent();

            //preguntar si delfin esta vivo
            bool b1;
            b1 = d1.IsAlive();

            //d1.life = 100.0;

            d1.SetLife1(30.0);
            Console.WriteLine(d1.GetLife());

            d2.SetLife2(50.0);

            d3.SetLife3(80.0);




        }
    }
}