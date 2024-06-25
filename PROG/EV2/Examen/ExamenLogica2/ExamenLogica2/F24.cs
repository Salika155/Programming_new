using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenLogica2
{
    internal class F24
    {
        public class A
        {
            public int n1;
            protected int n2;
        }

        public class B : A
        {
            public B()
            {
                n2 = 1;
            }
        }

        public class C : B
        {
            public C() { n1 = 2; }

            public int GetN()
            {
                return n2 - n1;
            }
        }

        public static void Main()
        {
            C aux1 = new C();
            Console.Write(aux1.GetN());
        }
    }
}
