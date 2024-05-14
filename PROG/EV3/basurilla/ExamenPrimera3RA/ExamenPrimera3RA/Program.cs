namespace ExamenPrimera3RA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Classroom classroom = new Classroom();

            Student s = new Student();

            classroom.AddStudent(s);

            int index = 5;
            classroom.GetStudentAt(index);


        }
    }
}
