using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiccionarioPruebaBasura
{
    public class DiccionarioSimple<K, V>
    {

        //Ejercicios sobre Diccionarios:
        //1. Diccionario Simple:
        //Crea una clase llamada MyDictionary<K, V> que implemente un diccionario simple.
        //Debe tener métodos para agregar, eliminar y obtener elementos, y para verificar si una clave existe.

        private DiccionarioSimple<K, V> _diccionario = new DiccionarioSimple<K, V>();

        public void Add(K key, V value)
        {
            _diccionario.Add(key, value);
        }

        //remove
        //getvalue
        //contains



    }
}
