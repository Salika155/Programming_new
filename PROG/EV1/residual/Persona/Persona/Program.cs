namespace Persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person p = new Person();

            Person pp = new Person("Manole", GenderType.UNKNOWN);

            Teacher t = new Teacher(1.0);

            //inicializador de atributos y properties que tu generas
            Teacher t1 = new Teacher()
            {
                Name = "Juan",
                Gender = GenderType.MALE,
            }
                ;


            Graveyard g = new Graveyard();
            int n = g.PersonCount;



        }
    }
}