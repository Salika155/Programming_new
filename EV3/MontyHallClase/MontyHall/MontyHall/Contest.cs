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
    public enum DoorType
    {
        CAR, GOAT
    }

    /// <summary>
    /// Concurso de Monty Hall
    /// </summary>
    public class Contest
    {
        public static List<Door> doors = new List<Door>();
        public static Random random = new Random();

        public Contest()
        {
            Init();
        }
        /// <summary>
        /// Genera las 3 puertas
        /// </summary>
        private void Init()
        {
            for (int i = 1; i <= 3; i++)
            {
                doors.Add(new Door(i));
            }
        }
        /// <summary>
        /// Funcion que permite al concursante elegir una puerta
        /// </summary>
        /// <param name="doorNumber"></param>
        //Concursante elige una puerta
        public void ChooseDoor(int doorNumber)
        {
            foreach (var door in doors)
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
            foreach(var door in doors) 
            {
                if (door.IsSelected && door.HasPrize)
                {
                    return 1;
                }
            }
            return 0;
        }
    
            
            /// <summary>
            /// El presentador tras la primera eleccion le ofrece la posibilidad de cambiar de puerta
            /// </summary>
        public void OfferPresentador()
        {
            foreach (var door in doors)
            {
                if (door.IsSelected && door.Type == DoorType.GOAT)
                {
                    door.IsOpen = true; // El presentador abre la puerta que tiene una cabra
                    break;
                }
            }
        }
    }
}
