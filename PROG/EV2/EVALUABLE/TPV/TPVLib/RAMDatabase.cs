
namespace TPVLib
{
    internal class RAMDatabase : IDatabase
    {
        private Dictionary<long, Product> _products = new Dictionary<long, Product>();
        public int ProductCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new Exception("no se puede añadir");
            }
            
            RAMDatabase db = new RAMDatabase
            {
                ProductCount = 1
            };

            db.AddProduct(product);

        }

        public void AddTicketHeader(TicketHeader header)
        {
            if (header == null)
            {
                throw new ArgumentException("Ticket must have a header and a body");
            }

            TicketHeader newTicketHeader = new TicketHeader
            {
                Id = header.Id,
                Barcode = header.Barcode,
            };
        }

        public void AddTicketLine(TicketLine line)
        {
            if (line == null)
            {
                throw new ArgumentException("Ticket must have a header and a body");
            }

            TicketLine newTicketLine = new TicketLine
            {
                Details = line.Details,
                Quantity = line.Quantity,
                Product = line.Product,
            };
        }

        //public RAMDatabase? GetProduct(long id)
        //{
        //    foreach (var entry in _products)
        //    {
        //        long key = entry.Key;
        //        Product value = entry.Value;
        //        if (key == id)
        //        {
        //            return value.Clone();
        //        }
        //    }
        //}

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

        Product? IDatabase.GetProduct(long id)
        {
            throw new NotImplementedException();
        }
    }
}