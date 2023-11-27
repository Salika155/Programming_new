using static FuncionesListasArrayPruebas.Funciones;

namespace FuncionesListasArrayPruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Funcion numero de valores mayor que cero lista
            List<double> l = new List<double>();
            
            {
            l.Add(-5.0);
            l.Add(42.2);
            l.Add(-1.0);
            l.Add(0.0);
            l.Add(145.64); 
            }
            
            Console.Write("Elementos mayores de 0: ");
            int n = Funciones.GetValorMayorCeroL(l);
            Console.WriteLine(n);

            //Cuantos elementos tiene la lista
            List<double> l1 = new List<double>();

            {
                l1.Add(-5.0);
                l1.Add(42.2);
                l1.Add(-1.0);
                l1.Add(0.0);
                l1.Add(145.64);
            }

            Console.Write("Elementos en la lista: ");
            int n1 = Funciones.ElementosEnLista(l1);
            Console.WriteLine(n1);

            //Cuantos elementos tiene el array
            double[] a = new double[4] { 0, 0, 0, 0 };
            a[0] = 5.4;
            a[1] = 45.97;
            a[2] = -4.9;
            a[3] = -34.67;

            Console.Write("Elementos en el array: ");
            int na = a.Length;
            Console.WriteLine(na);

            //Funcion valores mayor que cero array
            double[] aa = new double[4] { 0, 0, 0, 0 };
            aa[0] = 5.4;
            aa[1] = 45.97;
            aa[2] = -4.9;
            aa[3] = -34.67;

            Console.Write("Numero de valores mayores de 0 en Array: ");
            int naa = GetValorMayorCeroA(aa);
            Console.WriteLine(naa);

            //quiero una funcion que le paso una lista de enteros y un numero, y me tiene que decir si ese numero esta en la lista o no
            List<double> listaenteros = new List<double>();

            listaenteros.Add(12);
            listaenteros.Add(4);
            listaenteros.Add(-6);
            listaenteros.Add(54);
            listaenteros.Add(4);
            listaenteros.Add(46);

            Console.Write("Elementos esta o no en la lista: ");
            Console.WriteLine(Funciones.EstaEnLaLista(listaenteros, 4));

            //Me pasan una lista de enteros y me dice el numero mayor que hay en esa lista de enteros

            List<int> listamayor = new List<int>();
            listamayor.Add(1);
            listamayor.Add(2);
            listamayor.Add(3);
            listamayor.Add(4);
            listamayor.Add(5);

            Console.Write("El numero mayor de la lista es: ");
            Console.WriteLine(Funciones.NumeroMayorLista(listamayor));

            Console.WriteLine("----------------------------------------------------------------");


            int resultado = Funciones.MenorQue(5, 9);
            Console.WriteLine("EL NUMERO MENOR ES: " + resultado);

            int numpar = -24;
            bool espar = Funciones.EsPar(numpar);
            Console.WriteLine(espar);

            int resultado2 = Funciones.MenorQueTres(5, 9, 4);
            Console.WriteLine("EL NUMERO MENOR ES: " + resultado2);

            Serie1(17);

            int num = 11;
            bool esprimo = Funciones.EsPrimo(num);
            Console.WriteLine(esprimo);

            Serie2(16);
            Console.WriteLine("__________________________");

            int number = Sumatorio(3);
            Console.WriteLine(number);

            int numberp = Productorio(8);
            Console.WriteLine(numberp);

            string a1 = "a";
            string b2 = "b";
            string result = ConcatenacionStrings(a1, b2);
            Console.WriteLine(result);

            int numberse = 65;
            Console.WriteLine(Serie3(numberse));

            int numbersew = 21;
            Console.WriteLine(Serie4(numbersew));

            int fibonacci = 12;
            Console.WriteLine(Fibonacci(fibonacci));


            




        }

       
    }
}