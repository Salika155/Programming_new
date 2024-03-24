using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVLib.implementations;

namespace TPVLib
{
    public interface IDatabase
    {
        //void BeginTransaction();
        //void CommitTransaction();
        //void RollbackTransaction();

        static IDatabase CreateNewDatabase(IDatabase database)
        {
            return new RAMDatabase();
        }

        long AddProduct(Product product);
        long AddTicket(TicketHeader header);
        //void AddLineToTicketWithId(long ticketid, TicketLine line);
        void AddTicketLine(TicketLine line);
        //void AddTicketBody(TicketBody body);
        //body no existe nada mas que para trabajarlo
        void RemoveProduct(long id);
        Product? GetProduct(long id);
        void UpdateProductWithId(long id, Product product);
        List<Product> GetProducts(int offset, int limit);

        void RemoveProduct(Product product)
        {
            if (product != null)
            {
                RemoveProduct(product.Id);
            }
        }
    }
}
