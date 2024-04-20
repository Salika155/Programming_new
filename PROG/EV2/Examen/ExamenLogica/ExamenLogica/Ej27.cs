using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ExamenLogica
//{
//    internal class Ej27
//    {
//        public class ClaseA
//        {
//            public abstract int F1();
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
//        //solucion = EC7-EC15
//        //EC7 = No se puede llamar a un miembro abstracto
//        //EC15 = No se puede crear una instancia de una clase abstracta,
//        //es abstracto pero esta contenido en tipo no abstracto
//    }
//}
