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

        public override bool Equals(object? obj)
        {
            if (this == obj)
                return true;
            if (obj is not Set<T>)
                return false;
            Set<T> s = (Set<T>)obj;
            return s._set == _set && s._count == _count;
        }

        public void Add(T element)
        {
            T[] setelement = new T[_count + 1];
            for (int i = 0; i < setelement.Length; i++)
            {
                setelement[i] = element;
            }
            _set = setelement;

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
            for (int i = 0; i < _count; i++)
            {
                //if (_set[i] Equals(element));
                        
            }
            
            
        }

        public bool IndexOf(T element)
        {

        }

        //con contain hacer otra funcion privada que sea IndexOf
        // IndexOf(element:T):int


    }
}
