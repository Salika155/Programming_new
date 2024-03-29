﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Functions
    {

        //Hacer una función que se le pasen dos números y devuelva el resultado de la suma de esos dos números.

        public static int SumarNumeros(int n1, int n2)
        {
            return n1 + n2;
        }


        //Funcion que devuelve el valor mayor de dos que se le pasan
        public static int ObtenerMayor(int value1, int value2)
        {
            if (value1 >= value2)
                return value1;
            return value2;
        }


        //Funcion que sirve para decir si un entero es par o no
        public static bool IsEven(int a)
        {
            if (a % 2 == 0)
                return true;
            return false;
        }

        //Funcion que sirve para decir si un entero es impar
        public static bool IsOdd(int a)
        {
            if (a % 2 != 0)
                return true;
            return false;
        }

        //Funcion que te devuelva el mayor de 3 numeros

        public static int IsHigher(int a, int b, int c)
        {
            if ((a > b) || (a > c))
                return a;
            else if ((b > c) || (b > a))
                return b;
            return c;
        }



        //Funcion para hallar el sumatorio de un numero mediante un bucle while
        public static int GetSummation(int number)
        {
            int result = 0;
            int i = 1;
            while (i <= number)
            {
                result = result + i;
                i++;
            }
            return result;
        }

        //Funcion para hallar el sumatorio de un numero mediante un bucle for
        public static int GetSummation2(int number)
        {
            int result = 0;

            for (int i = 0; i < number; i++)
                result += i;
            return result;
        }


        //Rehacerla

        public static void GetEvenNumWithNegatSig(int number)
        {
            int result = 0;
            int counnt = 0;

            for (int i = 0; i <= number; i += 2)
            {
                if (IsOdd(i / 2))
                    Console.WriteLine(-i);
                else
                    Console.WriteLine(i);

            }

        }

        public static void GenerateSerie(int n)
        {
            int valor = 1;
            for (int i = 0; i <= n; i+=2)
            {
                if (valor == 1)
                    Console.WriteLine(i);
                else
                    Console.WriteLine(-i);
            }
        }

        //public static void GenerateSerie1(int n)
        //{
        //    bool rob = true;
        //    for (int i = 0; i <= n; i++)

        //}

        public static void LuisSerie(int num)
        {
            int n = 0;
            int a = 1;

            Console.WriteLine(n);
            while (n <= num)
            {
                if (a > 0)
                    n += 5;
                else 
                    n -= 2;
                Console.WriteLine(n);
                a *= -1;
            }
        }

        //crea la funcion que le pase un numero y me diga si es primo o no
        public static bool EsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) 
                    return false;
            }
            return true;
        }

        //bucle que esta sometido a return y no tiene salida (return de fuera tiene que estar fuera de llaves)


        public static void PrintEx1(int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                if (IsOdd(i))
                    Console.WriteLine(-i * 2);
                else
                    Console.WriteLine(i * 2);
            }
            //if (i % 2 == 1)
        }


        //List<int> l;
        //l = new List<int>();
        //l.Add(40);
        //l.Add(-10);
        //l.Remove(2); //borra el primer 2 que haya en la lista
        //l.RemoveAt(2); //borra lo que haya en la posicion 2
        //l[0] = 60; //[60,10] //cambia elemento 0 por 60
        //l[i + 0] = 3; //[60, 3] sustituye elemento en posic 2 por 3
        //int n = l.Count; 2 //elementos que hay en la lista
        //l.Insert(1, -20); -> [60, -20, 3]
        //l.Clear(); -> limpia la lista
        //l[1]=l[2] -> [60, -20, 3] -> [60, 3, 3]

        //int[] a;
        //a = new int[4]; //-> crear array de 4 elementos [0, 0, 0, 0] ->para array tienes que indicar numero de elementos, en lista no
        //a[3] = -10;     // -> [0, 0, 0, -10]
        //a[0] = a[3];    //[-10, 0, 0, -10]
        //int n = a.Length; //4 elementos, te dice cuantos hay
        //int[] b = a; //b apunta a array a

        //FUNCION que le paso lista de strings y devuelve el numero de elementos que hay en la lista
        //

        public static int FuncLista1(List<string> list)
        {
            return list.Count;
        }

        //funcion me pasan una lista de dobles, quiero que me devuelva el numero de elementos que hay por encima de 0

        public static int GetGreaterThanZeroCount(List<double> list)
        {
            int result = 0;
             for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 0.0)
                    result++;
            }
            return result;
        }

        
    }
}
