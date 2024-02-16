namespace TPVLib
{

    public class RAMTPV : ITPV
    {

        //private dictionary
        private Dictionary<long, Product> _products= new Dictionary<long, Product>();
        //private list
        //propertie publicount
        public int ProductCount => _products.Count;

        int ITPV.ProductCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //private long _currentGeneratingId = 1;
        private long _currentGeneratingId = 1;

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

        public void RemoveProduct(long id)
        {
            //extraño que lance un throw exception
            if (id <= 0)
            {
                throw new ArgumentException("El id no es valido");
            }
            _products.Remove(id);
        }

        public Product? GetProduct(long id)
        {
            foreach(var entry in _products)
            {
                long key = entry.Key;
                Product value = entry.Value;
                if (key == id)
                {
                   return value.Clone();
                }
            }
            return null;
        }

        public void UpdateProductWithId(long id, Product product)
        {
            foreach(var kvp in _products)
            {
                long key = kvp.Key;
                Product value = kvp.Value;
                if (key == id)
                {
                    _products[kvp.Key] = product;
                }
            }
        }

        public List<Product> GetProducts(int offset, int limit)
        {
            int startPos = offset - 1;
            int endPos = Math.Min(startPos + limit, ProductCount);
            if (offset < 0 || limit < 0 || offset > _products.Count || limit > _products.Count)
                return new List<Product>();
            

            var productPage = new List<Product>();

            for (int i = startPos; i < endPos; i++)
            {
                productPage.Add(_products[i]);
            }
            return productPage;

            //Dictionary<long, Product> products = new Dictionary<long, Product>();
            //int count = 0;
            //foreach (var kvp in _products)
            //{
            //    if (count >= offset && count < offset + limit)
            //    {
            //        products.Add(kvp.Key, kvp.Value);
            //    }
            //    count++;
            //    if (count >= offset + limit)
            //    {
            //        break;
            //    }
            //}
            //return products;
        }

    

        public bool ContainsProduct(long id)
        {
            if (id < 0)
                return false;
            return _products.ContainsKey(id);
        }

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
    }

    //record es para crearlo y no modificarlo nunca
}