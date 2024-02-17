using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVLib.implementations
{
    public class RAMTicket : ITicket
    {
        public TicketHeader? Header { get; set; }
        public List<TicketBody>? Body { get; set; }
        public double TotalPrize { get; set; }

        public RAMTicket AddTicket(TicketHeader header, TicketBody body)
        {
            if (header == null || body == null)
            {
                throw new ArgumentException("Ticket must have a header and a body");
            }

            RAMTicket newTicket = new RAMTicket
            {
                Header = header,
                Body = new List<TicketBody> { body }
            };

            // Calcular el precio total del ticket
            double totalPrize = 0;
            foreach (var line in body.Lines)
            {
                // Asumiendo que cada línea tiene un producto y una cantidad
                totalPrize += line.Product.Price * line.Quantity;
            }

            // Asignar el precio total al ticket creado
            newTicket.TotalPrize = totalPrize;

            // Retornar el nuevo ticket creado
            return newTicket;
        }


        public RAMTicket? GetTicket(long id)
        {
            throw new NotImplementedException();
        }

        public List<RAMTicket> GetTickets(int offset, int limit)
        {
            throw new NotImplementedException();
        }

        public void RemoveTicket(long id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTicketWithId(long id, RAMTicket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
