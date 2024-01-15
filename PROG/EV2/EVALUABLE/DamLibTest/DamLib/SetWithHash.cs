using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DamLib
{
    public class SetWithHash<T>
    {
        //Set<T>
        //- _set:T[]
        private T[] _set = new T[0];
        private int[] _hash = new int[0];
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
        public void Add(T newElement)
        {
            if (newElement == null || Contains(newElement))
                return;

            int hash = newElement.GetHashCode();

            T[] setelement = new T[_count + 1];
            int[] hashArray = new int[_count + 1];

            for (int i = 0; i < _count; i++)
            {
                setelement[i] = _set[i];
                hashArray[i] = hash;
            }

            //for (int i = 0; i < hashArray.Length; i++)
            //{
            //    hashArray[i] = hash;
            //}

            //arrayTemporal[_set.Length] ) element;
            //_set = arrayTemporal;

            setelement[_count] = newElement;
            _hash[hashArray.Length] = hash;

            _set = setelement;
            _hash = hashArray;
        }

        // +Remove(element:T)
        public void Remove(T element)
        {
            int index = IndexOf(element);
            if (index < 0)
                return;
            
            T[] newArray = new T[Count - 1];
            int[] newHashArray = new int[Count - 1];

            for (int i = 0, j = 0; i < Count - 1; i++, j++)
            {
                if (index == i)
                {
                    j++;
                }
                newArray[i] = _set[i];
                newHashArray[i] = _hash[i];
            }
                

            for (int i = index + 1; i < Count; i++)
            {
                newArray[i - 1] = _set[i];
                newHashArray[i - 1] = _hash[i];
            }

            _set = newArray;
            _hash = newHashArray;
            
        }
        /*
         for (int i = 0; i < Count; i++)
        {
            if (i == position)
            {
                j++;
            }
            faltan cosas
         */


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

        public bool Contains(T checkElement)
        {
            int hash = checkElement.GetHashCode();
            for (int i = 0; i < _count; i++)
            {
                if (_hash[i] == hash && _set[i].Equals(checkElement))
                    return true;
            }
            return false;

        }

        public int IndexOf(T element)
        {
            if (element == null)
                return -1;

            int hash = element.GetHashCode();
            for (int i = 0; i < _set.Length; i++)
            {
                if (hash == _hash[i] && _set[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

            //con contain hacer otra funcion privada que sea IndexOf
            // IndexOf(element:T):int

        //SI implemento equals necesariamente en cada clase debe de ir el GetHashCode

    }
}
