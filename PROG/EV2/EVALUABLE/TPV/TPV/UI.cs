using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        
    }
}
