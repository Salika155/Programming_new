using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ExamenLogica2
//{
//    internal class F16
//    {
//        public class A
//        {
//            public virtual int F()
//            {
//                return J();
//            }
//            public virtual int J()
//            {
//                return 3;
//            }
//        }

//        public class B : A
//        {
//            public override int F() { return 1 * base.F() + F(); }
//        }

//        public class C : B
//        {
//            public override int J() 
//            {
//                return 1;
//            }
//        }

//        public static void Main()
//        {
//            B aux1 = new C();
//            Console.Write(aux1.F());
//        }
//    }
//    //Respuesta: Se produce una llamada recursiva infinita en la clase B en el metodo F, ya que se esta ejecutando
//    //sin un valor de detencion, y a su vez esta sobreescribiendo el metodo f
//    //Solucion: so
//}
