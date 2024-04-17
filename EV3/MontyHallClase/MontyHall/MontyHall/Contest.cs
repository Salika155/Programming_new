using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
    /// <summary>
    /// Enum con los dos tipos de contenido de las puertas
    /// </summary>
    /// 

    public enum GameResult
    {
        WIN, LOOSE
    }
    public enum DoorType
    {
        CAR, GOAT
    }

    /// <summary>
    /// Concurso de Monty Hall
    /// </summary>
    public class Contest
    {
        private List<Door> doorsList;
        private Random _random;
        //private int doorNumber;

        public Contest()
        {
            doorsList = new List<Door>();
            _random = new Random();
            Init();

        }
        /// <summary>
        /// Genera las 3 puertas
        /// </summary>
        /// 

        //public GameResult Execute(bool wasChange)
        //{
        //    Init();
        //    int selectedDoor = random.Next(0, doorsList.Count - 1);

        //    if (doorsList[selectedDoor] == DoorType.GOAT && wasChange)
        //    {
        //        doorsList.RemoveAt(selectedDoor);
        //        int newSelectedDoor = random.Next(0, doorsList.Count - 1);

        //        if (doorsList[newSelectedDoor] == DoorType.GOAT)
        //            return GameResult.LOOSE;
        //        if (doorsList[newSelectedDoor] == DoorType.CAR)
        //            return GameResult.WIN;
        //    }
        //    int presentadorChoiceChange = random.Next(0, doorsList.Count - 1);
        //    if (doorsList[presentadorChoiceChange] == DoorType.CAR)
        //        return GameResult.WIN;
        //    return GameResult.LOOSE;

        //}

        private void Init()
        {
            
            for (int i = 1; i <= 3; i++)
            {
                Door door = new Door(i);
                doorsList.Add(door);
            }

            int winningDoorIndex = Utils.GetRandomNumber(0, 2);
            doorsList[winningDoorIndex].Type = DoorType.CAR;

            //if (winningDoor == i)
            //    {
            //       door.Type = DoorType.CAR;
            //    }
            //    else
            //    {
            //        door.Type = DoorType.GOAT;
            //    }
            //    doorsList.Add(door);
            //}
        }
        /// <summary>
        /// Funcion que permite al concursante elegir una puerta
        /// </summary>
        /// <param name="doorNumber"></param>
        //Concursante elige una puerta
        public void ChooseDoor(int doorNumber)
        {
           foreach (Door door in doorsList)
           {
                if (door.DoorNumber == doorNumber)
                {
                    door.IsSelected = true;
                    break;
                }
           }
        }

        /// <summary>
        /// Funcion que sirve para saber si el concursante gano o no el premio
        /// </summary>
        /// <param name="doors"></param>
        /// <returns></returns>
        public static int ContestResult(List<Door> doors)
        {
            foreach(Door door in doors) 
            {
                if (door.IsSelected && door.Type == DoorType.CAR)
                {
                    return 1;
                }
            }
            return 0;
        }


        /// <summary>
        /// El presentador tras la primera eleccion le ofrece la posibilidad de cambiar de puerta
        /// </summary>

        public void OfferPresentador(Contest contest)
        {
            foreach (Door door in doorsList)
            {
                if (door.IsSelected && door.Type == DoorType.GOAT)
                {
                    door.IsOpen = true; // El presentador abre la puerta que tiene una cabra
                    break;
                }
            }
        }

        public void SwitchDoor(Door selectedDoor, Door newSelectedDoor)
        {
            selectedDoor.IsSelected = false;
            newSelectedDoor.IsSelected = true;
        }

        public Door? GetSelectedDoor()
        {
            foreach (Door door in doorsList)
            {
                if (door.IsSelected)
                {
                    return door;
                }
            }
            return null;
        }

        public string GetDoorContent(int doorNumber)
        {
            foreach (Door door in doorsList)
            {
                if (door.DoorNumber == doorNumber)
                {
                    return door.Type.ToString();
                }
            }
            return "";
        }

        public Door? GetDoorByNumber(int doorNumber)
        {
            foreach (Door door in doorsList)
            {
                if (door.DoorNumber == doorNumber)
                {
                    return door;
                }
            }
            return null;
        }

    }
}
