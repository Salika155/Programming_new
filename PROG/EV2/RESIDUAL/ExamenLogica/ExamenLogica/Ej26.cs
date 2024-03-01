using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenLogica
{
    internal class Ej26
    { 
    public class ClaseA
    {
        public virtual int GetAge() { return 10; }
    }

    public class ClaseB : ClaseA
    {
        public override int GetAge()
        {
            return GetAge();
        }
    }

    public class ClaseC : ClaseB
    {
        public override int GetAge()
        {
            return base.GetAge();
        }
    }

    public static void Main(string[] args)
    {
        ClaseC a = new ClaseC();
        Console.Write(a.GetAge());
    }
    //solucion = STACKOVERFLOW SO
}
}


