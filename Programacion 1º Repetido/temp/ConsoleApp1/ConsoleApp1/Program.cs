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

            //Console.WriteLine("Menor que:");
            //int menor = FunctionsEjercicios.MenorQue(5, 75);
            //Console.WriteLine(menor);

            //Console.WriteLine("Es par:");
            //bool espar = FunctionsEjercicios.EsPar(87);
            //Console.WriteLine(espar);

            //Console.WriteLine("El menor de los tres numeros:");
            //int menorde3 = FunctionsEjercicios.MenorQueTres(5, 67, 7);
            //Console.WriteLine(menorde3);

            //Console.WriteLine("El menor de los tres numeros segunda forma es:");
            //int menorde3dos = FunctionsEjercicios.MenorQueTres2(1, 5, 4);
            //Console.WriteLine(menorde3dos);

            //Console.WriteLine("La serie es:");
            //FunctionsEjercicios.Serie1(15);
            //Console.WriteLine();

            //Console.WriteLine("La serie es:");
            //FunctionsEjercicios.Serie2(58);
            //Console.WriteLine();

            //Console.WriteLine("El sumatorio del numero es:");
            //int sumatorio = FunctionsEjercicios.GetSumatorio(21);
            //Console.WriteLine(sumatorio);

            //Console.WriteLine("El productorio del numero es:");
            //int productorio = FunctionsEjercicios.GetProductorio(5);
            //Console.WriteLine(productorio);


            string resultado = FunctionsEjercicios.StringSerie1(7);
            Console.WriteLine(resultado);

            string resultado1 = FunctionsEjercicios.StringSerie2(7);
            Console.WriteLine(resultado1);

        }
    }
}