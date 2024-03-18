

namespace Simulacion_Autos_Locos
{
    public class Program
    {
        static void Main(string[] args)
        {
            //dejo la creacion de racers al metodo CreateRace
            IRace race = Race.CreateRace();
            Random random = new Random();
           
            //Inserto los corredores
            race.AddObject(new GlamourCar("Penelope"), 0.0);
            race.AddObject(new TroglodyteCar("Pietro", "Roco"), 0.0);
            race.AddObject(new WoodCar("Brutus", "Listus"), 0.0);
            race.AddObject(new PierreCar("Pierre Nodoyuna", "Patán"), 0.0);

            race.AddObject(new Rock(25), Utils.GetRandomInt(0, 1000));
            race.AddObject(new Puddle(15), Utils.GetRandomInt(0, 1000));
            race.AddObject(new Bomb(20, Utils.GetRandomInt(0, 1000)));


            //race.VisitDrivers(obj =>
            //{
            //    Driver d = (Driver)obj;
            //});

            //inicializo la carrera
            race.Init(1000);

            while (race.GetWinner() == null)
            {
                race.SimulateStep();
            }

            RaceObject winner = race.GetWinner();

            if (winner != null)
            {
                Console.WriteLine("El ganador es: " + winner.GetName() + "");
            }
            else
            {
                Console.WriteLine("No hay ganador");
            }

        //enlace de una carrera de autos locos que encontre:
        //https://www.youtube.com/watch?v=gNTol7swS00&ab_channel=HernanNadal
        }
    }
}
