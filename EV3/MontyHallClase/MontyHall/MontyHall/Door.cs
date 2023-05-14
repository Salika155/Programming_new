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
        public bool HasPrize { get; internal set; }
        public bool IsOpen { get; set; }

        public Door(int DoorNumber)
        {
            this.DoorNumber = DoorNumber;
            this.IsSelected = false;
            Type = DoorType.GOAT;
            this.HasPrize = true;
            this.IsOpen = true;
        }

        public Door() 
        { 

        }

        /// <summary>
        /// Coloca el premio en una de las puertas
        /// </summary>
        public void SetPrize()
        {
            Type = DoorType.CAR;
        }
    }
}
