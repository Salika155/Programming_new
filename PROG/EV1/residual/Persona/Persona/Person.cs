

namespace Persona
{
    public enum GenderType
    {
        MALE,
        FEMALE,
        UNKNOWN
    }
    public class Person
    {
        private string _name = "";
        private GenderType _gender = GenderType.UNKNOWN;
        public int[] _array;

        

        //properties envoltorios de atributos
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        //public string Name { get { return _name; } set { _name = value; } }
        public GenderType Gender { get { return _gender; } set { _gender = value; } }
        


        //constructor que llama a otro, para que ese constructor haga todo.
        public Person() : this("", GenderType.UNKNOWN)
        {

        }
        //primero se ejecutaria la linea del string, y luego el constructor
        //al inicializarlo asi desaparece la advertencia del string name

        public Person(string name, GenderType gender = GenderType.UNKNOWN)
        {
            
            this._name = name;
            this._gender = gender;
            this._array = new int[10];
            for(int i = 0; i < _array.Length; i++)
                this._array[i] = i;
            //generas el array aqui, no necesita de que se lo pases
            //cuando este debugueando shif + f11 para salirte de la funcion si es muy larga
        }
    }
}
