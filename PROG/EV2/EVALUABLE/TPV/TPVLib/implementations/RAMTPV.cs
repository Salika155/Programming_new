namespace TPVLib
{

    public class RAMTPV : ITPV
    {

        //private dictionary
        private Dictionary<long, Product> _products= new Dictionary<long, Product>();
        //private list
        //propertie publicount
        public int ProductCount { get; set; }
        //private long _currentGeneratingId = 1;
        private long _currentGeneratingId = 1;

        public long AddProduct(Product product)
        {
            var cloneProduct = product.Clone();
            cloneProduct.Id = _currentGeneratingId++;
            _products.Add(cloneProduct.Id, cloneProduct);
            return cloneProduct.Id;
        }

        public void RemoveProduct(long id)
        {
            throw new NotImplementedException();
        }

        public Product? GetProduct(long id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductWithId(long id, Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts(int offset, int limit)
        {
            throw new NotImplementedException();
        }



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