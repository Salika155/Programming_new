using System.Security.Cryptography.X509Certificates;

namespace Persona
{
    internal class Program
    {

        public static Person CreatePerson()
        {
            //return new Person()
            //{
            //    Name = "Juan",
            //    Gender = GenderType.UNKNOWN
            //}
            //;
            return null;
        }
        static void Main(string[] args)
        {
           //Person p = new Person();

           // Person pp = new Person("Manole", GenderType.UNKNOWN);

           // Teacher t = new Teacher(1.0);

            //inicializador de atributos y properties que tu generas
            Teacher t1 = new Teacher()

            {
                Name = "Juan",
                Gender = GenderType.MALE,
            };

            IPerro p = new Teacher();
            
            Person jodete = CreatePerson();
            //jodete.bloodlust = 0; -> esto no se puede
            string name = jodete.GetFullName();
            Console.WriteLine(name);


            Graveyard g = new Graveyard();
            int n = g.PersonCount;

            //llama a metodo virtual, el programa sabe que tipo de objeto es 
            

        }
    }
}