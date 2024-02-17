using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVLib.implementations;

namespace TPVLib
{
    public class TicketBody
    {
        public TicketLine[] Lines { get; set; }

        public void AddLine(TicketLine line)
        {
            throw new NotImplementedException();
        }
    }
}
