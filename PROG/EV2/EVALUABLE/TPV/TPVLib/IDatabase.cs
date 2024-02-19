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
        int ProductCount { get; set; }
        static IDatabase CreateNewDatabase()
        {
            return new RAMDatabase();
        }

        void AddProduct(Product product);
        void AddTicketHeader(TicketHeader header);
        void AddTicketLine(TicketLine line);


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
