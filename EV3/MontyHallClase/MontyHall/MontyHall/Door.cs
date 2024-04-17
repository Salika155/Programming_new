using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
    public class Door
    {
        
        public DoorType Type { get; set; }
        public bool IsSelected { get; set; }
        public int DoorNumber { get; set; }
        //public bool HasPrize { get; set; }
        public bool IsOpen { get; set; }

        public Door(int doorNumber)
        {
            DoorNumber = doorNumber;
            IsSelected = false;
            IsOpen = true;
            SetPrize(DoorType.CAR);
            
        }

        public Door() 
        { 

        }

        /// <summary>
        /// Coloca el premio en una de las puertas
        /// </summary>
        public void SetPrize(DoorType car)
        {
            int randomNumber = Utils.GetRandomNumber(0, 2);
            if (randomNumber == 0) 
            {
                Type = DoorType.CAR;
                
            }
            else 
            {
                Type = DoorType.GOAT;
            }
        }
    }
}
