using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHall
{
    public enum DoorType
    {
        CAR, GOAT
    }
    public static class Contest
    {
        public void Init(int door);
        
        
        public int ContestResult(bool wantsChange)
        {
            if ((wantsChange) == true)
                return != ChooseDoor;
                
                   
        }

            //Concursante elige una puerta
        public int ChooseDoor(List<Door> doors)
        {
            int count = 0;
            for (int i = 1; i < doors.Count; i++);
        }
            //Presentador le ofrece cambiar de puerta

        public int PresentadorDoorChosen(List<Door> doors)
        {
            if (doors.Count == 0)
                ContestResult(false);

        }
            //Presentador abre una puerta que no es
    }
}
