using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
   
    public class MontyHallGame
    {
        private List<Door> doors;
        private Random random;
        private Door? selectedDoor;

        public MontyHallGame()
        {
            doors = new List<Door>();
            random = new Random();
        }

        public void Exec()
        {
            Init();
            PlayerChooseDoor();
            RevealDoor();
            OfferSwitchDoor();
            ResolveGame();
        }

        private void Init()
        {
            doors.Clear();
            for (int i = 1; i <= 3; i++)
            {
                Door door = new Door(i);
                doors.Add(door);
            }

            int winningDoorIndex = random.Next(0, 3);
            doors[winningDoorIndex].SetPrize(DoorType.CAR);
        }

        private void PlayerChooseDoor()
        {
            // Simular que el jugador elige una puerta
            Console.WriteLine("Elige una puerta (1, 2 o 3): ");
            int chosenDoorNumber = int.Parse(Console.ReadLine());

            foreach (Door door in doors)
            {
                if (door.DoorNumber == chosenDoorNumber)
                {
                    selectedDoor = door;
                    selectedDoor.IsSelected = true;
                    break;
                }
            }
        }

        //repasar esto
        public void RevealDoor()
        {
            //Console.WriteLine("Veamos qué se oculta tras una de las puertas...");
            //Door goatDoor = null;
            //foreach (Door door in doors)
            //{
            //    if (!door.IsSelected && door.Type == DoorType.GOAT && !door.IsOpen)
            //    {
            //        goatDoor = door;
            //        goatDoor.IsOpen = true;
            //        Console.WriteLine($"Detrás de la puerta {goatDoor.DoorNumber} había una cabra.");
            //        break;
            //    }
            //}
            Console.WriteLine("Veamos qué se oculta tras una de las puertas...");

            Door goatDoor = null;
            foreach (Door door in doors)
            {
                if (!door.IsSelected && door.Type == DoorType.GOAT && !door.IsOpen)
                {
                    goatDoor = door;
                    goatDoor.IsOpen = true;
                    Console.WriteLine($"Detrás de la puerta {goatDoor.DoorNumber} había una cabra.");
                    break;
                }
            }

        }

        //repasar esto
        public void OfferSwitchDoor()
        {
            #region Old code
            //foreach (Door door in doors)
            //{
            //    if (!door.IsSelected && door.Type == DoorType.GOAT)
            //    {
            //        door.IsOpen = true;
            //        return door.Type == DoorType.CAR ? GameResult.WIN : GameResult.LOOSE;
            //    }
            //}
            //return GameResult.LOOSE; // Should never reach here ideally

            // Ofrecer cambiar de puerta
            //Console.WriteLine("¿Quieres cambiar de puerta? (Sí/No): ");
            //string switchChoice = Console.ReadLine();

            //if (switchChoice.ToLower() == "sí")
            //{
            //    selectedDoor.IsSelected = false;
            //    selectedDoor = doors.Find(door => door != selectedDoor && !door.IsOpen);
            //    selectedDoor.IsSelected = true;
            //}
            #endregion

            Console.WriteLine("¿Quieres cambiar de puerta? (Sí/No): ");
            string switchChoice = Console.ReadLine();

            if (switchChoice.ToLower() == "sí")
            {
                selectedDoor.IsSelected = false;
                foreach (Door door in doors)
                {
                    if (door != selectedDoor && !door.IsOpen)
                    {
                        selectedDoor = door;
                        selectedDoor.IsSelected = true;
                        break;
                    }
                }
                Console.WriteLine($"El jugador ha cambiado a la puerta {selectedDoor.DoorNumber}");
            }
        }

        //repasar esto
        private void ResolveGame()
        {
            // Verificar si el jugador ganó o perdió
            GameResult result = selectedDoor.Type == DoorType.CAR ? GameResult.WIN : GameResult.LOOSE;
            Console.WriteLine($"El jugador ha {(result == GameResult.WIN ? "ganado" : "perdido")} el premio.");

            // Mostrar en qué puerta estaba el premio
            foreach (Door door in doors)
            {
                if (door.Type == DoorType.CAR)
                {
                    Console.WriteLine($"El premio estaba detrás de la puerta {door.DoorNumber}.");
                    break;
                }
            }

            if (result == GameResult.WIN)
            {
                Console.WriteLine("¡Felicidades, has ganado el premio!");
            }
            else
            {
                Door goatDoor;
                foreach (Door door in doors)
                {
                    if (!door.IsSelected && door.Type == DoorType.GOAT)
                    {
                        goatDoor = door;
                        goatDoor.IsOpen = true;
                        Console.WriteLine($"Detrás de la puerta {goatDoor.DoorNumber} había una cabra.");
                        break;
                    }
                }
                
            }
        }

    }
}

