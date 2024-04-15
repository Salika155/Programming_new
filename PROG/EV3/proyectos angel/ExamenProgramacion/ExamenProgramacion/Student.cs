namespace ExamenProgramacion
{
    public enum Gender
    {
        MALE,
        FEMALE,
    }
    public class Student
    {
        private string _name;
        private int _age; //Age se mide en meses.
        private double _height, _weight;
        private Gender _gender;
        private Qualifications _marks;

        public Student()
        {
            _name = "defaultName"; //Para evitar que el nombre sea nulo
            _marks = new Qualifications();
        }
        public Student(string name, int age) 
        {
            _name = name;
            _age = age;
            _marks = new Qualifications();
        }
        public Student(string name, int age, double height, double weight, Gender gender, Qualifications marks)
        {
            _name = name;
            _age = age;
            _height = height;
            _weight = weight;
            _gender = gender;
            _marks = marks;
        }
        public void SetQualification(Qualifications qualifications)
        {
            _marks = qualifications;
        }
        public string GetName()
        {
            return _name;
        }
        public Gender GetGender()
        {
            return _gender;
        }
        public int GetAge()
        {
            return _age/12;
        }
        public int GetAgeInMonth()
        {
            return _age;
        }
        public double GetHeight()
        {
            return _height;
        }
        public double GetWeight()
        {
            return _weight;
        }
        public double GetIMC()
        {
            return ( _weight / ( _height * _height ) );
        }
        //Recuerda obtener media de todas las asignaturas

        public bool IsGreaterAge() //No se si esta bien escrito en ingles.
        {
            return _age > 216;
        }
        public Student Clone()
        {
            return new Student(_name, _age, _height, _weight, _gender, _marks);
        }
        public double GetAverageQualifications()
        {
            return _marks.GetQualificationAverage();
        }
        public double GetHightQualification()
        {
            return _marks.GetHightMark();
        }
        public double GetQualificationsForSignature(Signatures signatures)
        {
            return _marks.GetQualificationForSignature(signatures);
        }
    }
}
