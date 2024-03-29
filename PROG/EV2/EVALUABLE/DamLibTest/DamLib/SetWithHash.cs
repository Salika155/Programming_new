using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DamLib
{
    public class SetWithHash<T> : ISet<T>
    {
        //Set<T>
        //- _set:T[]
        private T[] _set = new T[0];
        private int[] _hash = new int[0];
        private int _count = 0;

        // +Empty: bool
        public bool Empty => _count == 0;
        //{
        //    get => _count == 0;
        //}

        // +Count:int
        public int Count => _count;
        //{
        //    get => _count;
        //}

        public override bool Equals(object? obj)
        {
            if (this == obj)
                return true;
            if (obj is not SetWithHash<T>)
                return false;
            SetWithHash<T> s = (SetWithHash<T>)obj;
            //return s._set == _set && s.Count == _count;
            if (s.Count != _count)
                return false;

            foreach (var item in _set)
            {
                if (!s._set.Contains(item))
                    return false;
            }
            return true;
        }

#nullable disable
        public override int GetHashCode()
        {
            int hash = 5;
            for (int i = 0; i < _set.Length; i++)
            {
                int element = _set[i].GetHashCode();
                hash = hash * 31 + element;
            }
            return hash;
        }
#nullable enable

        // +Add(element:T)
        public void Add(T newElement)
        {
            if (newElement == null || Contains(newElement))
                return;

            if (_count == _set.Length)
            {
                // Duplicar el tamaño del arreglo
                T[] newSet = new T[_set.Length * 2];
                int[] newHash = new int[_hash.Length * 2];

                // Copiar los elementos existentes al nuevo arreglo
                for (int i = 0; i < _count; i++)
                {
                    newSet[i] = _set[i];
                    newHash[i] = _hash[i];
                }

                // Actualizar referencias
                _set = newSet;
                _hash = newHash;
            }

            // Agregar el nuevo elemento al final del arreglo
            _set[_count] = newElement;
            _hash[_count] = newElement.GetHashCode();
            _count++; // Incrementar el contador de elementos
        }

        //for (int i = 0; i < hashArray.Length; i++)
        //{
        //    hashArray[i] = hash;
        //}

        //arrayTemporal[_set.Length] ) element;
        //_set = arrayTemporal;

        // +Remove(element:T)
        public void Remove(T element)
        {
            int index = IndexOf(element);
            if (index < 0)
                return;

            T[] newArray = new T[Count - 1];
            int[] newHashArray = new int[Count - 1];

            for (int i = 0, j = 0; i < Count; i++)
            {
                if (i != index)
                {
                    // Javi: Mal
                    newArray[j] = _set[i];
                    newHashArray[j] = _hash[i];
                    j++;
                }
            }

            for (int i = index + 1; i < Count; i++)
            {
                newArray[i - 1] = _set[i];
                newHashArray[i - 1] = _hash[i];
            }

            _set = newArray;
            _hash = newHashArray;
        }
        #region comentado
        /*
         for (int i = 0; i < Count; i++)
        {
            if (i == position)
            {
                j++;
            }
            faltan cosas
         */
        #endregion

        // +Contains(element:T):bool
#nullable disable
        // Javi: Mal, llamar al index of
        public bool Contains(T checkElement)
        {
            //int hash = checkElement.GetHashCode();
            //for (int i = 0; i < _count; i++)
            //{
            //    if (_hash[i] == hash && _set[i].Equals(checkElement))
            //        return true;
            //}
            //return false;
            return IndexOf(checkElement) != -1;
        }
#nullable enable

#nullable disable
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
#nullable enable

        public void Clear()
        {
            _count = 0;
        }

        //con contain hacer otra funcion privada que sea IndexOf
        // IndexOf(element:T):int

        //SI implemento equals necesariamente en cada clase debe de ir el GetHashCode

    }
}