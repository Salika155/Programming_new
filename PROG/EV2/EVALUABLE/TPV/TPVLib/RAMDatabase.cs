
namespace TPVLib
{
    internal class RAMDatabase : IDatabase
    {
        public int ProductCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public long AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void AddTicketHeader(TicketHeader header)
        {
            throw new NotImplementedException();
        }

        public void AddTicketLine(TicketLine line)
        {
            throw new NotImplementedException();
        }

        public Product? GetProduct(long id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts(int offset, int limit)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(long id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductWithId(long id, Product product)
        {
            throw new NotImplementedException();
        }

        void IDatabase.AddProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}