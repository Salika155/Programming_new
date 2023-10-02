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


            int n3 = FuncionesArrayList.GreatLesserThanZero(l2);

            Person s = new Person();
            s.name = "Huan";


        }
    }
}