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
            Console.WriteLine("3. Ver carrito de compras");
            Console.WriteLine("4. Salir");
            //var option = Console.ReadLine();
            //return option;
        }

        public static void Case1Product(ITPV tPV)
        {
            Console.WriteLine("Introduzca el código del producto que desea");
            string code = Console.ReadLine();
            Console.WriteLine("Introduzca la cantidad que desea");
            int quantity = Convert.ToInt32(Console.ReadLine());
            //if (quantity == null)
            //{
            //    Console.WriteLine("La cantidad no puede ser nula");
            //}
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
        }
    }
}
