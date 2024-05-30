using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Cosa
    {
        public int cosa;

        public Cosa(int cosa)
        {
            this.cosa = cosa;
        }


        public int GetCosa()
        {
            return cosa;
        }

        public int GetCosa(int cosa)
        {
            return cosa;
        }


        public delegate int MyDelegate(int a, int b);
        public delegate int MyDelegate2(int a);

        public static int CallFunction(MyDelegate func)
        {
            int n = 0;
            for (int i = 0; i < 10; i++)
                n += func.Invoke(1, 2);
            return n;
        }
        public static MyDelegate PrepareDelegate(int jojojo)
        {
            return (x, y) =>
            {
                return x * x + y * y + jojojo;
            };
        }

        public delegate T Comparator<T>(T a, T b);

        public static T Find<T>(T[] array, T obj) where T : class //t es una clase
        {
            //if (obj == null) 
            //    return;
            //comparar obj con cada elemento de array
            //copia superficial sin equals
            //copia profunda con equals
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(obj))
                    return array[i];
            }
            return null;
        }

        public delegate bool Comparator2<T>(T a);

        public static T Find2<T>(T[] array, Comparator2<T> comparator) where T : class //t es una clase
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (comparator(array[i]))
                    return array[i];
            }
            return null;
        }

        //sort prohibido
        //funcion pase lista y borre elementos de la lista -> array.filter

        public static T[] FindAll<T>(T[] array, Comparator2<T> comparator) where T : class //t es una clase
        {
            List<T> list = new List<T>();
            for (int i = 0; i < array.Length; i++)
            {
                if (comparator(array[i]))
                    list.Add(array[i]);
            }
            if (list.Count == 0)
            {
                return Array.Empty<T>();
            }
            return list.ToArray();

        }



        static void Main(string[] args)
        {
            var c = new Cosa(2);
            c.GetCosa(4);
            int n = c.cosa;
                //c una variable que apunta al objeto
                

                MyDelegate f = (numero1, numero2) =>  //ESTO ES UN NEW
            {
                return (numero1 + 1) * numero2 + n;
            };
            //f una variable que apunta a un objeto especial
            //f.Invoke(8,9);
            f(8, 9);

            string[] s = { "8", "por", "el", "....", "te" };
            var found = Find2(s, (x) =>
            {
                return x == "por";
                return x.Length == c.GetCosa();
            });

            //MyDelegate2 f = PrepareDelegate(3);
            //CallFunction(f);

        }
    }
}
