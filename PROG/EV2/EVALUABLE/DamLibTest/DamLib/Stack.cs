using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DamLib
{
    public class Stack<T>
    {
        //Stack<T>
        //- _stack:T[]
        private T[] _stack = new T[0];

        //+Push(newElement:T);
        public void Push(T newElement)
        {
            T[] stackAux = new T[_stack.Length + 1];
            for (int i = 0; i < _stack.Length; i++)
            {
                stackAux[i] = _stack[i];
            }
            stackAux[stackAux.Length - 1] = newElement;
            _stack = stackAux;
        }

        //+Pop():T;
        public T? Pop()
        {
            if (_stack.Length == 0)
                return default(T);

            T popElement = _stack[_stack.Length - 1];

            T[] stackAux = new T[_stack.Length - 1];
            for (int i = 0; i < _stack.Length - 1; i++)
            {
                stackAux[i] = _stack[i];
            }
            _stack = stackAux;
            return popElement;
        }

        //+GetTop():T;
        public T? GetTop()
        {
            if (_stack.Length == 0)
                return default(T);

            return _stack[_stack.Length - 1];
        }

        //+IsEmpty():bool
        public bool IsEmpty()
        {
            //si el tamaño es 0, esta vacio
            return _stack.Length == 0;
        }

        //+GetCount():int
        public int GetCount()
        {
            return _stack.Length;
        }

        //-> Libreria -> DAMLibTest
        //DAMlibTest
        //DAMLib -> nuevo proyecto a añadir en la libreria (Biblioteca de clases)
    }
}
