using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVLib.implementations;

namespace TPVLib
{
    public class TicketLine
    {
        public string? Details { get; set; }
        public double Quantity { get; set; }
        public Product Product { get; set; }
    }
}
