namespace ExamenProgramacion
{

    public class Program
    {
        static void Main(string[] args)
        {
            Classroom c = new();
            c.AddStudent(new Student("Angel", 1, 180, 80, Gender.MALE, new Qualifications(true)));
            c.AddStudent(new Student("Juan", 10, 180, 80, Gender.MALE, new Qualifications()));
            c.AddStudent(new Student("Juan", 10, 180, 80, Gender.MALE, new Qualifications()));
            c.AddStudent(new Student("Juan", 10, 180, 80, Gender.MALE, new Qualifications()));
            c.AddStudent(new Student("Juan", 10, 180, 80, Gender.MALE, new Qualifications()));
            c.AddStudent(new Student("Juan", 10, 180, 80, Gender.MALE, new Qualifications()));
            c.AddStudent(new Student("Alex", 10, 180, 80, Gender.MALE, new Qualifications(true)));
            Console.WriteLine(c.GetStudentAt(0).GetIMC());
            var a = Stadistics.GetAverageIMC(c);
                Console.WriteLine(a);
        }
    }
}