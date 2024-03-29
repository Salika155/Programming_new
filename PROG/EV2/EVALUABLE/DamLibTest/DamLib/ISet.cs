using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamLib
{
    public interface ISet<T>
    {
        bool Empty => Count == 0;
        int Count { get; }
        void Clear();
        void Add(T item);
        void Remove(T item);
        bool Contains(T item);

        //pruebas unitarias
    }
}
