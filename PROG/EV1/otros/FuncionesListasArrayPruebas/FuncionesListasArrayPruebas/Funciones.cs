using Microsoft.Win32.SafeHandles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesListasArrayPruebas
{
    public class Funciones
    {
        #region funciones importantes 1
        //IMPORTANTE
        //menor de 2 numeros
        public static int MenorQue(int a, int b)
        {
            return (a <= b) ? a : b;
        }

        //numero es par
        public static bool EsPar(int a)
        {
            return (a % 2 == 0);
        }


        //menor de 3 numeros(2 versiones)
        public static int MenorQueTres(int a, int b, int c)
        {
            if (a <= b && a <= c)
                return a;
            else if (b <= a && b <= c)
                return b;
            return c;
        }

        public static int MenorQueTres2(int a, int b, int c)
        {
            return MenorQue(a, MenorQue(b, c));
        }


        //serie 0, -2, 4, -6, 8 imprimen

        public static void Serie1(int s)
        {
            int valor = 0;

            for (int i = 0; i <= s; i++)
            {
                if (valor == 1)
                {
                    valor = 0;
                    Console.WriteLine(-i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Primo

        public static bool EsPrimo(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }


        //Serie 0, 5, 3, 8, 6, 11 

        public static void Serie2(int num)
        {
            int n = 0;
            int a = 1;

            Console.WriteLine(n);
            for (int i = 0; i < num; i++)
            {
                if (a >= 0)
                    n += 5;
                else
                    n -= 2;

                Console.WriteLine(n);
                a *= -1;
            }
        }

        //Sumatorio

        public static int Sumatorio(int n)
        {
            int result = 0;
            for (int i = 1; i <= n; i++)
                result += i;
            return result;
        }

        //Productorio

        public static int Productorio(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
                result *= i;
            return result;
        }
#endregion

        //funcion que concatene dos strings

        public static string ConcatenacionStrings(string a, string b)
        {
            return a + b;
        }


        //0, 1, 2, 3, 4, 5, 6, 7

        public static string Serie3(int n)
        {
            string res = "";

            for (int i = 0; i <= n; i++)
            {
                res += i + ", ";
            }
            return res;
        }


        //1, 2, 4, 8, 16, 32, 64

        public static string Serie4(int n)
        {
            string res = "";
            int valor = 1;

            for (int i = 0; i < n; i++)
            {
                if (i < n - 1)
                    res += valor + ", ";
                else
                    res += valor;

                valor *= 2;
            }
            return res;
        }


        //serie de fibonacci 0, 1, 1, 2, 3, 5, 8, 13, 21

        public static string Fibonacci(int n)
        {
            string serie = "";
            int aux = 0;
            int auxb = 1;
            int auxc = 0;


            for (int i = 0; i < n; i++)
            {
                serie += " " + aux + ", ";
                auxc = aux + auxb;
                aux = auxb;
                auxb = auxc;
            }
            return serie;
        }


        //Funcion que devuelve numero de valores mayor que cero lista

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

        public static int ValorMasAlto(List<int> l4)
        {
           if (l4 == null || l4.Count == 0)
                return -1;

            int max = l4[0]; //defines un max = 0 para compararlo con el valor, si el numero[i] es mayor, le da el valor
            //a ese max y lo iguala a el numero, index se convierte en ese numero.
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
            if (l5 == null || l5.Count <= 1)
                return true;

            for (int i = 1; i < l5.Count; i++)
            {
                //el -1 hace referencia a comprobar la posicion anterior
                if (l5[i] < l5[i - 1])
                    return false;
            }
            return true;
        }

        //Contiene elemento dentro del array

        public static bool IsInArray(int[] array, int n)
        {
            if (array == null)
                return false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                    return true;
            }
            return false;
        }

        //Le paso un numero y compruebo dentro de la lista si esta mediante el binarysearch
        //punto medio, comparo y muevo valores binarysearch

        public static bool SearchByBinaryLista(List<int> l6, int n)
        {
            if (l6 == null || l6.Count == 0)
                return false;

            int min = 0;
            int max = l6.Count - 1;

            while (min <= max)
            {
                int med = (min + max) / 2;

                if (l6[med] == n)
                    return true;
                else if (l6[med] < n)
                    min = med + 1;
                else if (l6[med] > n)
                    max = med - 1;
            }
            return false;

        }

        

        //funcion que se le pasa un array de dobles y devuelve la media de todos los valores que hay ahi

        public static double GetArrayMedia(int[] array)
        {
            if (array == null)
                return double.NaN;

            double aux = 0.0;
            for (int i = 0; i < array.Length; i++)
                aux+= array[i];
            return aux / array.Length;
        }


        //Funcion que le pasas un array y un umbral y tiene que devolver la media de todos estos valores pero solamente de aquellos que superen este numero

        public static double GetUmbral(int[] array, double umbral)
        {
            if (array == null)
                return double.NaN;

            double avg = 0.0;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= umbral)
                {
                    avg = array[i];
                    count++;
                }
                if (count == 0)
                    return double.NaN;
            }
            return avg / count;
        }
        // Funcion que le paso una lista de enteros y me devuelve un entero. Devuelve numero de veces que se repite el numero mas alto

        public static int GetNumberMayorRepetido(List<int> list)
        {
            if (list == null || list.Count < 1)
                return -1;

            int count = 1;
            int max = list[0];

            return count;

        }
        // Funcion que necesita como parametro una lista de enteros, y me tiene que devolver una lista de enteros pero al reves de la lista que le he metido
        // [0, 7, -1, 8] -> [8, -1, 7, 0]

        public static List<int> SwapValores(List <int> listavalor)
        {
            List<int> list = new List<int>();

            if (listavalor == null || listavalor.Count == 0)
                return new List<int>();

            for (int i = 0; i < listavalor.Count; i++) 
            {
                list.Add(listavalor[i]);
            }
            return list;

        }

        //Funcion que le paso una lista de enteros y los imprime por pantalla

        public static void WriteForScreen(List<int> listaenteros)
        {
            if (listaenteros == null)
                return;

            listaenteros.Add(5);
            listaenteros.Add(74);
            listaenteros.Add(43);
            listaenteros.Add(9);
            listaenteros.Add(36);

            for (int i = 0; i < listaenteros.Count; i++)
            {
                Console.WriteLine(listaenteros[i] + ", ");
            }

        }

        //Funcion que necesita como parametro un array de enteros, y me tiene que devolver un array de enteros pero al
        //reves del array que le he metido

        public static int[] InvertArray(int[] array)
        {
            if (array == null)
                return null;

            int [] arraysininvertir = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                arraysininvertir[i] = array[array.Length] - 1 -i; 
            }
            return arraysininvertir;
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

        public static int[] AddToArray(int[] array, int n) 
        {
            //if (array == null)
            //    return null; -> es lo mismo que lo de abajo

            int[] newArray = array ?? new int[0];

            int[] result = new int[newArray.Length + 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                result[i] = newArray[i];
            }

            result[newArray.Length] = n;

            return result;
        }


        //algoritmo de la burbuja

        //l, i, j

        //swap
        //int aux;
        //aux = l[i];
        //l[i[ = l[j];
        //l[j] == aux;

        //sort array

        public static Array SortArray(int[] array)
        {
            if (array == null)
                return null;

            for (int i = 0; i < array.Length - 1; i++) 
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }
            return array;
        }

        //sort lista

        public static List<int> SortLista(List<int> list)
        {
            if (list == null)
                return null;

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        int aux = list[i];
                        list[i] = list[j];
                        list[j] = aux;
                    }
                }
            }
            return list;
        }

        //collatz serie 3n + 1
        //Funcion que le paso un numero y me devuelva la serie de collatz de ese numero
            //si es par divida entre 2
            //si es impar multiplique por 3 y le sume 1
        public static List<int> GetSerieCollaz(int n)
        {
            if (n == null || n <= 0)
                return null;

            List <int> list = new List<int>();

            while (n > 0)
                if (n % 2 == 0)
                    n = n / 2;
                else if (n % 2 != 0)
                    n = n + 3 + 1;
            list.Add(n);
            return list;
        }

        //Funcion que le pase una lista y me devuelva una lista con los dos elementos mayores

        public static List<int>? ElementosMayores(List<int> list)
        {
            if (list == null) 
                return null;

            List<int> max = new List<int>();

            int max1 = int.MinValue;
            int max2 = int.MaxValue;

            for (int i = 0; i < list.Count; i++)
            {
                int aux = list[i];
                if (aux > max1)
                {
                    max2 = max1; 
                    max1 = aux;
                }
                else if (aux > max2)
                {
                    max2 = aux;
                }
            }
            return max;
        }


        //Funcion que le pasas una lista de enteros y quiero que me devuelvas otra lista pero solo con los numeros
        //pares que haya en esa lista
        //hallar los numeros pares de un array

        public static List<int> GetNumParesInList(List<int> list)
        {
            if (list == null) return null;

            List <int> result = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                int aux = list[i];
                if (aux % 2 == 0)
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }

        public static int[] GetNumParesInArray(List<int> l)
        {
            if (l == null)
                return null;

            List <int> list = GetNumParesInList(l);
            int n = l.Count;
            int[] res = new int[n];
            int j = 0;

            for(int i = 0; i < l.Count; i++) 
            {
                if (l[i] % 2 == 0)
                {
                    res[j++] = l[i];
                    j++;
                }
            }
            return res;
        }


        // Funcion que le paso una lista de enteros y le paso una posicion. Lo que tiene que hacer esta
        // funcion es borrar el elemento de esa posicion en la lista

        public static void DeleteFromPositionInList(List<int> list, int index)
        {
            if (list == null)
                return;

            list.RemoveAt(index);
        }

        //[0, 7, 1, 8, 4]
        // Funcion paso una lista y un valor. Tiene que borrar de la lista el numero 8 sin usar el Remove.


        public static void DeletPositionFromList(List<int> list, int value)
        {
            if (list == null)
                return;

            value = 5;
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                    list.RemoveAt(i--);
                i--;
            }
        }

        //Funcion igual con array



        //crear funcion countelements para listas

        public static int CountElements(List<int> list, int value)
        {
            int count = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    count++;
                }
            }
            return count;
        }


        //RemoveValues que estan en una lista 

        public static void RemoveValues(List<int> list, List<int> values)
        {
            if (list == null || values == null) return;

            for (int i = 0; i < list.Count;i++) 
            {
                for ( int j = 0; j < values.Count; j++)
                {
                    list[i] = values[j];
                    {
                        list.RemoveAt(i--);
                        break;
                    }
                }
            }
        }

        //removevalues para array

        //public static int[]? RemovePositionArray(int[] arrayremove, int value1)
        //{
        //    if (arrayremove == null)
        //        return null;

        //    int count = CountElements(arrayremove, value1);
        //    int[] result = new int[arrayremove.Length - count];

        //    int j = 0;

        //    for (int i = 0; i < arrayremove.Length; i++)
        //    {
        //        //count = count + arrayremove[i];

        //        if (arrayremove[i] != value1)
        //        {
        //            result[j++] = arrayremove[i];
        //        }
        //    }

        //    return result;
        //}

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
