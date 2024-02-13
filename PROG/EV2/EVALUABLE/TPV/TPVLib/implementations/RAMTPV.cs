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
            if (id < 0)
            {
                throw new ArgumentException("El id no es valido");
            }
            if (_products.ContainsKey(id))
            {
                _products.Remove(id);
            }
            else
            {
                throw new ArgumentException("El producto no existe");
            }

        }

        public Product? GetProduct(long id)
        {
            if (id < 0)
            {
                throw new ArgumentException("El id no es valido");
            }
            if (_products.TryGetValue(id, out Product? value))
            {
                return value;
            }
            return null;
        }

        public void UpdateProductWithId(long id, Product product)
        {
            if (id < 0 || product == null)
            {
                throw new ArgumentException("El id o producto no es valido");
            }
           
            if (_products.ContainsKey(id))
            {
                _products[id] = product;
            }
            else
            {
                throw new ArgumentException("El producto no existe");
            }
        }

        Dictionary<long, Product> ITPV.GetProducts(int offset, int limit)
        {
            if (offset < 0 || limit < 0 || offset > _products.Count || limit > _products.Count)
            {
                throw new ArgumentException("El limit no es valido");
            }

            Dictionary<long, Product> products = new Dictionary<long, Product>();
            int count = 0;
            foreach (var kvp in _products)
            {
                if (count >= offset && count < offset + limit)
                {
                    products.Add(kvp.Key, kvp.Value);
                }
                count++;
                if (count >= offset + limit)
                {
                    break;
                }
            }
            return products;
        }

    

        public bool ContainsProduct(long id)
        {
            if (id < 0)
            {
                throw new ArgumentException("El id no es valido");
            }
            return _products.ContainsKey(id);
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