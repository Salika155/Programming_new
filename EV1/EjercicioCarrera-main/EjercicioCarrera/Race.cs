using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCarrera
{
    internal class Race
    {
        public static List<Racer> GenerateRacers()
        {
            List<Racer> racerList = new List<Racer>();
            Racer r1 = new Racer();
            r1.Name = "Pepe";
            r1.position = 0;
            racerList.Add(r1);
            Racer r2 = new Racer();
            r2.Name = "Juan";
            r2.position = 0;
            racerList.Add(r2);
            Racer r3 = new Racer();
            r3.Name = "Antonio";
            r3.position = 0;
            racerList.Add(r3);
            Racer r4 = new Racer();
            r4.Name = "Manuel";
            r4.position = 0;
            racerList.Add(r4);
            return racerList;
        }

        public static void SimulateRace(List<Racer> racerList)
        {
            for (int i = 0; i < racerList.Count; i++)
            {
                Racer r = racerList[i];
                r.SimulatePosition();
            }
        }
        public static Racer Getwinner(List<Racer> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Racer r = list[i];
                if (r.position >= 1000.0)
                    return r;
            }
        }

       

    }
}
