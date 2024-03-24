using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamLib
{
    public class ItemSet<T> : ISet<T>
    {
        private class Item
        {
            public T Element;
            public int Hash;

            public Item(T element, int hash)
            {
                this.Element = element;
                this.Hash = hash;
            }
        }

        private Item[] _items =  new Item[0];
        private int _count = 0;

        public override bool Equals(object? obj)
        {
            if (this == obj)
                return true;
            if (obj is not ItemSet<T>)
                return false;
            // Javi: Busca un nombre mejor
            ItemSet<T> itemElement = (ItemSet<T>)obj;

            if (_count != itemElement._count)
                return false;
            // Javi: MUY BIEN!!!!!!!!!!!
            for (int i = 0; i < _count; i++)
            {
                if (!_items[i].Element.Equals(itemElement._items[i].Element))
                    return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            int hash = 5;
            // Javi: Muy bien!!!!!
            for (int i = 0; i < _count; i++)
            {
                int elementHash = _items[i].Hash;
                hash = hash * 31 + elementHash;                                                                                          
            }
            return hash;
        }

        // +Add(element:T)
        public void Add(T element)
        {
            if (element == null || Contains(element))
                return;

            int hash = element.GetHashCode();
            Item newItem = new Item(element, hash);

            Item[] newArray = new Item[_count + 1];

            for (int i = 0; i < _count; i++)
            {
                newArray[i] = _items[i];
            }
            newArray[_count] = newItem;
            _items = newArray;
            _count++;
        }

        // +Remove(element:T)
        public void Remove(T element)
        {
            // Javi: Mejor haber usado IndexOf antes, y te ahorras el Contains
            if (element == null || !Contains(element))
                return;

            int index = IndexOf(element);

            Item[] newArray = new Item[_count - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = _items[i];
            }

            for (int i = index + 1; i < _count; i++)
            {
                newArray[i - 1] = _items[i];
            }
            _items = newArray;
            _count--;

            #region comentado
            //T[] newArray = new T[Count - 1];

            //for (int i = 0; i < index; i++)
            //    newArray[i] = _items[i].element;

            //for (int i = index + 1; i < Count; i++)
            //    newArray[i - 1] = _items[i].element;

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

        // Javi: MAL!!!! Usa IndexOf
        // +Contains(element:T):bool
        public bool Contains(T element)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_items[i].Element.Equals(element))
                    return true;
            }
            return false;
            //return indexof(element)
        }

        public int IndexOf(T index)
        {
            if (index == null)
                return -1;

            for (int i = 0; i < _count; i++)
            {
                // Javi: No usas el hash
                if (_items[i].Element.Equals(index))
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
    }
}
