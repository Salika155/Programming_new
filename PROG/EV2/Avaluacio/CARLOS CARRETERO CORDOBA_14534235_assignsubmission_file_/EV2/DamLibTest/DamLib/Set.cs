using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DamLib
{
    public class Set<T> : ISet<T>
    {
        //Set<T>
        //- _set:T[]
        private T[] _set = new T[0];
        // Javi: En realidad este atributo no debería ser necesario
        private int _count = 0;
        
        public override bool Equals(object? obj)
        {
            if (this == obj)
                return true;
            if (obj is not Set<T>)
                return false;
            Set<T> s = (Set<T>)obj;
            // Javi: Hasta aquí bien, esto mal
            return s._set == _set && s._count == _count;
        }

        // +Add(element:T)
        public void Add(T element)
        {
            if (element == null || Contains(element))
                    return;

            T[] setElement = new T[_count + 1];
            for (int i = 0; i < _count; i++)
            {
                setElement[i] = _set[i];
            }
            setElement[_count] = element;
            _set = setElement;
            _count++;

        }
        // +Remove(element:T)
        public void Remove(T element)
        {
            if (element == null || Contains(element))
                return;

            T[] newArray = new T[_count - 1];
            int index = IndexOf(element);
            
            for (int i = 0, j = 0; i < _count; i++)
            {
                if (i != index)
                {
                    newArray[i] = _set[i];
                    j++;
                }
            }
            _set = newArray;
            _count--;

            //for (int i = index + 1; i < Count; i++)
            //    newArray[i - 1] = _set[i];

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

        // Javi: MAL!!!, llama al index of
        // +Contains(element:T):bool
        public bool Contains(T element)
        {
            if (Empty)
                return false;

            for (int i = 0; i < _count; i++)
            {
                if (_set[i].Equals(element))
                return true;
            }
            return false;
        }

        public int IndexOf(T element)
        {
            if (element == null || Empty)
                return -1;

            for (int i = 0; i < _count; i++)
            {
                if (_set[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Clear()
        {
            _count = 0;
        }

        //con contain hacer otra funcion privada que sea IndexOf
        // IndexOf(element:T):int
    }
}
