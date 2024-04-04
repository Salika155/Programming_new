

namespace ArrayList
{
    
    internal class FuncionesArrayList
    {
        //Funcion numero de valores mayor que cero lista
        public static int GreaterThanZeroCount(List<double> list)
        {
            int result = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 0.0)
                    result++;
            }
            return result;
        }

        //Cuantos elementos tiene la lista
        public static int FuncLista1(List<string> list)
        {
            return list.Count;
        }

        //internal static int GreatLesserThanZero(List<string> l2)
        //{
        //    throw new NotImplementedException();
        //}

        //Cuantos elementos tiene el array
        public static int FuncArray1(Array[] arrays)
        {
            return arrays.Length;
        }

        public static int GreatherThanZero(Array[] arrays)
        {
            int result = 0;
            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i].Length > 0.0)
                    result++;
            }
            return result;
        }

        //quiero una funcion que le paso una lista de enteros y un numero, y me tiene que decir si ese numero esta en la lista o no


        public static bool ContainsInList(List<double> listaenteros, int n)
        {
            if (listaenteros == null)
                return false;

            for (int i = 0; i < listaenteros.Count; i++)
            {
                if (listaenteros[i] == n)
                    return true;
            }
            return false;
        }

        public static bool ContainsInList1(List<double> listaenteros, int n)
        {
            if (listaenteros != null)
            {
                for (int i = 0; i < listaenteros.Count; i++)
                {
                    if (listaenteros[i] == n)
                        return true;
                }
            }
            return false;
        }

        // #Region comprobacion de parametros -> titulo dado a una seccion desplegable para comprimir codigo.
        //#endregion

        //Me pasan una lista de enteros y me dice el numero mayor que hay en esa lista de enteros


        /// <summary>
        /// Funcion que devuelve el valor mayor de una lista de enteros
        /// </summary>
        /// <param name="listamayor">lista de enteros</param>
        /// <returns>numero mas alto, si n es null devuelve int.MinValue</returns>
        public static int EsElMayorNumero(List<int> listamayor)
        {
            if (listamayor == null || listamayor.Count == 0)
                return int.MinValue;

            int max = listamayor[0];

            for (int i = 1; i < listamayor.Count; i++)
            {
                if (listamayor[i] > max)
                    max = listamayor[i];
            }
            return max;
        }

        //Pasar una lista de enteros, quiero devolver la posicion donde se encuentra el valor mas alto de la lista.

        public static int GetPosicionLista(List<int> listapos)
        {
            if (listapos == null || listapos.Count == 0)
                return -1;

            int max = listapos[0];
            int index = 0;

            for (int i = 0; i < listapos.Count; i++)
            {
                if (listapos[i] > max)
                {
                    max = listapos[i];
                    index = i;

                }
            }
            return index;
        }

        //Funcion que le paso una lista de enteros y me dice si esta ordenada o no de manera ascendente

        public static bool IsOrderedAsc(List<int> listaordenada)
        {
            if (listaordenada == null || listaordenada.Count <= 1)
                return true;

            //int v1 = listaordenada[0];
            //int v2 = listaordenada[1];
            //int index = 0;

            for (int i = 1; i < listaordenada.Count; i++)
            {
                if (listaordenada[i] < listaordenada[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        //lista ordenada de otra manera
        public static bool IsOrderedAsc1(List<int> listaordenada)
        {
            if (listaordenada == null || listaordenada.Count <= 1)
                return true;

            int prevValue = listaordenada[0];

            for (int i = 1; i < listaordenada.Count; i++)
            {
                int currentValue = listaordenada[i];

                if (currentValue < prevValue)
                    return false;

                prevValue = currentValue;
            }
            return true;
        }

        //Contiene elemento dentro del array
        public static bool Contains(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    return true;
            }
            return false;
        } 

        //punto medio, comparo y muevo valores

        public static bool BinarySearch(int[] array1, int value)
        {
            if (array1 == null || array1.Length == 0)
                return false;

            int min = 0;
            int max = array1.Length - 1;

            while (min <= max)
            {
                int med = ((min + max) / 2); 

                if (array1[med] == value)
                    return true;
                else if (array1[med] < value)
                    min = med + 1;
                else if (array1[med] > value)
                    max = med - 1;
            }
            return false;

        }

        //funcion que se le pasa un array de dobles y devuelve la media de todos los valores que hay ahi

        public static double GetAvg(int[] array2)
        {
            if (array2 == null)
            {
                return double.NaN;
            }
            double aux = 0.0;

            for (int i = 0; i < array2.Length; i++)
            {
                aux += array2[i];
            }
            return aux / array2.Length;
        }

        //Funcion que le pasas un array y un umbral y tiene que devolver la media de todos estos valores pero solamente de aquellos que superen este numero

        public static double GetThreshold(int[] array2, double threshold)
        {
            if (array2 == null)
                return double.NaN;

            double avg = 0.0;
            int count = 0;

            for (int i = 0; i < array2.Length; i++)
            {

                if (array2[i] >= threshold)
                {
                    avg += array2[i];
                    count++;
                }
                if (count == 0)
                    return double.NaN;
            }
            return avg / count;

        }

        // Funcion que le paso una lista de enteros y me devuelve un entero. Devuelve numero de veces que se repite el numero mas alto

        public static int GetNumberMayorRepeated(List<int> listasinordenar)
        {
            if (listasinordenar == null || listasinordenar.Count < 1)
                return -1;

            int countrepet = 1;
            int max = listasinordenar[0];


            for (int i = 1; i < listasinordenar.Count; i++)
            {
                //rehacer
                if (listasinordenar[i] == GetNumberMayorRepeated(listasinordenar))
                    countrepet++;
            }
            return countrepet;

        }

        // Funcion que necesita como parametro una lista de enteros, y me tiene que devolver una lista de enteros pero al reves de la lista que le he metido
        // [0, 7, -1, 8] -> [8, -1, 7, 0]

        public static List<int> SwapValores(List<int> listasinordenar)
        {
            List<int> list = new List<int>();

            if (listasinordenar == null || listasinordenar.Count == 0)
                return new List<int>();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                list.Add(list[i]);
            }
            return list;
        }

        //Funcion que le paso una lista de enteros y los imprime por pantalla

        public static void WriteForScreen(List<int> nuevalista)
        {
            if (nuevalista == null)
                return;
            nuevalista.Add(5);
            nuevalista.Add(74);
            nuevalista.Add(43);
            nuevalista.Add(9);
            nuevalista.Add(36);

            for (int i = 0; i < nuevalista.Count; i++)
            {
                Console.Write(nuevalista[i] + ",");
                //
            }
        }


        //Funcion que necesita como parametro un array de enteros, y me tiene que devolver un array de enteros pero al reves del array que le he metido

        public static int[]? ArrayOrderedDesc(int[] arrayenteros)
        {
            if (arrayenteros == null) //siempre es esto, excepto si antes de la condicion necesitas acceder a un array[0]
                return null;

            int[] arraydesordenado = new int[arrayenteros.Length];

            for (int i = 0; i < arrayenteros.Length; i++)
            {
                arraydesordenado[i] = arrayenteros[arrayenteros.Length - 1 - i];
            }
            return arraydesordenado;
        }


        // Lo mismo pero para listas

        public static List<int> InvertList(List<int> list)
        {
            if (list == null)
                return null;

            List<int> listSinInvertir = new List<int>(list.Count);

            for (int i = 0; i < list.Count; i++)
            {
                listSinInvertir.Add(list[list.Count - 1 - i]);
            }
            return listSinInvertir;
        }

        //Funcion que le paso un array de enteros, y un entero, y quiero que esa funcion añada el entero que se le pasa al array

        public static int[] AddToArray(int[] arrayenteros, int n)
        {
            //rehacer
            if (arrayenteros == null)
            {
                int[] arraynuevo = new int[1];
                arraynuevo[0] = n;
                return arraynuevo;
            }

            int[] result2 = new int[arrayenteros.Length + 1];

            for (int i = 0; i < arrayenteros.Length; i++)
            {
                result2[i] = arrayenteros[i];
            }
            result2[arrayenteros.Length] = n;
            //result2[arrayenteros.Length];
            //result [arraynuevo.lenght - 1]
            return result2;
        }

        //algoritmo de la burbuja

        //l, i, j

        //swap
        //int aux;
        //aux = l[i];
        //l[i[ = l[j];
        //l[j] == aux;

        //sort array

        public static Array? SortArray(int[] arraysort)
        {
            if (arraysort == null)
            {
                return null;
            }

                for (int i = 0; i < arraysort.Length - 1; i++)
                {
                    for (int j = i + 1; i < arraysort.Length; j++)
                    {
                        if (arraysort[i] > arraysort[j])
                        {
                            int aux = arraysort[i];
                            arraysort[i] = arraysort[j];
                            arraysort[j] = aux;
                        }
                    }
                }
            return arraysort;
        }

        //sortlista

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

        //collatz serie 3n + 1
        //Funcion que le paso un numero y me devuelva la serie de collatz de ese numero
        //si es par divida entre 2
        //si es impar multiplique por 3 y le sume 1

        public static List<int>? SerieCollatz(int n)
        {
            if (n == null || n <= 0)
                return null;

            List<int> result = new List<int>();

            while (n > 1)
            {
                result.Add(n);
                if (n % 2 == 0)//espar
                    n = n / 2;
                else
                    n = n * 3 + 1;
            }
            result.Add(n);
            return result;
        }

        // Funcion que le pase una lista y me devuelva una lista con los dos elementos mayores

        public static List<int> GetElementosMayoresLista(List<int> listamayores)
        {
            if (listamayores == null || listamayores.Count < 2)
                return null;

            List<int> result = new List<int>();

            int max1 = int.MinValue;
            int max2 = int.MinValue;


            for (int i = 0; i < listamayores.Count; i++)
            {
                int element = listamayores[i];
                if (element > max1)
                {
                    max2 = max1;
                    max1 = element;
                }
                else if (element > max2)
                {
                    max2 = element;
                }    
            }
            result.Add(max1);
            result.Add(max2);
            return result;  
        }


        //Funcion que le pasas una lista de enteros y quiero que me devuelvas otra lista pero solo con los numeros pares que haya en esa lista

        public static List<int>? GetElementosParesLista(List<int> l)
        {
            if (l == null)
                return null;

            List<int> result = new List<int>();

            for (int i = 0; i < l.Count; i++)
            {
                int element = l[i];
                if (element % 2 == 0)
                {
                    result.Add(element);
                }
            }
            return result;
        }

        //hallar los numeros pares de un array
        public static int[]? GetPairsArray(List<int> l)
        {
            if (l == null)
                return null;


            List<int>? pares = GetElementosParesLista(l);
            int n = pares.Count;
            int[] result = new int[n];
            int j = 0;

            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] % 2 == 0) //espar
                {
                    result[j] = l[i];
                    j++;
                }
            }
            return result;
        }

        

        // Funcion que le paso una lista de enteros y le paso una posicion. Lo que tiene que hacer esta funcion es borrar el elemento de esa posicion en la lista

        public static void RemovePositionInList(List<int> list, int index)
        {
            if (list == null)
                return;
            list.RemoveAt(index); 
        }

        //[0, 7, 1, 8, 4]
        // Funcion paso una lista y un valor. Tiene que borrar de la lista el numero 8 sin usar el Remove.

        public static void RemovePositionList(List<int> list1, int value)
        {
            if (list1 == null)
                return;

            value = 8;
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] == value)
                {
                    //return; -> para borrar solo el primero que cumpla
                    //break; -> se sale del buble inmediatamente saliendo del for
                    //si break o return es la ultima instruccion de un bucle es suspenso inmediato.
                    list1.RemoveAt(i--);
                    //list1.RemoveAt(i--);
                    //el resultado es el que se busca eliminar, queda eliminado y desplaza todas la i un valor hacia abajo
                    i--;
                }
                
            }
        }

        //Funcion igual con array
        
        public static int[]? RemovePositionArray(int[] arrayremove, int value1)
        {
            if (arrayremove == null)
                return null;

            int count = CountElements(arrayremove, value1);
            int[] result = new int[arrayremove.Length - count];

            int j = 0;

            for (int i = 0; i < arrayremove.Length; i++)
            {
                //count = count + arrayremove[i];

                if (arrayremove[i] != value1)
                {
                    result[j++] = arrayremove[i];
                }
            }

            return result;
        }

        //crear funcion countelements para que funcione

        public static int CountElements(int[] array, int value)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    count++;
                }
            }
            return count;
        }


        //todolo que potencialmente pueda valer null, se le puede poner la interrogacion ? al final del elemento int[]?

        //RemoveValues que estan en una lista 
        public static void RemoveValues(List<int> l1, List<int> values)
        {
            if (l1 == null || values == null)
                return;

            
            for (int i = 0; i < l1.Count; i++)
            {
                for (int j = 0; j < values.Count; j++)
                {
                    if (l1[i] == values[j])
                    {
                        l1.RemoveAt(i--);
                        break;
                    }
                }
                
            }
        }

        //removevalues para array

        public static void RemoveValues1(List<int> l1, List<int> values1)
        {
            if (l1 == null || values1 == null)
                return;

            for (int i = 0; i < l1.Count; i++)
            {
               //if (Contains(values1, l1[i]))
               if (values1.Contains(l1[i]))
               {
                    l1.RemoveAt(i--);
               }        
                  
            }

        }

    }
}
