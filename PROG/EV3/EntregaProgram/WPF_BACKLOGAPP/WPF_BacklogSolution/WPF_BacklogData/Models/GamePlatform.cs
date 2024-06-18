using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_BacklogData.Models
{
    public enum Platform
    {
        PC,
        PS4,
        XboxOne,
        NintendoSwitch,
        PS5,
        XboxSeriesX
    }

    public class GamePlatform
    {
        public int Juego_ID { get; set; }
        public Platform Platform_ID { get; set; }
        public string Name { get; set; }
    }
}
