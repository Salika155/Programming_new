namespace Model
{
    public class DatabaseRam : IDatabase
    {
        private static DatabaseRam _database = new DatabaseRam();
        private List<Student> _students = new List<Student>();
        //private Dictionary<long, Student> _students = new Dictionary<long, Student>();
        private long _studentId = 1;

        public static DatabaseRam Instance => _database;
        public int StudentCount => _students.Count;

        public int Count => _students.Count;

        private DatabaseRam()
        {

        }

        public long AddStudent(Student student)
        {
            if (student == null)
                return -1;

            student.Id = _studentId++;
            _students.Add(student);
            return student.Id;
        }

        public bool ContainsStudent(long id)
        {
            return GetStudentById(id) != null;
        }

        public Student? GetStudentById(long id)
        {
            foreach (var s in _students)
            {
                if (s.Id == id)
                    return s;
            }
            return null;

        }

        public void UpdateStudent(Student student, long id)
        {
            if (student == null)
                return;

            foreach (var s in _students)
            {
                if (s.Id == id)
                {
                    s.Name = student.Name;
                    s.Age = student.Age;
                    s.Description = student.Description;
                    return;
                }
            }

        }

        public void RemoveStudent(long id)
        {
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i].Id == id)
                {
                    _students.RemoveAt(i);
                    return;
                }
            }

        }

        public Student? GetStudentAt(int index)
        {
            if (index < 0 || index >= _students.Count)
                return null;
            return _students[index];

        }

        public int GetStudentCount() => _students.Count;

    }
}
