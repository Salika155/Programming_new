using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ExamenLogica2
//{
//    internal class F5
//    {
//        public static string F(string str)
//        {
//            try
//            {
//                Console.Write("1");
//                int.Parse(str);
//                Console.Write("2");
//                return "A";
//            }
//            catch(Exception)
//            {
//                Console.Write("4");
//                return "B";
//            }
//            finally
//            {
//                Console.Write("5");
//            }
//            Console.Write("3");
//            return "D";
//        }

//        public static void Main()
//        {
//            Console.Write(F("E"));
//        }
//    }
//    //Imprimes el 1, salta la excepcion por el parse, imprimes el 4, luego
//    //saltas al finally, y devuelves la excepcion, que es B -> 145B
//    //lo de fuera del finally es inaccesible
//    //Solucion: 145B
//}
