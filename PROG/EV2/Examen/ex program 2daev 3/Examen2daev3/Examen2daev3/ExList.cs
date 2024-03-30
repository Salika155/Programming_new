using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2daev3
{
    public class ExList<T>
    {
        T[] _list = new T[0];

        // Javi: Se puede saber por qué diantres has puesto esto private?!?!?!!?!?!?!?
        private int Count { get { return _list.Length; } }
        // Javi: Mal
        private T First { get { return _list[0]; } }
        // Javi: Mal
        private T Last { get { return _list[Count]; } }
        // Javi: Sin implementar
        //private T Reversed { get { return _list.Reverse(); } }

        public ExList()
        {
            // Javi: Mal
            T[] _list = new T[0];
        }

        // Javi: Devuelve un int!??!!?!?!?!?!?!?!?!?!??!!?
        public int GetElementAt(int index)
        {
            if (index < 0 || index >= _list.Length)
                return default;
            // Javi: Sólo por esto, está todo el examen mal
            for (int i = 0; i < _list.Length; i++)
            {

                return i;
            }
            return default;
        }

        // Javi: No entiendo nada
        public T[] Reverse(T item)
        {
            T[] _list = new T[0];
            for (int i = 1, j = i + 1; i < _list.Length; i++)
            {
                item = _list[i];
                _list[i] = _list[j];
                _list[j] = item;
                i++;
                j--;
            }
            return _list;
        }

        // Javi: Mal
        public void SetElementAt(int index, T element)
        {
            if (index < 0 || index > _list.Length)
                return;


            for (int i = 0; i < _list.Length; ++i)
            {

                _list[i] = element;



            }

        }

        // Javi: Mal
        public void Add(T element)
        {
            if (element == null)
                return;

            Add(element);
        }

        public T RemoveAt(int index)
        {
            for (int i = 0; i < _list.Length; i++)
            {
                for (int j = i + 1; j < _list.GetLength(i); j++)
                {
                    T[] arraynuevo = new T[_list.Length - 1];
                    //if (_list[i] = 

                }


            }
            return (T)_list[index];
        }

        public void Clear()
        {
            // Javi: Mal
            T[] _list = new T[0];
        }



        public int IndexOf(T element)
        {
            if (element == null)
                return -1;
            for (int i = 0; i <= _list.Length; i++)
            {
                if (element.Equals(_list[i]))
                    return i;
            }
            return -1;
        }

        public bool Contains(T element)
        {
            // Javi: Ya dije que esto no se podía hacer
            return _list.Contains(element);

        }




    }
}
