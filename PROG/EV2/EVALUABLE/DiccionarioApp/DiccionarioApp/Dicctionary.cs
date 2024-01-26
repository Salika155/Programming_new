using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DiccionarioApp
{
    //funcion delegado para hacer lambda -> prototipo de algo generico que le paso un key y un value y devuelve un booleano
    public delegate bool DiccionaryFilterDelegate<K, V>(K key, V value);
    public delegate int ComparatorDelegate<T>(T n1, T n2);
    public class Dicctionary <K, V>
    {
        private class Item
        {
            public K key;
            public V value;
        }

        private Item[] _items = new Item[0];

        public Dicctionary()
        {
            _items = new Item[0];
        }

        //para llamar al constructor de ariba
        //public Dicctionary(Dicctionary<K, V> d) : this()
        //{

        //}

        public int Count => _items.Length;
        public bool IsEmpty => _items.Length == 0;

        public void Clear()
        {
            _items = new Item[0];
        }

        public void Add(K key, V value)
        {
            //if key es igual que sale un throw new exception
            Item[] newArray = new Item[_items.Length + 1];
            for (int i = 0; i < _items.Length; i++)
            {
                newArray[i] = _items[i];
            }
            newArray[_items.Length] = new Item
            {
                key = key,
                value = value
            };
            _items = newArray;

        }

        public void AddOrReplace(K key, V value)
        {
            int index = IndexOfKey(key);
            if (index != -1)
            {
                _items[index].value = value;
               
            }
            else
            {
                Add(key, value);
            }

        }

        private int IndexOfKey(K key)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].key.Equals(key))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contains(K key)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

        public void Remove(K key)
        {
            int index = IndexOfKey(key);
            if (index != -1)
            {
                Item[] newArrayItem = new Item[_items.Length - 1];
                for (int i = 0, j = 0; i < _items.Length; i++)
                {
                    if (i != index)
                    {
                        newArrayItem[j] = _items[i];
                        j++;
                    }
                }
                _items = newArrayItem;
            }

        }

        public V GetValueWithKey(K key)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].key.Equals(key))
                {
                    return _items[i].value;
                }
            }
            return default(V);
        }

        public bool TryGetValue(K key, out V value)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].key.Equals(key))
                {
                    value = _items[i].value;
                    return true;
                }
            }
            value = default(V);
            return false;

        }

        public Dictionary<K,V> Filter(DiccionaryFilterDelegate<K,V> where)
        {
            var ret = new Dictionary<K,V>();

            if (ret == null)
            {
                throw new ArgumentNullException(/*nameof(ret)*/);
            }

            for (int i = 0; i < _items.Length; i++)
            {
                Item item = _items[i];
                bool addToNewDictionary = where(item.key, item.value);
                if (addToNewDictionary)
                    ret.Add(item.key, item.value);
                //mejor una funcion que los meta directo, porque ya estan ordenados al ejecutarse
                //AddKeyValue
                
            }
            return ret;
        }

        //private void AddKeyValue(K key, V value)
        //{
        //    //Append nombre para añadir en array
        //    Item item = new Item();
        //    item.key = key;
        //    item.value = value;
        //    _items = Append(_items, item);
        //}

        //void Remove

        public void Remove(DiccionaryFilterDelegate<K, V> where)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                Item item = new Item();
                bool hasToBeRemoved = where(item.key, item.value);
                if (hasToBeRemoved)
                {
                    Remove(item.key);
                    i--;
                }
            }

        }

        public static void Sort<T>(T[] array, ComparatorDelegate<T> comparer)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer(array[i], array[j]) < 0)
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T aux = a;
            a = b;
            b = aux;
        }


        //lamda es pasar en vez de un parametro una funcion, y en funcion de lo que devuelva esa funcion haces una cosa u otra.

    }
}
