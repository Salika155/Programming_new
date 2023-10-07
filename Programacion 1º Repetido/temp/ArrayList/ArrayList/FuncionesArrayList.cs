using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Reflection;

namespace ArrayList
{
    internal class FuncionesArrayList
    {
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

        public static int FuncLista1(List<string> list)
        {
            return list.Count;
        }

        //internal static int GreatLesserThanZero(List<string> l2)
        //{
        //    throw new NotImplementedException();
        //}

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

        //public static bool ContainsInList(List<double> listaenteros, int n)
        //{
        //    if (listaenteros != null)
        //    {
        //    for (int i = 0; i < listaenteros.Count; i++)
        //    {
        //        if (listaenteros[i] == n)
        //            return true;
        //    }
        //}
        //return false;
        //}

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

            for (int i = 1; i < listamayor.Count ;i++)
            {
                if (listamayor[i] > max)
                    max = listamayor[i];
            }
            return max;
        }

        //Pasar una lista de enteros, quiero devolver la posicion donde se encuentra el valor mas alto de la lista.

        public static int GetPosicionLista(List<int> listapos, int position)
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
                if (listaordenada[i] < listaordenada[i-1])
                {
                    return false;
                }
            }
            return true;
        }

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

        //
        public static bool Contains(int[] array, int value)
        {
            for(int i = 0; i < array.Length; i++)
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
            int max = array1.Length -1;
           
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

        public static double GetThreshold(int []array2, double threshold)
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

            if (listasinordenar == null || listasinordenar.Count ==0)
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
            for (int i = 0; i < nuevalista.Count; i++)
                Console.WriteLine(nuevalista[i]);
        }


        //Funcion que necesita como parametro un array de enteros, y me tiene que devolver un array de enteros pero al reves del array que le he metido


        //Funcion que le paso un array de enteros, y un entero, y quiero que esa funcion añada el entero que se le pasa al array
    }
}
