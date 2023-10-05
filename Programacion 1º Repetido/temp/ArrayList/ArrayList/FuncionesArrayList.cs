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
        
    }
}
