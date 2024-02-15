using TPVLib;
using System;

namespace TPVTest
{
    public class Program
    {
        static void Main(string[] args)
        {

            ITPV tpv = ITPV.CreateNewTPV();

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
            Console.WriteLine($"Producto{productoRecienInsertado.Name}recuperado correctamente");

            Product? productoRecienInsertado2 = tpv.GetProduct(product2Id);
            Console.WriteLine($"Producto{productoRecienInsertado2.Name}recuperado correctamente");

            tpv.RemoveProduct(product1Id);
            Console.WriteLine("Producto eliminado con éxito."); 




        }
    }
}