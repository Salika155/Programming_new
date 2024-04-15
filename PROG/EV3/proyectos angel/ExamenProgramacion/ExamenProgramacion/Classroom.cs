namespace ExamenProgramacion
{
    public class Classroom
    {
        private List<Student> _students = new();
        private string _name;

        public Classroom()
        {
            _name = "defaultName";
        }
        public Classroom(List<Student> students, string name)
        {
            if (students == null)
                throw new Exception("La lista es null");
            _students = students;
            _name = name;
        }

        public int GetStudentsCount()
        {
            return _students.Count;
        }

        public string GetClassName()
        {
            return _name;
        }

        public Student? GetStudentAt(int index)
        {
            if (index < 0 || index >= _students.Count)
                return null;
            return _students[index];
        }
        public void AddStudent(Student student)
        {
            if (student != null)
                _students.Add(student);
        }
        public void RemoveStudentAt(int index)
        {
            if (index < 0 || index >= _students.Count)
                return;
            _students.RemoveAt(index);
        }
        public bool ContainsStudentWithName(string name)
        {
            for(int i = 0; i < _students.Count; i++)
            {
                Student st = _students[i];
                if (st.GetName() == name)
                    return true;
            }
            return false;
        }
        public void RemoveStudentWithName(string name)
        {
            for (int i = 0; i < _students.Count; i++)
            {
                Student st = _students[i];
                if (st.GetName() == name)
                    _students.RemoveAt(i);
            }
        }
    }
}
