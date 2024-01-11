using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DamLib
{
    public class Set<T>
    {

        //Set<T>

        //- _set:T[]
        private T[] _set = new T[0];
        private int _count = 0;

        // +Add(element:T)

        public void Add(T element)
        {
            T[] setelement = new T[_count + 1];
         

        }
        // +Remove(element:T)

        public T Remove(T element)
        {

        }
        // +Empty: bool

        public bool Empty
        {
            get => _count == 0;
        }

        // +Count:int

        public int Count
        {
            get => _count;
        }

        // +Contains(element:T):bool

        public bool Cointains(T element)
        {
            
            
        }


    }
}
