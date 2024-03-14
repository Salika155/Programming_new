using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DominoSimulacro
{
    public class Utils
    {
        Random _r = new Random();

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        //public static I List<T> Swap1<T>(this IList<T> list, int i, int j)
        //{
        //    T aux = list[i];
        //    list[i] = list[j];
        //    list[j] = aux;
        //    return list;
        //}

        public int RandomNumber(int min, int max)
        {

            return _r.Next(min, max);
        }

        public int GetRandom(int min, int max)
        {
            return _r.Next(min, max + 1);
        }
    }
}
