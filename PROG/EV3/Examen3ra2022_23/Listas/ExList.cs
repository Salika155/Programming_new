using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Listas
{
    internal class ExList<T>
    {
        private T[] array;

        public int Count { get; set; }
        public T First
        {
            get
            {
                if (Count == 0)
                    throw new InvalidOperationException("The list is empty.");
                return array[0];
            }
        }

        public T Last
        {
            get
            {
                if(Count == 0)
                    throw new InvalidOperationException("The list is empty.");
                return array[Count - 1];
            }
        }

        public T[] Reversed
        {
            get
            {
                T[] reversedArray = new T[Count];
                for (int i = 0; i < Count; i++)
                {
                    reversedArray[i] = array[Count - i - 1];
                }
                return reversedArray;
            }
        }

        public T GetElementAt(int index)
        {
            if (index < 0 || index >= Count)
                return array [0];
            return array[index];
        }

        public void SetElementAt(int index, T element)
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException(nameof(index));
            array[index] = element;
        }

        public void Add(T item)
        {
            if (Count == array.Length)
            {
                T[] arrayNuevo = new T[array.Length + 1];
                for (int i = 0; i < array.Length; i++)
                {
                    arrayNuevo[i] = array[i];
                }
                array = arrayNuevo;
            }
            array[Count] = item;
            Count++;
        }

        public void Remove(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Count--;
        }

        public void Clear()
        {
            array = new T[0];
            Count = 0;
        }



    }
}
