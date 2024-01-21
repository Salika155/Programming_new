﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        // +Remove(element:T)
        public void Remove(T element)
        {
            if (element == null || !Contains(element))
                return;

            int index = IndexOf(element);

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

        // +Contains(element:T):bool

        public bool Contains(T element)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_item1[i].Element.Equals(element))
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
                if (_item1[i].Element.Equals(index))
                {
                    return i;
                }
            }
            return -1;
        }

        //hay que hacer un binary search

        public bool BinarySearch(T element)
        {
            if (element == null || _count == 0)
                return false;

            int min = 0;
            int max = _count - 1;

            while (min <= max)
            {
                int med = (min + max) / 2;

                if (_item1[med].Element.Equals(element))
                    return true;
                else if (_item1[med].Element.GetHashCode() < element.GetHashCode())
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


    }
}

//pasame la direccion de memoria ram donde se encuentra el entero, que en la funcion es llamado resultentero y es donde se encuentra el resultado de la verdadera variable
//3 maneras: out, in y ref -> pasame la direccion de memoria ram donde se encuentra el valor
//si es out solo se puede escribir en esa variable,
//si es in solo puedo leer de ella, ref es que puedo leer y escribir