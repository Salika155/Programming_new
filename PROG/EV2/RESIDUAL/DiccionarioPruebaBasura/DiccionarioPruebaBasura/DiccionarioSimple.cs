using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DiccionarioPruebaBasura
{
    public delegate bool DictionaryFilterDelegate<K, V>(K key, V value);
    public class DiccionarioSimple<K, V>
    {

        //Ejercicios sobre Diccionarios:
        //1. Diccionario Simple:
        //Crea una clase llamada MyDictionary<K, V> que implemente un diccionario simple.
        //Debe tener métodos para agregar, eliminar y obtener elementos, y para verificar si una clave existe.
        private class Item
        {
            public K key;
            public V value;
        }

        private Item[] _items = new Item[0];

        private DiccionarioSimple<K, V> _diccionario = new DiccionarioSimple<K, V>();

        public DiccionarioSimple()
        {
            _items = new Item[0];

        }

        //Count
        public int Count => _items.Length;
        //Empty
        public bool IsEmpty => Count == 0;
        //Clear
        public void Clear()
        {
            _items = new Item[0];
        }

        //Add
        public void Add(K key, V value)
        {
            Item[] newArray = new Item[_items.Length + 1];
            for (int i = 0; i < _items.Length; i++)
            {
                newArray[i] = _items[i];
            }
            newArray[_items.Length] = new Item 
            { key = key, 
                value = value 
            };
            _items = newArray;
        }
        
        //DictionaryFilterDelegate

        //Filter

        public DiccionarioSimple<K, V> Filter(DictionaryFilterDelegate<K, V> where)
        {
            var result = new DiccionarioSimple<K, V>();

            for (int i = 0; i < _items.Length; i++)
            {
                Item item = _items[i];
                bool condition = where(item.key, item.value);
                if (condition)
                {
                    result.Add(item.key, item.value);
                }
            }
            return result;
        }

        //Remove

        public void Remove(DictionaryFilterDelegate<K, V> where)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                Item item = new Item();
                bool condition = where(item.key, item.value);
                if (condition)
                {
                    Remove(item.key);
                    i--;
                }
            }

        }

        private void Remove(K? key)
        {
            throw new NotImplementedException();
        }

        //TryGetValue

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

        //Contains

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

        //IndexOf

        public int IndexOf(K key)
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


    }
}
