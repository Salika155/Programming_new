namespace Model
{
    public interface IDatabase
    {
        long AddStudent(Student student);
        Student? GetStudentById(long id);
        void UpdateStudent(Student student, long id);
        void RemoveStudent(long id);
        Student? GetStudentAt(int index);
        int Count { get;}

    }
}
