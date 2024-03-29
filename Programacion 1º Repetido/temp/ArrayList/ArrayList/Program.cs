﻿using static ArrayList.FuncionesArrayList;

namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Funcion numero de valores mayor que cero lista
            List<double> l = new List<double>();
            //for (int i = -50; i <= 50; i++)
            l.Add(5.0);
            l.Add(42.2);
            l.Add(-1.0);
            l.Add(0.0);
            l.Add(145.64);

            Console.WriteLine("Is Greathe Than Zero");
            int n = FuncionesArrayList.GreaterThanZeroCount(l);
            Console.WriteLine(n);


            //Cuantos elementos tiene la lista
            List<string> l2 = new List<string>();
            l2.Add("hola");
            l2.Add("adios");
            l2.Add("Hasta luego");

            Console.WriteLine("Lista 2");
            int n2 = FuncionesArrayList.FuncLista1(l2);
            Console.WriteLine(n2);


            //int n3 = FuncionesArrayList.GreatherThanZero(l2);

            Person s = new Person();
            s.name = "Huan";

            //-------------------------------------------------------------------------------------------------


            //int[] a;
            //a = new int[4]; //-> crear array de 4 elementos [0, 0, 0, 0] ->para array tienes que indicar numero de elementos, en lista no
            //a[3] = -10;     // -> [0, 0, 0, -10]
            //a[0] = a[3];    //[-10, 0, 0, -10]
            //int n = a.Length; //4 elementos, te dice cuantos hay
            //int[] b = a; //b apunta a array a

            //Cuantos elementos tiene el array
            double[] a1 = new double[4] { 0, 0, 0, 0 };
            a1[0] = 5.4;
            a1[1] = 45.97;
            a1[2] = -4.9;
            a1[3] = -34.67;

            int n4 = a1.Length;
            Console.WriteLine(n4);

            //Funcion valores mayor que cero array
            string[] a2 = new string[5] { "H", "O", "L", "A", "." };
            a2[0] = "A";
            a2[1] = "D";
            a2[2] = "I";
            a2[3] = "O";
            a2[4] = "S";

            int n5 = a2.Length;
            Console.WriteLine(n5);

            //--------------------------------------------------------------------
            //quiero una funcion que le paso una lista de enteros y un numero, y me tiene que decir si ese numero esta en la lista o no
            List<double> listaenteros = new List<double>();

            listaenteros.Add(12);
            listaenteros.Add(4);
            listaenteros.Add(-6);
            listaenteros.Add(54);
            listaenteros.Add(4);
            listaenteros.Add(46);

            Console.WriteLine("Elementos esta o no en la lista");
            Console.WriteLine(FuncionesArrayList.ContainsInList(listaenteros, 5));

            //Me pasan una lista de enteros y me dice el numero mayor que hay en esa lista de enteros
            List<int> listamayor = new List<int>();
            listamayor.Add(1);
            listamayor.Add(2);
            listamayor.Add(3);
            listamayor.Add(4);
            listamayor.Add(5);

            Console.WriteLine("El numero mayor de la lista");
            Console.WriteLine(FuncionesArrayList.EsElMayorNumero(listamayor));

            //Pasar una lista de enteros, quiero devolver la posicion donde se encuentra el valor mas alto de la lista.
            List<int> listapos = new List<int>();
            listapos.Add(1);
            listapos.Add(574);
            listapos.Add(-6);
            listapos.Add(8);

            Console.WriteLine("La posicion en la lista");
            Console.WriteLine(FuncionesArrayList.GetPosicionLista(listapos));

            //Funcion que le paso una lista de enteros y me dice si esta ordenada o no de manera ascendente

            List<int> listaordenada = new List<int>();
            listaordenada.Add(-1);
            listaordenada.Add(2);
            listaordenada.Add(43);
            listaordenada.Add(5);

            Console.Write("Esta la lista Ordenada en ascendente");
            Console.WriteLine(FuncionesArrayList.IsOrderedAsc(listaordenada));

            List<int> listaordenada1 = new List<int>();
            listaordenada1.Add(-1);
            listaordenada1.Add(7);
            listaordenada1.Add(43);
            listaordenada1.Add(54);

            Console.WriteLine("Esta la lista Ordenada en ascendente de otra manera");
            Console.WriteLine(FuncionesArrayList.IsOrderedAsc1(listaordenada1));

            int[] values = new int[14];

            values[0] = 7;
            values[1] = 10;
            values[2] = 15;
            values[3] = 20;
            values[4] = 27;
            values[5] = 27;
            values[6] = 27;
            values[7] = 85;
            values[8] = 100;
            values[9] = 101;
            values[10] = 120;
            values[11] = 130;
            values[12] = 145;
            values[13] = 150;

            Console.WriteLine("Busqueda Binaria en array");
            Console.WriteLine(FuncionesArrayList.BinarySearch(values, 00000101));

            //avg
            double[] arraydouble = new double[14];

            values[0] = 5;
            values[1] = 56;
            values[2] = 7;
            values[3] = 21;
            values[4] = 23;
            values[5] = 6;

            Console.WriteLine("Hallar media de los valores de la lista");
            Console.WriteLine(FuncionesArrayList.GetAvg(values));

            //GetThreshold
            //double threshold;
            //Console.WriteLine(FuncionesArrayList.GetThreshold(threshold));
            int[] threshold = { 1, 2, 3, 4, 5 };
            double mid = FuncionesArrayList.GetAvg(threshold);
            Console.WriteLine(mid);

            //getnumbermayorepeat

            Console.WriteLine("El numero mayor repetido");
            Console.WriteLine(GetNumberMayorRepeated(listapos));
            
            //swapvalores
            Console.WriteLine(SwapValores(listapos));

            //writeforscreen
            List<int> nuevaLista = new List<int>();

            WriteForScreen(nuevaLista);

            //ArrayOrderedDesc



            int[] arrayenteros = { 1, 2, 3, 4, 5 };
            int[] arraydesordenado = FuncionesArrayList.ArrayOrderedDesc(arrayenteros);

            foreach (int num1 in arraydesordenado)
            {
                Console.Write(num1 + " ");
            }

            //AddToArray

            
            //SortLista

           List<int> list1 = new List<int>();

            list1.Add(0);
            list1.Add(7);
            list1.Add(8);
            list1.Add(8);
            list1.Add(4);
            list1.Add(8);

            Console.WriteLine(list1);







        }
    }
}