using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamLib
{
    public class SetWithHash<T>
    {
       

            //Set<T>

            //- _set:T[]
            private T[] _set = new T[0];
            private T[] _hash = new T[0];
            private int _count = 0;

            public override bool Equals(object? obj)
            {
                if (this == obj)
                    return true;
                if (obj is not SetWithHash<T>)
                    return false;
                SetWithHash<T> s = (SetWithHash<T>)obj;
                return s._set == _set && s.Count == _count;
            }

        public override int GetHashCode()
        {
            return _hash.GetHashCode() + Count;
        }

        // +Add(element:T)

        public void Add(T element)
        {
            if (element == null || Contains(element))
                return;

            T[] setelement = new T[_count + 1];
            for (int i = 0; i < _count; i++)
            {
                setelement[i] = _set[i];
            }
            setelement[_count] = element;
            _set = setelement;
            _count++;
        }

        // +Remove(element:T)

        public void Remove(T element)
            {

                if (element == null || Contains(element))
                    return;

                int index = IndexOf(element);
                T[] newArray = new T[Count - 1];

                for (int i = 0; i < index; i++)
                    newArray[i] = _set[i];

                for (int i = index + 1; i < Count; i++)
                    newArray[i - 1] = _set[i];

                /*
                 for (int i = 0; i < Count; i++)
                {
                    if (i == position)
                    {
                        j++;
                    }
                    faltan cosas
                 */

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

            public bool Contains(T element)
            {
                for (int i = 0; i < _count; i++)
                {
                    if (_set[i].Equals(element))
                        return true;
                }
                return false;

            }

            public int IndexOf(T element)
            {
                if (element == null)
                    return -1;

                for (int i = 0; i < _set.Length; i++)
                {
                    if (_set[i].Equals(element))
                    {
                        return i;
                    }
                }
                return -1;
            }

            //con contain hacer otra funcion privada que sea IndexOf
            // IndexOf(element:T):int


        
    }
}
