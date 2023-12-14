

namespace Persona
{
    public enum GenderType
    {
        MALE,
        FEMALE,
        UNKNOWN
    }
    public abstract class Person
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

        //generar metodo para saber si es profesor o alumno
        public virtual string GetFullName()
        {
            return "<PROFESOR>" + Name + "<PROFESOR";
        }

        //obliga a que los hijos hereden de esta, no tiene cuerpo y no puede crear newperson, o pongo la clase abstract o propago el metodo
        public abstract void ExecuteTurn();
        

        //hay clases que pueden tener que ser abstractas puras, que tienen todos sus metodos, y su clase principal, pero ningun atributo
    }
}
