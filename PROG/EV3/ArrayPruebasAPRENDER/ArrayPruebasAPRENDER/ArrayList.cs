
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPruebasAPRENDER
{
    internal class FuncionesArrayList
    {
        // Función que cuenta el número de valores mayores que cero en una lista de tipo double
        public static int GetValoresMayoresDeZero(List<double> valores)
        {
            int result = 0;

            for (int i = 0; i < valores.Count; i++)
            {
                if (valores[i] > 0)
                    result++;
            }
            return result;
        }

        // Función que devuelve la cantidad de elementos en una lista de strings
        public static int CountElements(List<string> strings)
        {
            return strings.Count;
        }

        // Función que devuelve la cantidad de elementos en un array
        public static int CountArrayElements(int[] elements)
        {
            return elements.Length;
        }

        // Función que cuenta el número de arrays en los que la longitud sea mayor que cero
        public static int GreatherThanZero(Array[] array)
        {
            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > 0)
                    result++; 
            }
            return result;
        }

        // Función que verifica si un número está contenido en una lista de tipo double
        public static bool ContainInList(List<int> list, int n)
        {
            if (list == null)
                return false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == n)
                    return true;
            }
            return false;
        }


        // Función que verifica si un número está contenido en una lista de tipo double (versión con manejo de null)
        public static bool ContainInListD(List<double> list, double n)
        {
            if (list == null)
                return false;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == n)
                    return true;
            }
            return false;
        }

        // Función que devuelve el valor mayor de una lista de enteros
        public static int MayorDeLista(List<int> numero)
        {
            if (numero == null || numero.Count > 0)
                return int.MinValue;

            int max = numero[0];

            for (int i = 0; i < numero.Count; i++)
            {
                if (numero[i] > max)
                    max = numero[i];
            }
            return max;
        }

        // Función que devuelve la posición del número mayor en una lista de enteros
        public static int GetPositionInList(List<int> numero) //tambien conocido como indexof
        {
            if (numero == null || numero.Count < 0)
                return int.MinValue;

            int poscmax = numero[0];
            int index = 0;

            for (int i = 0; i < numero.Count; i++)
            {
                if (numero[i] > poscmax)
                {
                    poscmax = numero[i];
                    index = i;
                }   
            }
            return index;
        }

        // Función que verifica si una lista de enteros está ordenada de manera ascendente
        public static bool IsOrdered(List<int> numerospaordenar)
        {
            if (numerospaordenar == null || numerospaordenar.Count <= 1)
                return true;

            for (int i = 0; i < numerospaordenar.Count; i++)
            {
                if (numerospaordenar[i] < numerospaordenar[i] - 1)
                    return false;
            }
            return true;
        }

        // Función que verifica si una lista de enteros está ordenada de manera ascendente (versión mejorada)
        public static bool IsOrderedAsc(List<int> listanumasc)
        {
            if (listanumasc == null || listanumasc.Count <= 1)
                return true;

            int numAnterior = listanumasc[0];

            for (int i = 0; i < listanumasc.Count; i++)
            {
                int current = listanumasc[i];

                if (current < numAnterior)
                    return false;

                numAnterior = current;
            }
            return true;
        }

        // Función que verifica si un número está contenido en un array de enteros
        public static bool ContieneElArray(int[] array, int index)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == index) 
                    return true;
            }
            return false;
        }


        // Búsqueda binaria en un array de enteros
        public static bool BinarySearch(int[] array, int index)
        {
            // Verificar si el array es nulo o está vacío
            if (array == null || array.Length == 0)
                return false;

            // Inicializar los índices mínimo y máximo para la búsqueda binaria
            int min = int.MinValue;
            int max = array.Length - 1;

            // Realizar la búsqueda binaria
            while (min <= max)
            {
                // Calcular el índice medio del rango actual
                int med = ((min + max) / 2);

                // Comprobar si el índice medio es igual al índice buscado
                if (med == index)
                    return true;
                // Si el índice medio es menor que el índice buscado, ajustar el índice mínimo
                else if (med < index)
                    min = med + 1;
                // Si el índice medio es mayor que el índice buscado, ajustar el índice máximo
                else if (med > index)
                    max = med - 1;
            }
            // Si se termina el ciclo while y no se ha encontrado el índice, retornar false
            return false;
        }


        // Calcula el promedio de un array de enteros
        public static double GetAvgArray(int[] array)
        {
            // Verificar si el array es nulo
            if (array == null)
                return double.NaN; // Devuelve NaN (Not a Number) si el array es nulo

            // Inicializar una variable auxiliar para almacenar la suma de los elementos del array
            double aux = 0.0;

            // Iterar sobre cada elemento del array y sumarlo a la variable auxiliar
            for (int i = 0; i < array.Length; i++)
            {
                aux += array[i]; // Sumar el valor del elemento actual al total acumulado
            }

            // Calcular el promedio dividiendo la suma total por la cantidad de elementos en el array
            return aux / array.Length; // Devuelve el promedio de los elementos del array
        }

        // Calcula el promedio de los valores que superan un umbral en un array de enteros


        // Calcula el número de veces que se repite el número mayor en una lista de enteros
        public static int GetNumVecesRepiteMayor(List<int> list)
        {
            if (list == null || list.Count == 0)
                return 0;

            int max = list[0];

            foreach (var l in list)
            {
                if (l > max)
                    max = l;
            }

            int count = 0;

            foreach (var l in list)
            {
                if (l == max)
                    count++;
            }
            return count;
        }

        // Invierte una lista de enteros
        public static List<int> InvertValors(List<int> list)
        {
            List<int> listaord = new();

            if (list == null || list.Count == 0)
                return new List<int>();

            for (int i = list.Count - 1; i < 0; i--)
                list.Add(listaord[i]);
            return listaord;
        }

        // Invierte una lista de enteros
        public static List<int>? InvertirLista(List<int> list)
        {
            // Verificar si la lista es nula o tiene solo un elemento (ya está invertida)
            if (list == null || list.Count <= 1)
                return list;

            // Calcular la mitad de la longitud de la lista
            int n = list.Count;
            int middle = n / 2;

            // Iterar sobre la mitad de la lista
            for (int i = 0; i < middle; i++)
            {
                // Intercambiar el elemento en la posición i con el elemento en la posición n - 1 - i
                int temp = list[i];
                list[i] = list[n - 1 - i];
                list[n - 1 - i] = temp;
            }
            return list;
        }

        // Otra forma de invertir una lista de enteros
        public static List<int>? InvertirLista1(List<int> list)
        {
            if (list == null)
                return null;

            // Crear una nueva lista para almacenar la lista invertida
            List<int> sinordenar = new List<int>(list.Count);

            // Iterar sobre cada elemento de la lista de entrada
            for (int i = 0; i < list.Count; i++)
            {
                // Agregar elementos a la lista sinordenar en orden invertido
                // list.Count - 1 - i calcula el índice inverso para invertir la lista
                sinordenar.Add(list[list.Count - 1 - i]);
            }
            return sinordenar;
        }


        // Imprime los elementos de una lista de enteros en pantalla
        public static void ImprimirLista(List<int> list)
        {
            if (list == null || list.Count == 0)
                return;

            list.Add(4);
            list.Add(34);
            list.Add(75);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        // Devuelve un array de enteros ordenado de manera descendente
        public static int[]? ArrayEnterosOrdDesc(int[] array)
        {
            if (array == null)
                return null;

           for (int i = 0; i < array.Length - 1; i++)
           {
                for (int j = i - 1; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temporal = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temporal;
                    }
                }
           }
            return array;
        }


        //TODO: here
        // Añade un elemento a un array de enteros
        public static int[]? AddToArray(int[] array, int n)
        {
            if (array == null)
                return null;

            int[] result = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i];
            }
            // Agregar el nuevo elemento al final del nuevo array
            result[array.Length] = n;
            return result;
        }

        // Ordena un array de enteros (short)
        public static int[]? ArrayEnterosOrdered(int[] arraydes)
        {
            if (arraydes == null)
                return null;

            for (int i = 0; i < arraydes.Length - 1; i++)
            {
                for (int j = 0; j < arraydes.Length - 1 - i; j++)
                {
                    if (arraydes[j] > arraydes[j + 1])
                    {
                        // Intercambiar los elementos si están en el orden incorrecto
                        int temp = arraydes[j];
                        arraydes[j] = arraydes[j + 1];
                        arraydes[j + 1] = temp;
                    }
                }
            }
            return arraydes;
        }
        //hacer a partir de aqui

        // Ordena una lista de enteros (short lista)
        public static List<int>? OrderList(List<int> list)
        {
            if (list == null)
                return null;

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        // Intercambia los elementos
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }

        public static List<int> SortLista(List<int> listashort)
        {

            //int n = listashort.Count; -> caso especial
            //int n2 = n1 - 1;
            //for (int i = 0; i < n; i++)
            for (int i = 0; i < listashort.Count - 1; i++)
            {
                //for(<n2;)
                for (int j = i + 1; j < listashort.Count; j++)
                {
                    if (listashort[i] > listashort[j])
                    {
                        int aux;
                        aux = listashort[i];
                        listashort[i] = listashort[j];
                        listashort[j] = aux;
                    }
                }
            }
            return listashort;
        }

        // Calcula la serie de Collatz para un número dado


        // Devuelve los dos elementos mayores de una lista de enteros
        public static List<int>? GetTwoElementsBigger(List<int> list)
        {
            if (list == null || list.Count < 2)
                return null;

            List<int> mayores = new List<int>();

            int max1 = int.MinValue;
            int max2 = int.MinValue;

            for (int i = 0; i < mayores.Count; i++)
            {
                int elem = mayores[i];
                if (elem > max1)
                {
                    max2 = max1;
                    max1 = elem;
                }
                else if (elem > max2)
                    max2 = elem;
            }
            mayores.Add(max1);
            mayores.Add(max2);
            return mayores;
        }

        // Devuelve una lista con los elementos pares de una lista de enteros
        public static List<int>? GetParesLista(List<int> elem)
        {
            if (elem == null)
                return null;

            List<int> result = new List<int>();

            for (int i = 0; i < elem.Count; i++)
            {
                int element = elem[i];
                if (element % 2 == 0)
                    result.Add(element);
            }
            return result;
        }

        // Devuelve un array con los elementos pares de una lista de enteros
        public static int[]? ArrayPares(int[] array)
        {
            if (array == null)
                return null;

            int count = 0;

            // Contar la cantidad de elementos pares
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    count++;
                }
            }

            // Crear un nuevo array con el tamaño exacto para almacenar solo los elementos pares
            int[] result = new int[count];

            // Almacenar solo los elementos pares en el nuevo array
            int index = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    result[index] = num;
                    index++;
                }
            }
            return result;
        }

        // Elimina un elemento en una posición dada de una lista de enteros
        public static void RemoveElemenFromList(List<int> list, int n)
        {
            if (list == null)
                return;
            list.RemoveAt(n);
        }

        public static int FindIndex(List<int> list, int value)
        {
            if (list == null)
                return -1; // Retorna -1 si la lista es nula

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    return i; // Retorna el índice del elemento si se encuentra
                }
            }

            return -1; // Retorna -1 si el elemento no se encuentra en la lista
        }

        // Elimina todas las ocurrencias de un valor dado en una lista de enteros

        public static List<int>? RemoveValueFromList(List<int> list, int value)
        {
            if (list == null)
                return null;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    list.RemoveAt(i);
                    i--; // Restamos 1 al índice para compensar la eliminación
                }
            }
            return list;
        }//prefiero devolver la lista para trabajar con ella, o en todo caso podria hacer un clon

        // Elimina todas las ocurrencias de un valor dado en un array de enteros
        // Elimina todas las ocurrencias de un valor dado en un array de enteros
        public static int[]? RemovePositionArray(int[] array, int n)
        {
            if (array == null)
                return null;

            // Cuenta cuántas veces aparece el valor 'n' en el array 'array'
            int count = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i] == n)
                    count++;

            // Crea un nuevo array con una longitud igual a la longitud del array original menos el número de ocurrencias del valor 'n'
            int[] result = new int[array.Length - count];

            // Inicializa un contador 'j' que se usará para llenar el nuevo array 'result'
            int j = 0;

            // Recorre todo el array original 'array'
            for (int i = 0; i < array.Length; i++)
            {
                // Comprueba si el elemento actual del array no es igual al valor 'n'
                if (array[i] != n)
                    // Si el elemento actual no es igual a 'n', se asigna ese elemento al nuevo array 'result' en la posición 'j' y se incrementa 'j'
                    result[j++] = array[i];
            }

            // Devuelve el nuevo array 'result' que contiene todos los elementos que no son 'n'
            return result;
        }

        // Cuenta el número de ocurrencias de un valor dado en un array de enteros
        public static int CountElements(int[] array, int n)
        {
            if (array == null)
                return 0;

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                    count++;
            }
            return count;
        }

        // Elimina los valores de una lista de enteros que están contenidos en otra lista
        public static void RemoveValuesFromList(List<int> l1, List<int> l2)
        {
            if (l1 == null || l2 == null)
                return;

            for (int i = 0; i < l1.Count; i++)
            {
                if (Contains(l2, l1[i]))
                {
                    l1.RemoveAt(i);
                    i--; // Disminuye el índice para compensar la eliminación
                }
            }
        }

        public static bool Contains(List<int> list, int value)
        {
            foreach (int item in list)
            {
                if (item == value)
                {
                    return true;
                }
            }
            return false;
        }


        // Elimina los valores de un array de enteros que están contenidos en otro array
        // Verifica si un valor está contenido en un array de enteros
        private static bool Contains(int[] array, int value)
        {
            foreach (int item in array)
            {
                if (item == value)
                {
                    return true;
                }
            }
            return false;
        }

        // Elimina los valores de un array de enteros que están contenidos en otro array
        public static int[] RemoveValuesFromArray(int[] array1, int[] array2)
        {
            if (array1 == null || array2 == null)
                return null;

            List<int> result = new List<int>();

            foreach (int item in array1)
            {
                if (!Contains(array2, item))
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }

    }

}
