using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVLib
{
    public class RAMTicket
    {
        //Product[] products = new Product[0];

        public TicketHeader? Header { get; set; } = new TicketHeader();
        public TicketBody Body { get; set; } = new TicketBody();
        public double TotalPrize { get; set; }

        #region comentado
        //public RAMTicket AddTicket(TicketHeader header, TicketBody body)
        //{
        //    if (header == null || body == null)
        //    {
        //        throw new ArgumentException("Ticket must have a header and a body");
        //    }

        //    RAMTicket newTicket = new RAMTicket
        //    {
        //        Header = header,
        //        Body = new List<TicketBody> { body }
        //    };

        //    // Calcular el precio total del ticket
        //    double totalPrize = 0;
        //    foreach (var line in body.Lines)
        //    {
        //        // 1 prd 1 cant
        //        totalPrize += line.Product.Price * line.Quantity;
        //    }

        //    // Asignar el precio total al ticket creado
        //    newTicket.TotalPrize = totalPrize;

        //    return newTicket;
        //}


        //public RAMTicket? GetTicket(long id)
        //{
        //    for (int i = 0; i < products.Length; i++)
        //    {
        //        if (products[i].Id == id)
        //        {
        //            return this;
        //        }
        //    }
        //    return null;
        //}

        //public List<RAMTicket> GetTickets(int offset, int limit)
        //{
        //    if (offset < 0 || limit < 0)
        //    {
        //        throw new ArgumentException("Offset and limit must be greater than 0");
        //    }
        //    for (int i = 0; i < products.Length; i++)
        //    {
        //        if (i >= offset && i < limit)
        //        {
        //            return new List<RAMTicket> { this };
        //        }
        //    }
        //    return new List<RAMTicket>();
        //}

        //public void RemoveTicket(long id)
        //{
        //    for (int i = 0; i < products.Length; i++)
        //    {
        //        if (products[i].Id == id)
        //        {
        //            RemoveTicket(products[i].Id);

        //        }
        //    }
        //}

        //public void UpdateTicketWithId(long id, RAMTicket ticket)
        //{
        //    for (int i = 0; i < products.Length; i++)
        //    {
        //        if (products[i].Id == id)
        //        {

        //        }
        //    }
        //}
        #endregion
    }
}
