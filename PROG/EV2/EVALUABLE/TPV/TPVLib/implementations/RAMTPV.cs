using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;

namespace TPVLib
{

    public class RAMTPV : ITPV
    {
        //private dictionary
        private Dictionary<long, Product> _products= new Dictionary<long, Product>();
        //private list
        //propertie publicount
        public int ProductCount => _products.Count;

        private IDatabase _db;

        //INYECCION DE DEPENDENCIAS
        public RAMTPV(IDatabase db)
        {
            _db = db;
        }

        public RAMTPV()
        {
            
        }

        //private long _currentGeneratingId = 1;
        private long _currentGeneratingId = 1;

        public long AddProduct(Product product)
        {
            #region comentado
            //if (product == null)
            //{
            //    throw new Exception("no se puede añadir");
            //}
            //var cloneProduct = product.Clone();
            //cloneProduct.Id = _currentGeneratingId++;
            //_products.Add(cloneProduct.Id, cloneProduct);
            //return cloneProduct.Id;
            #endregion
            return _db.AddProduct(product);
        }

        public void RemoveProduct(long id)
        {
            #region comentado
            //extraño que lance un throw exception
            //if (id <= 0)
            //{
            //    throw new ArgumentException("El id no es valido");
            //}
            //_products.Remove(id);
            #endregion
            _db.RemoveProduct(id);
        }

        public Product? GetProduct(long id)
        {
            return _db.GetProduct(id);
        }

        public void UpdateProductWithId(long id, Product product)
        {
            #region comentado
            //foreach(var kvp in _products)
            //{
            //    long key = kvp.Key;
            //    Product value = kvp.Value;
            //    if (key == id)
            //    {
            //        _products[kvp.Key] = product;
            //    }
            //}
            #endregion
            _db.UpdateProductWithId(id, product);
        }

        public List<Product> GetProducts(int offset, int limit)
        {
            #region comentado
            //int startPos = offset - 1;
            //int endPos = Math.Min(startPos + limit, ProductCount);
            //if (offset < 0 || limit < 0 || offset > _products.Count || limit > _products.Count)
            //    return new List<Product>();


            //var productPage = new List<Product>();

            //for (int i = startPos; i < endPos; i++)
            //{
            //    productPage.Add(_products[i]);
            //}
            //return productPage;
            #endregion
            return _db.GetProducts(offset, limit);
        }
    
        public bool ContainsProduct(long id)
        {
            if (id < 0)
                return false;
            return _products.ContainsKey(id);
        }

        #region comentado
        //public long AddTicket(RAMTicket t)
        //{
        //    try
        //    {
        //        _database.BeginTransaction();
        //        long id = _database.AddTicket(TicketHeader Header);
        //        foreach (var line in t.Body.Lines)
        //        {
        //            _database.AddLineToTicketWithId(id, line);
        //        }
        //    }
        //    catch(Exception e)
        //    {
        //        _database.RollbackTransaction();
        //        throw e;
        //    }
        //    return Id;
        //}


        //public void SaveTicket(RAMTicket[] t)
        //{
        //    List<RAMTicket> savedTickets = new List<RAMTicket>();

        //    foreach(var ticket in t)
        //    {
        //        try
        //        {
        //            savedTickets.Add(ticket);
        //        }
        //        catch (Exception e)
        //        {
        //            throw e;
        //        }
        //    }

        //}

        //public void AddTicket(RAMTicket t)
        //{

        //}

        //public Dictionary<long, Product> GetProducts(int offset, int limit)
        //{
        //    throw new NotImplementedException();
        //}

        //public long addproduct(product product)
        //var cloneProduct = product.Clone();
        //cloneProduct.Id = _currentGeneratingId++;
        //_products.Add(cloneProduct);
        //return cloneProduct.Id;

        //removeproduct

        //getproductwithid

        //updateproductwithid

        //public Dictionary<long, Product> GetProducts(int offset, int limit)
        //

        //public bool ContainsProduct(long id)
        #endregion
    }

    //record es para crearlo y no modificarlo nunca
}