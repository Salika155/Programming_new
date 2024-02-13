using TPVLib;

namespace TPV
{
    public class Program
    {
        static void Main(string[] args, ITPV tpv)
        {
            ITPV ITPV = ITPV.CreateNewTPV();
            

            Product product1 = new Product
            {
                Id = 1,
                Name = "CocaCola",
                Price = 1.5,
                Stock = 10,
                Description = "Refresco"
            };

            Product product2 = new Product
            {
                Id = 2,
                Name = "Fanta",
                Price = 1.5,
                Stock = 10,
                Description = "Refresco"
            };

            long product1Id = tpv.AddProduct(product1);
            Console.WriteLine("Producto" + product1.Name + "registrado correctamente");

            long product2Id = tpv.AddProduct(product2);
            Console.WriteLine("Producto" + product2.Name + "registrado correctamente");

            Product? productoRecienInsertado = tpv.GetProduct(product1Id);
            Console.WriteLine("Producto" + productoRecienInsertado.Name + "recuperado correctamente");

            Product? productoRecienInsertado2 = tpv.GetProduct(product2Id);
            Console.WriteLine("Producto" + productoRecienInsertado2.Name + "recuperado correctamente");

            tpv.RemoveProduct(product1Id);
            Console.WriteLine("Producto eliminado con éxito.");

           
            //if (!tpv.Contains(product1Id))
            //{
            //    Console.WriteLine("El producto ya no existe en el sistema.");
            //}
            //else
            //{
            //    Console.WriteLine("Error: El producto todavía existe en el sistema.");
            //}


            bool isRunning = true;

            var tpvn = ITPV.CreateNewTPV();

            while (isRunning)
            {
                //string <= Console.ReadLine();

                //UI.ShowMainMenu
            }
        }



        //CRUD
        //Interface IProduct
        //long AddProduct(Product product)Throw Exception;
        //void RemoveProduct(long id)Throw Exception;
        //Product GetProduct(long id);
        //void UpdateProductWithId(long id, Product product)Throw Exception;
        //void RemoveProduct(Product product)
        //if (product != null)
        //RemoveProduct(product.Id);

        //int ProductCount { get; }
        //List<Product> GetProducts(int offset, int limit);
        //este tipo de consultas siempre se consultan ordenadas. offset pone el limite inicial de donde empieza y limit hasta donde llega.

    }
}