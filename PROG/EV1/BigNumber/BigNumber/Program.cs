namespace BigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear dos BigNumber
            BigNumber bigNumber1 = new BigNumber("55");
            BigNumber bigNumber2 = new BigNumber("6");

            // Sumar los dos números
            BigNumber result = BigNumber.Add(bigNumber1, bigNumber2);

            // Imprimir los números y el resultado
            Console.WriteLine("Número 1: " + bigNumber1.ConvertToString());
            Console.WriteLine("Número 2: " + bigNumber2.ConvertToString());
            Console.WriteLine("Resultado: " + result.ConvertToString());
        }
    }
}