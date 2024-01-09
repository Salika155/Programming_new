using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DamLib
{
    public class Queue<T>
    {
        //Queue<T>
        private T[] _queue = new T[0];
        private int _count = 0;

        //- _queue:T[]

        //+Queue(element:T)


        public void EnQueue(T element)
        {
            T[] queueAux = new T[_queue.Length + 1];
            for (int i = 1; i < _queue.Length - 1; i++)
            {
                queueAux[i] = _queue[i];
            }
            queueAux[queueAux.Length - 1] = element;
            _queue = queueAux;
        }

        //+Dequeue():T

        public void Dequeue(T element)
        {

        }
        //a partir de aqui mayusculas son properties excepto clear

        //+Count:int;

        public int Count
        {
            get => _count;
        }


        //+First:T

        public T First
        {
            get
            {
                if (Empty)
                    return default(T);
                return (_queue[Count - 1]);
            }
        }
        //+Last:T

        public T Last
        {
            get
            {
                if (Empty)
                    return default(T);
            }
            return (_queue[0])

    
           

    
        
        //+Clear();

        //+Empty:bool

        public bool Empty
        {
            get => _count == 0;
        }

    }
}
