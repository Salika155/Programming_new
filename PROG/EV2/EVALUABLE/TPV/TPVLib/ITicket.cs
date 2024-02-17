using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVLib.implementations;


namespace TPVLib
{
    public interface ITicket
    {

        RAMTicket AddTicket(TicketHeader header, TicketBody body);
        void RemoveTicket(long id);
        RAMTicket? GetTicket(long id);
        void UpdateTicketWithId(long id, RAMTicket ticket);
        List<RAMTicket> GetTickets(int offset, int limit);

        void RemoveTicket(RAMTicket ticket)
        {
            if (ticket != null)
            {
                RemoveTicket(ticket.Header.Id);
            }
            
        }
    }
}
