namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> l = new List<double>();
            for (int i = -50; i <=50 ; i++)
                l.Add(i);
            l.Add(42.2);
            l.Add(-1.0);
            l.Add(0.0);
            l.Add(145.64);

            int n = FuncionesArrayList.GreaterThanZeroCount(l);
            Console.WriteLine(n);

            List<string> l2 = new List<string>();
            l2.Add("hola");
            l2.Add("adios");
            l2.Add("Hasta luego");

            int n2 = FuncionesArrayList.FuncLista1(l2);
            Console.WriteLine(n2);


            //int n3 = FuncionesArrayList.GreatLesserThanZero(l2);

            Person s = new Person();
            s.name = "Huan";

            //-------------------------------------------------------------------------------------------------

            //int[] a;
            //a = new int[4]; //-> crear array de 4 elementos [0, 0, 0, 0] ->para array tienes que indicar numero de elementos, en lista no
            //a[3] = -10;     // -> [0, 0, 0, -10]
            //a[0] = a[3];    //[-10, 0, 0, -10]
            //int n = a.Length; //4 elementos, te dice cuantos hay
            //int[] b = a; //b apunta a array a

            double[] a1 = new double[4] { 0, 0, 0, 0 };
            a1[0] = 5.4;
            a1[1] = 45.97;
            a1[2] = -4.9;
            a1[3] = -34.67;

            int n4 = a1.Length;
            Console.WriteLine(n4);

            string[] a2 = new string[5] { "H", "O", "L", "A", "." };
            a2[0] = "A";
            a2[1] = "D";
            a2[2] = "I";
            a2[3] = "O";
            a2[4] = "S";

            int n5 = a2.Length;
            Console.WriteLine(n5);
            









        }
    }
}