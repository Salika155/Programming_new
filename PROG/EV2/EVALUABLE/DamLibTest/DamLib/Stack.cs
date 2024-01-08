using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DamLib
{
    public class Stack <T>
    {
        //Stack<T>

        //- _stack:T[]
        private T[] _stack = new T[0]; 
        //+Push(newElement:T);

        public void Push(T newElement)
        {
            T[] stackAux = new T[_stack.Length + 1];
            for (int i = 0; i < _stack.Length - 1; i++)
            {
                stackAux[i] = _stack[i];
            }
            stackAux[stackAux.Length - 1] = newElement;
            _stack = stackAux;
            
        }
        //+Pop():T;

        public T Pop()
        {
            if ((_stack.Length == 0) || (_stack == null)) 
            for (int i = 0; i < _stack.Length; i++)
            {
                _stack[i] = newElement;
            }
        }
        //+GetTop():T;

        public T GetTop()
        {
            return _stack[_stack.Length - 1];
        }
        //+IsEmpty():bool


        //+GetCount():int
        public int GetCount()
        {
            return _stack.Length;
        }



        //-> Libreria -> DAMLibTest
        //DAMlibTest
        //DAMLib -> nuevo proyecto a añadir en la libreria (Biblioteca de clases


    }
}
