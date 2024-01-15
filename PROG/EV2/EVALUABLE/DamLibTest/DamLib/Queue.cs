using System;
using System.Collections;
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
            
            T[] queueAux = new T[_count + 1];
            for (int i = 0; i < _count; i++)
            {
                queueAux[i] = _queue[i];
            }
            queueAux[_count] = element;
            _queue = queueAux;
            
        }

        //+Dequeue():T

        public T? Dequeue()
        {
            if (Empty)
                return default(T);

            T dequeuedElement = _queue[0];

            T[] deQueueAux = new T[_count - 1];
            for (int  i = 0; i < _count - 1; i++)
            {
                deQueueAux[i] = _queue[i + 1];
            }
            _queue = deQueueAux;
            _count--;

            return dequeuedElement;
        }
        //a partir de aqui mayusculas son properties excepto clear

        //+Count:int;

        public int Count
        {
            get => _count;
        }


        //+First:T

        public T? First
        {
            get
            {
                if (Empty)
                {
                    return default(T);
                }
                return _queue[0]; 
            }
        }

        //public T First => IsEmpty ? default(T) : _queue[0];

        //evitar warning default con una directiva de procesador
#nullable disable
        //en estas lineas no avisara del warning del null
#nullable enable
        //+Last:T

        public T? Last
        {
            get
            {
                if (Empty)
                {
                    return default(T);
                }
                return _queue[_count - 1];
            }
        }

        //+Clear();
        public void Clear()
        {
            _queue = new T[0];
            _count = 0;
        }

        //+Empty:bool
        public bool Empty
        {
            get => _count == 0;
        }
    }
}
