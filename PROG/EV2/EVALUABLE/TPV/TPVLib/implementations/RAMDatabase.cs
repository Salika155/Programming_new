namespace TPVLib.implementations
{
    public class RAMDatabase : IDatabase
    {
        private Dictionary<long, Product> _products = new Dictionary<long, Product>();

        private IDatabase _db;

        public RAMDatabase()
        {
        }

        public RAMDatabase(IDatabase db)
        {
            _db = db;
        }


        public int ProductCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddLineToTicketWithId(long ticketid, TicketLine line)
        {
            if (line == null)
            {
                throw new ArgumentException("Ticket must have a header and a body");
            }

            
            
        }

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new Exception("no se puede añadir");
            }

            //RAMDatabase db = new()
            //{
            //    ProductCount = 1
            //};

            _db.AddProduct(product);

        }

        

        public long AddTicket(TicketHeader header)
        {
            if (header == null)
            {
                throw new Exception("no se puede añadir");
            }

            TicketHeader newTicketHeader = new TicketHeader
            {
                Id = header.Id,
                Barcode = header.Barcode,
            };

            return newTicketHeader.Id;
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
            if (offset < 0 || limit < 0)
            {
                throw new ArgumentException("Offset and limit must be greater than 0");
            }
            for (int i = 0; i < _products.Count; i++)
            {
                if (i >= offset && i < limit)
                {
                    return new List<Product>(_products.Values);
                }
            }
            return new List<Product>();
        }

        public void RemoveProduct(long id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El id no es valido");
            }
            _products.Remove(id);
        }

        public void UpdateProductWithId(long id, Product product)
        {
           
        }

        void IDatabase.AddProduct(Product product)
        {
            

        }

        Product? IDatabase.GetProduct(long id)
        {
            throw new NotImplementedException();
        }
    }
}