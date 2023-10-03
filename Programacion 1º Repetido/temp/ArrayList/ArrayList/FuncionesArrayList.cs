using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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
            
            for (int i = 0; i < listaenteros.Count; i++)
            {
                if (listaenteros[i] == n)
                    return true;
            }
            return false;

        }
    }
}
