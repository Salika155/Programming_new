namespace TPVLib
{
    public interface ITPV
    {
        int ProductCount { get; }
        static ITPV CreateNewTPV()
        {
            return new RAMTPV();
        }

        //diccionario
        //idatabase crea new Database Y SE LA PASO POR CONSTRUCTOR
        //private Dictionary<> = new();
        //IDatabase db = new RAMDatabase();

        long AddProduct(Product product);

        //void AddTicket(RAMTicket t);

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

        #region comentado
        //void SaveTicket(RAMTicket[] ticket)
        //{
        //    //aqui se guarda el ticket
        //}

        //a lo mejor quiero pasar la funcion aqui, y es mejor hacerla aqui porque siempre va a ser igual

        //hay que hacer el add product
        #endregion
    }
}
