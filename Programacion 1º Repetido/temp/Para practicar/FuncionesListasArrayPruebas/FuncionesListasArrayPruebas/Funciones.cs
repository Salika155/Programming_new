using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesListasArrayPruebas
{
    internal class Funciones
    {

        //Funcion numero de valores mayor que cero lista

        public static int GetValorMayorCeroL(List<double> l)
        {
            int result = 0;

            for (int i = 0; i < l.Count; i++) 
            {
                if(l[i] > 0.0)
                result++;
            }
            return result;
        }

        //Cuantos elementos tiene la lista

        public static int ElementosEnLista(List<double> l1)
        {
            return l1.Count;
        }

        //Cuantos elementos tiene el array

        public static int ElementosEnArray(int[] a)
        {
            return a.Length;
        }

        //Funcion valores mayor que cero array

        public static int GetValorMayorCeroA(double[] a1)
        {
            int result = 0;
            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] > 0)
                result++;
                
            }
            return result;
        }

        //quiero una funcion que le paso una lista de enteros y un numero, y me tiene que decir si ese numero esta en la lista o no

        public static bool EstaEnLaLista(List<double> l2, int n) 
        { 
            if (l2== null) 
                return false;

            for (int i = 0; i < l2.Count; i++) 
            {
                if (l2[i] == n)
                    return true;
            }
            return false;
        }

        //Me pasan una lista de enteros y me dice el numero mayor que hay en esa lista de enteros

        public static int NumeroMayorLista(List<int> l3) 
        {
            if (l3.Count== 0 || l3 == null)
                    return int.MinValue;

            int max = l3[0];

            for (int i = 1; i < l3.Count; i++)
            {
                if (l3[i] > max)
                    max = l3[i];
            }
            return max;
        }

        //Pasar una lista de enteros, quiero devolver la posicion donde se encuentra el valor mas alto de la lista.

        public static int GetPosicionEnLista(List<int> l4)
        {
            if (l4 == null || l4.Count == 0)
                return -1;

            int max = l4[0]; 
            int index = 0;

            for (int i = 0; i < l4.Count; i++) 
            {
                if (l4[i] > max)
                {
                    max = l4[i];
                    index = i;
                }    
            }
            return index;
        }

        //Funcion que le paso una lista de enteros y me dice si esta ordenada o no de manera ascendente

        public static bool ListaEnterosOrdenadaAsc(List<int> l5)
        {
            for (int i = 1; i > l5.Count; i++) 
            {
                if (l5[i] < l5[i - 1])
                    return false;
            }
            return true;
        }

        //Contiene elemento dentro del array

        public static bool EstaEnElArray(int[] arrays, int n) 
        {
            if (arrays == null)
                return false;

            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i] == n)
                    return true;
            }
            return false;
        } 

        //Le paso un numero y compruebo dentro de la lista si esta mediante el binarysearch
        //punto medio, comparo y muevo valores binarysearch

        public static bool BinarySearch(List<int> l6, int n)
        {
            int min = 0;
            int max = l6.Count;
            return true;
        }

        //funcion que se le pasa un array de dobles y devuelve la media de todos los valores que hay ahi

        //Funcion que le pasas un array y un umbral y tiene que devolver la media de todos estos valores pero solamente de aquellos que superen este numero

        // Funcion que le paso una lista de enteros y me devuelve un entero. Devuelve numero de veces que se repite el numero mas alto

        // Funcion que necesita como parametro una lista de enteros, y me tiene que devolver una lista de enteros pero al reves de la lista que le he metido
        // [0, 7, -1, 8] -> [8, -1, 7, 0]

        //Funcion que le paso una lista de enteros y los imprime por pantalla

        //Funcion que necesita como parametro un array de enteros, y me tiene que devolver un array de enteros pero al reves del array que le he metido

        //Funcion que le paso un array de enteros, y un entero, y quiero que esa funcion añada el entero que se le pasa al array

        //algoritmo de la burbuja

        //l, i, j

        //swap
        //int aux;
        //aux = l[i];
        //l[i[ = l[j];
        //l[j] == aux;

        //sort array

        //sort lista

        //collatz serie 3n + 1
        //Funcion que le paso un numero y me devuelva la serie de collatz de ese numero
        //si es par divida entre 2
        //si es impar multiplique por 3 y le sume 1

        //Funcion que le pase una lista y me devuelva una lista con los dos elementos mayores

        //Funcion que le pasas una lista de enteros y quiero que me devuelvas otra lista pero solo con los numeros pares que haya en esa lista

        //hallar los numeros pares de un array

        // Funcion que le paso una lista de enteros y le paso una posicion. Lo que tiene que hacer esta funcion es borrar el elemento de esa posicion en la lista

        //[0, 7, 1, 8, 4]
        // Funcion paso una lista y un valor. Tiene que borrar de la lista el numero 8 sin usar el Remove.

        //Funcion igual con array

        //RemoveValues que estan en una lista 

        //removevalues para array




    }
}
