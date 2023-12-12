

namespace Persona
{
    public class Teacher : Person
    {
        public double bloodLust;

        public Teacher(double bloodLust)
        {
            this.bloodLust = bloodLust;
        }

        public Teacher()
        {

        }

        public Teacher(string name, double bloodLust) : base(name, GenderType.UNKNOWN)
        {
            this.bloodLust = bloodLust;

        }

        //base es referencia explicita a la clase base, osea de la que hereda.
        //constructor no puede generar cosas aleatorias con un random, se genera fuera y se le pasa por el constructor
    }
}
