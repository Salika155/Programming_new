using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class ClaseA
    {
        public ClaseA(int n)
        {
            
        }
        public abstract int GetNumber();
        public virtual string GetString()
        {
            return "ClaseA";
        }
    }

    class ClaseB : ClaseA //-> se soluciona o poniendo abstract o poniendo un constructor
    {
        public ClaseB(int n) : base(n + 3)
        {
        }

        public override int GetNumber()
        {
            return 0;
        }
    }


    class ClaseC : ClaseB
    {
        public ClaseC(int n) : base(n)
        {
        }

        public override int GetNumber()
        {
            return 1 + base.GetNumber();
        }
    }


    
}
