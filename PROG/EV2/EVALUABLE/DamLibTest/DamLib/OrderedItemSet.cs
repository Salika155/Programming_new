﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DamLib
{
    public class OrderedItemSet<T>
    {
        private class Item
        {
            public T Element;
            public int hash;

            public Item(T element, int hash)
            {
                this.Element = element;
                this.hash = hash;
            }
        }

        private Item[] _item1 = new Item[0];
        private int _count = 0;

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

        public override bool Equals(object? obj)
        {
            if (this == obj)
                return true;
            if (obj is not OrderedItemSet<T>)
                return false;
            OrderedItemSet<T> itemElement = (OrderedItemSet<T>)obj;

            if (_count != itemElement.Count)
                return false;

            for (int i = 0; i < _count; i++)
            {
                if (!_item1[i].Element.Equals(itemElement._item1[i].Element))
                    return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            int hash = 5;
            for (int i = 0; i < _count; i++)
            {
                int elementHash = _item1[i].hash;
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
                newArray[i] = _item1[i];
            }
            newArray[_count] = newItem;
            _item1 = newArray;
            _count++;

            Sort();
            // Javi: Y cuando ordenas
        }

        // +Remove(element:T)
        public void Remove(T element)
        {
             // Javi: Mejor haber usado IndexOf antes, y te ahorras el Contains
            int index = IndexOf(element);

            if (index != -1)
            {
                Item[] newArray = new Item[_count - 1];

                for (int i = 0; i < index; i++)
                {
                    newArray[i] = _item1[i];
                }

                for (int i = index + 1; i < _count; i++)
                {
                    newArray[i - 1] = _item1[i];
                }
                _item1 = newArray;
                _count--;
            }

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

        // +Contains(element:T):bool
        public bool Contains(T element)
        {
            return IndexOf(element) != -1;
            //return indexof(element)
        }

        public int IndexOf(T index)
        {
            if (index == null)
                return -1;

            int hasCode = index.GetHashCode();

            for (int i = 0; i < _count; i++)
            {
                T currentElement = _item1[i].Element;
                // Javi: No usas el hash
                if (currentElement.GetHashCode() == hasCode && currentElement.Equals(index))
                {
                    return i;
                }
            }
            return -1;
        }

        // Javi: Esto es el index of
        //hay que hacer un binary search
        public bool BinarySearch(T element)
        {
            if (element == null || _count <= 0)
                return false;

            int min = 0;
            int max = _count - 1;
            int hash = element.GetHashCode();

            while (min <= max)
            {
                int med = (min + max) >> 1; //desplazar un bit a la derecha -> shift

                if (_item1[med].hash == hash)
                    return true;
                if (_item1[med].hash < hash)
                    min = med + 1;
                else
                    max = med - 1;
            }
            return false;
        }

        public void Clear()
        {
            _count = 0;
        }

        //Sort
        // Javi: Primero, esto es private, segundo, cuando lo usas!??!?!!?
        private void Sort()
        {
            if (_count <= 0)
                return;

            for (int i = 0; i < _count - 1; i++)
            {
                for (int j = i + 1; j < _count; j++)
                {
                    if (_item1[i].hash > _item1[j].hash)
                    {
                        Item aux = _item1[i];
                        _item1[i] = _item1[j];
                        _item1[j] = aux;
                    }
                }
            }
        }
    }
}

//pasame la direccion de memoria ram donde se encuentra el entero, que en la funcion es llamado resultentero y es donde se encuentra el resultado de la verdadera variable
//3 maneras: out, in y ref -> pasame la direccion de memoria ram donde se encuentra el valor
//si es out solo se puede escribir en esa variable,
//si es in solo puedo leer de ella, ref es que puedo leer y escribir
