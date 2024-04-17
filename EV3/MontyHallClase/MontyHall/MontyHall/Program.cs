namespace MontyHall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MontyHallGame game = new MontyHallGame();
            game.Exec();

            //Contest contest = new Contest();
            //Console.WriteLine("Bienvenido al juego Monty Hall");
            //Console.WriteLine("Elija una puerta: 1, 2 o 3");
            //int doorSelected1 = int.Parse(Console.ReadLine());

            //contest.ChooseDoor(doorSelected1);
            //Console.WriteLine("Ha seleccionado la puerta " + doorSelected1);

            //contest.OfferPresentador(contest);
            //Console.WriteLine("El presentador te ofrece cambiar tu puerta por otra, ¿aceptas? (s/n)");
            //string response = Console.ReadLine();

            //if (response.ToLower() == "s")
            //{
            //    Console.WriteLine("Muy bien, entonces elige una de las dos puertas que no elegiste antes");
            //    int doorSelected2 = int.Parse(Console.ReadLine());
            //    contest.ChooseDoor(doorSelected2);

            //    Door selectedDoor = contest.GetSelectedDoor();
            //    Door newSelectedDoor = contest.GetDoorByNumber(doorSelected2);

            //    contest.SwitchDoor(selectedDoor, newSelectedDoor);

            //    string doorContent = contest.GetDoorContent(doorSelected2, contest.GetSelectedDoor().DoorNumber);

            //    Console.WriteLine("El jugador ha cambiado a la puerta número " + newSelectedDoor);
            //    Console.WriteLine("Detrás de la puerta seleccionada había " + doorContent);
            //}
            //else if (response.ToLower() == "n")
            //{
            //    Door selectedDoor = contest.GetSelectedDoor();
            //    string doorContent = contest.GetDoorContent(selectedDoor.DoorNumber, contest.GetSelectedDoor().DoorNumber);

            //    Console.WriteLine("Muy bien, entonces te quedarás con la misma puerta " + selectedDoor.DoorNumber);
            //    Console.WriteLine("Detrás de la puerta seleccionada había " + doorContent);
            //}

            //if (contest.GetSelectedDoor() == null)
            //{
            //    if (contest.GetSelectedDoor().Type == DoorType.CAR)
            //        Console.WriteLine("¡Felicidades, has ganado el premio!");
            //    else if (contest.GetSelectedDoor().Type == DoorType.GOAT)
            //        Console.WriteLine("Lo siento, has perdido el juego");
            //}


        }
    }
}






