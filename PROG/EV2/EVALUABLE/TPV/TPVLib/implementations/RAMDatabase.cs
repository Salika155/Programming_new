namespace TPVLib.implementations
{
    public class RAMDatabase : IDatabase
    {
        private Dictionary<long, Product> _products = new Dictionary<long, Product>();
        private long _currentGeneratingId = 1;

        private IDatabase _db;

        public int ProductCount => _products.Count;

        #region comentado
        //public void AddLineToTicketWithId(long ticketid, TicketLine line)
        //{
        //    if (line == null)
        //    {
        //        throw new ArgumentException("Ticket must have a header and a body");
        //    }
        //    TicketLine newTicketLine = new TicketLine
        //    {
        //        Details = line.Details,
        //        Quantity = line.Quantity,
        //        Product = line.Product,
        //    };
        //}
        #endregion

        public long AddProduct(Product product)
        {
            if (product == null)
            {
                throw new Exception("no se puede añadir");
            }
            var cloneProduct = product.Clone();
            cloneProduct.Id = _currentGeneratingId++;
            _products.Add(cloneProduct.Id, cloneProduct);
            return cloneProduct.Id;
        }

        public long AddTicket(TicketHeader header)
        {
            if (header == null)
            {
                throw new ArgumentException("Necesitas un header valido");
            }

            _currentGeneratingId++;
            header.Id = _currentGeneratingId;
            _db.AddTicket(header);
            return header.Id;

            #region comentado
            //try
            //{
            //    _db.BeginTransaction();
            //    long id = _db.AddTicket(TicketHeader Header);
            //    foreach (var line in t.Body.Lines)
            //    {
            //        _database.AddLineToTicketWithId(id, line);
            //    }
            //}
            //catch (Exception e)
            //{
            //    _database.RollbackTransaction();
            //    throw e;
            //}
            //return Id;
            #endregion
        }

        public void AddTicketLine(TicketLine line)
        {
            if (line == null)
            {
                throw new ArgumentException("Ticket must have a header and a body");
            }

            foreach(var entry in _products)
            {
                long key = entry.Key;
                Product value = entry.Value;
                if (key == line.Product.Id)
                {
                    value.Clone();
                }
            }
        }

        #region comentado
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
        #endregion

        public List<Product> GetProducts(int offset, int limit)
        {
            throw new NotImplementedException();
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
            foreach (var kvp in _products)
            {
                long key = kvp.Key;
                Product value = kvp.Value;
                if (key == id)
                {
                    _products[kvp.Key] = product;
                }
            }
        }

        //long IDatabase.AddProduct(Product product)
        //{
        //}

        Product? IDatabase.GetProduct(long id)
        {
            throw new NotImplementedException();
        }
    }
}