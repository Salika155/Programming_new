using TPVLib;

namespace TPV
{
    public class Controllers
    {
        
        public static void RunMainMenu(ITPV tpv)
        {
            bool IsRunning = true;
            while(IsRunning)
            {
                UI.ShowMainMenu(tpv);
                string option = Console.ReadLine();

                switch(option)
                {
                    case "1":
                        Console.WriteLine("Comprar producto");
                        Console.WriteLine("Introduzca el código del producto que desea");

                        break;
                    case "2":
                        Console.WriteLine("Ver lista de productos");
                        Console.WriteLine("Elija el producto que desee consultar");
                        break;
                    case "3":
                        Console.WriteLine("Ver carrito de compras");

                        break;
                    default:
                        Console.WriteLine("Adios, tenga un buen día");
                        IsRunning = false;
                        break;
                }
            }
        }

        public static void Start(ITPV iTPV)
        {
            Console.WriteLine("Bienvenido al TPV para pedir!");
            Console.WriteLine("Por favor, elige una opción:");
            
            RunMainMenu(iTPV);
        }

        //public static void AddProduct(TPVLib.ITPV tpv)
        //{
        //    Console.WriteLine("Enter the name of the product");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("Enter the price of the product");
        //    double price = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Enter the stock of the product");
        //    int stock = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter the description of the product");
        //    string description = Console.ReadLine();

        //    TPVLib.Product product = new TPVLib.Product
        //    {
        //        Name = name,
        //        Price = price,
        //        Stock = stock,
        //        Description = description
        //    };

        //    long id = tpv.AddProduct(product);
        //    Console.WriteLine("Product " + product.Name + " registered correctly with id " + id);
        //}


    }
}
