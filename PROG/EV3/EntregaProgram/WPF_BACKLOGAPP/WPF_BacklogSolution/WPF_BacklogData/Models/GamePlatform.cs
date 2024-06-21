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
        Playstation4,
        XboxOne,
        NintendoSwitch,
        PS5,
        XboxSeriesX,
        Unknown
    }

    public class GamePlatform
    {
        public int Platform_ID { get; set; }
        public Platform Name_Platform { get; set; }
    }
}
