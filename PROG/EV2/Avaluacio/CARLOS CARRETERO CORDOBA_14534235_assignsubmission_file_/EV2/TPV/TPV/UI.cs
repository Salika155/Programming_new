using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVLib;

namespace TPV
{
    public class UI
    {
        //imprimir de pantalla o leer de pantalla tiene que ir en esta clase
        public static void ShowMainMenu(TPVLib.ITPV tpv)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al TPV (Terminal Punto de Venta)");
            Console.WriteLine("1. Realizar venta");
            Console.WriteLine("2. Ver lista de productos");
            Console.WriteLine("3. Registrar producto nuevo");
            Console.WriteLine("4. Salir");
            //var option = Console.ReadLine();
            //return option;
        }

        public static void Case1Product(ITPV tPV)
        {
            Console.WriteLine("Introduzca el nombre del producto que desea");
            string nombre = Console.ReadLine();
            if (nombre == null || nombre == "")
            {
                Console.WriteLine("El nombre no es válido");
            }
            Console.WriteLine("Introduzca la cantidad que desea");
            int quantity = Convert.ToInt32(Console.ReadLine());
            if (quantity == null || quantity <= 0)
            {
                Console.WriteLine("El valor de cantidad no es válido");
            }
            Console.Clear();
            ShowMainMenu(tPV);
        }

        public static void ShowProductList(ITPV tPV)
        {
            Console.Clear();
            Console.WriteLine("Lista de productos");
            string code = Console.ReadLine();
            Console.WriteLine("1. Producto 1");
            Console.WriteLine("2. Producto 2");
            Console.WriteLine("3. Producto 3");
            Console.WriteLine("4. Producto 4");
            Console.WriteLine("5. Producto 5");
            Console.WriteLine("6. Producto 6");
            Console.WriteLine("7. Producto 7");
            Console.WriteLine("8. Producto 8");
            Console.WriteLine("9. Producto 9");
            Console.WriteLine("10. Producto 10");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Pulse cualquier letra para salir");
            Console.ReadLine();
            Console.Clear();
            ShowMainMenu(tPV);
        }
        public static void Case3RegistProduct(ITPV tPV)
        {
            Console.Clear();
            Console.WriteLine("Registrar producto");
            Console.WriteLine("Introduzca el código del producto que desea registrar");
            string code = Console.ReadLine();
            //esto deberia ser un long
            Console.WriteLine("Introduzca el nombre del producto que desea registrar");
            string nombre = Console.ReadLine();
            if (nombre == null || nombre == "")
            {
                Console.WriteLine("El nombre no es válido");
            }
            Console.WriteLine("Introduzca el precio del producto");
            double price = Convert.ToDouble(Console.ReadLine());
            if (price == null || price <= 0)
            {
                Console.WriteLine("El valor de precio no es válido");
            }
            Console.WriteLine("Introduzca la cantidad que desea registrar");
            int stock = Convert.ToInt32(Console.ReadLine());
            if (stock == null || stock <= 0)
            {
                Console.WriteLine("El valor de cantidad no es válido");
            }
            Console.WriteLine("Introduzca la descripción del producto");
            string description = Console.ReadLine();
            if (description == null || description == "")
            {
                Console.WriteLine("La descripción no es válida");
            }

            tPV.AddProduct(new Product
            {
                //Id = code,
                Name = nombre,
                Price = price,
                Stock = stock,
                Description = description
            });
            Console.Clear();
            ShowMainMenu(tPV);
        }
    }
}
