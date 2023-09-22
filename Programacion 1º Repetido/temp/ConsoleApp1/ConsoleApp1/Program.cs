namespace ConsoleApp1
{
    public  class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 1;
            b = 2;

            //int r1 = Functions.SumarNumeros(a, b);
            //Console.WriteLine(r1);

            //int r2 = Functions.SumarNumeros(2, 4);
            //Console.WriteLine(r2);

            //int r3 = Functions.SumarNumeros(a - 3, Functions.SumarNumeros(-1, b)) - Functions.SumarNumeros(2, Functions.SumarNumeros(a * a, b * b));
            //Console.WriteLine(r3);

            //int result = Functions.GetSummation(7);
            //Console.WriteLine(result);

            //int result1 = Functions.GetSummation2(7);
            //Console.WriteLine(result1);

            //int result2 = Functions.GetEvenNumWithNegatSig(21);
            //Console.WriteLine(result2);

            //bool resultprimo = Functions.EsPrime(47);
            //Console.WriteLine(resultprimo);

            int menor = FunctionsEjercicios.MenorQue(5, 75);
            Console.WriteLine(menor);

            bool espar = FunctionsEjercicios.EsPar(87);
            Console.WriteLine(espar);

            int menorde3 = FunctionsEjercicios.MenorQueTres(5, 67, 7);
            Console.WriteLine(menorde3);

            int menorde3dos = FunctionsEjercicios.MenorQueTres2(1, 5, 4);
            Console.WriteLine(menorde3dos);


        }
    }
}