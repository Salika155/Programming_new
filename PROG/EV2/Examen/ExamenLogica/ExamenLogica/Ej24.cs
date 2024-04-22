using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ExamenLogica
//{
//    internal class Ej24
//    {
//        public class ClaseA
//        {
//            public virtual int F1()
//            {
//                Console.Write("1");
//                return 1;
//            }
//        }

//        public class ClaseB : ClaseA
//        {
//            public override int F1()
//            {
//                Console.Write("2");
//                return 2 + base.F1();
//            }
//        }

//        public class ClaseC : ClaseB
//        {
//            public override int F1()
//            {
//                Console.Write("3");
//                return 3 + base.F1();
//            }
//        }

//        public static void Main(string[] args)
//        {
//            ClaseA a = new ClaseC();
//            Console.Write(a.F1());
//        }

//        //solucion = 3216
//        //F1 de ClaseC llama a F1 de ClaseB que llama a F1 de ClaseA
//    }
//}
