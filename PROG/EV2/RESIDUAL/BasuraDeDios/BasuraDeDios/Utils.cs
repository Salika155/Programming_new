using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraDeDios
{

    public delegate int ComparatorDelegate<T>(T n1, T n2);
    public class Utils
    {
        public static void Swap<T>(ref T a, ref T b)
        {

            T aux = a;
            a = b;
            b = aux;
        }

        public static void Sort<T>(T[] array, ComparatorDelegate<T> comparer)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer(array[i], array[j]) < 0)
                    {
                        Swap(ref array[i],ref array[j]);
                    }
                }
            }
        }
    }
}



//CUANDO creas un objeto en memoria se guarda en el heap, y un struct, que es como una variable se guardaria en el stack, que es de tamaño fijo, no como el heap  que es variable
//En el stack se copia la variable de los parametros de la funcion, el resultado, y la referencia
//cuando es struc no creas objetos, estas apuntando al stack
//si una variable es parte de un objeto que se encuentra en el heap, esta variable y clase siguen estando dentro del heap
//referencetypes y valuetypes
//struct como un entero donde mete cosas a 0 directamenjte, son menos ciclos de reloj y no reserva espacio en el heap de lo que puede ser una nueva clase,
//diferenciar entre si querer hacer una copia o que apunten al mismo sitio

//clase inmutable y que no herede de nadie
//class, struct y record
record Student(string Name, int Age)
{
    int Curso { get; set; }
}
//esencia de que todos sus parametros sean readonly
//esto es un objeto referenciado creado en el heap
