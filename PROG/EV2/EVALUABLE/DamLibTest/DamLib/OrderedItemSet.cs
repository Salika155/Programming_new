using System;
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

            private T[] _item1 = new T[0];
            private int _count = 0;

            public override bool Equals(object? obj)
            {
                if (this == obj)
                    return true;
                if (obj is not OrderedItemSet<T>)
                    return false;
                OrderedItemSet<T> itemElement = (OrderedItemSet<T>)obj;
                return itemElement._item1 == _item1 && itemElement._count == _count;

                //for (int i = 0; i < _count; i++)
                //{
                //    if (_item1[i].Equals(_item1[i]))
                //        return true;
                //}
                //return false;
            }

            public override int GetHashCode()
            {
                int hash = 5;
                for (int i = 0; i < _count; i++)
                {
                int elementHash = 1;
                    hash = hash * 31 + elementHash;
                }
                return hash;
            }

            // +Add(element:T)
            public void Add(T element)
            {
                if (element == null || Contains(element))
                    return;
                

                //T[] setElement = new T[_count + 1];
                //for (int i = 0; i < _count; i++)
                //{
                //    setElement[i] = _items[i].element;
                //}
                //setElement[_count] = element;
                //_items = setElement;
                //_count++;

            //hay que hacer cosas en el add
            }


            // +Remove(element:T)

            public void Remove(T element)
            {

                if (element == null || !Contains(element))
                    return;

                


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
                    if (_item1[i].Equals(element))
                        return true;
                }
                return false;
                //return indexof(element)
            }

            public int IndexOf(T index)
            {
                if (index == null)
                    return -1;

               
                return -1;
            }
        
            //hay que hacer un binary search
    }
}
