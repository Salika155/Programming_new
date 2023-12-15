using System.Security.Principal;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona Persona1 = new Persona("John Doe", 21, PersonaSex.MALE, 68, 1.68);
            Console.WriteLine("Nombre: {0}, Edad: {1}, Sexo: {2}, Peso {3}, Altura: {4}",
                Persona1.Name, Persona1.Age, Persona1.Gender, Persona1.Weight, Persona1.Height, Persona1.Nif);

            Persona Persona2 = new Persona("Janine Doe", 19, PersonaSex.FEMALE, 53, 1.63);
            Console.WriteLine("Nombre: {0}, Edad: {1}, Sexo: {2}, Peso {3}, Altura: {4}",
                Persona2.Name, Persona2.Age, Persona2.Gender, Persona2.Weight, Persona2.Height, Persona2.Nif);

            Console.WriteLine("IMC del usuario1: ");
            Console.WriteLine(Persona1.CalcularIMC());
            Console.WriteLine("IMC del usuario2: ");
            Console.WriteLine(Persona2.CalcularIMC());


            Console.WriteLine(Persona1.ToString());
            Console.WriteLine(Persona2.ToString());
        }
    }
}