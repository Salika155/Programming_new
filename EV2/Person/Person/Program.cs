using System.Xml.Serialization;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Person p1 = new Person("Marie Curie", 45, "", GenderType.Female, 64, 143);
            Person p2 = new Person();
            
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            double p1IMC = p1.CalculateIMC();
            double p2IMC = p2.CalculateIMC();
            Console.WriteLine("p1 IMC is: " + p1IMC);
            Console.WriteLine("p2 IMC is: " + p2IMC);
            

            bool p1is18 = p1.IsMoreThan18();
            bool p2is18 = p2.IsMoreThan18();
            Console.WriteLine(p1is18);
            Console.WriteLine(p2is18);

            p1.ConfirmGender(GenderType.Other);
            p2.ConfirmGender(GenderType.Male);

            Console.WriteLine("p1 dni is: " + p1.Dni);
            Console.WriteLine("p2 dni is: " + p2.Dni);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            Console.WriteLine("p1 gender is: " + p1.Gender);
            Console.WriteLine("p2 gender is: " + p2.Gender);
        }
    }
}