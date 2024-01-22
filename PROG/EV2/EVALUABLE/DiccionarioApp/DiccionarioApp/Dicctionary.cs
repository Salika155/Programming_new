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

        public int Count => 0;
        public bool IsEmpty => true;

        public void Clear()
        {

        }

        public void Add(K key, V value)
        {
            //if key es igual que sale un throw new exception

        }

        public void AddOrReplace(K key, V value)
        {

        }

        public bool Contains(K key)
        {
            return false;
        }

        public void Remove(K key)
        {

        }

        public V GetValueWithKey(K key)
        {

        }

        public bool TryGetValue(K key, out V value)
        {

        }

        public Dicctionary<K, V> Filter(DiccionaryFilterDelegate<K,V> where, Dicctionary<K, V> ret)
        {
            
            var ret = new Dictionary<K, V>();

            for (int i = 0; i < _items.Length; i++)
            {
                Item item = _items[i];
                bool addToNewDictionary = where(item.key, item.value);
                
            }
            return ret;
        }

        //void Remove


        //lamda es pasar en vez de un parametro una funcion, y en funcion de lo que devuelva esa funcion haces una cosa u otra.

    }
}
