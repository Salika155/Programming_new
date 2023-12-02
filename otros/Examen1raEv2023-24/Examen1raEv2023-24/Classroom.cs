using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1raEv2023_24
{
    public class Classroom
    {
        private List<Student> _students = new List<Student>();
        private string _nameClassroom;

        public Classroom()
        {

        }

        public Classroom(List<Student> students, string nameClassroom)
        {
            _students = students;
            _nameClassroom = nameClassroom;
        }

        public string GetNameClassroom()
        {
            return _nameClassroom;
        }

        public void SetNameClassroom(string name)
        {
            _nameClassroom = name;
        }

        public void AddStuden(Student student)
        {
            _students.Add(student);
        }

        public void RemoveStudentAt(int index)
        {
            _students.RemoveAt(index);
        }

        public bool ContainStudentWithName(string name)
        {
            if (_students == null)
                return false;

            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i].GetName() != name)
                    return false;
            }
            return true;

        }

        public void RemoveStudentsWithName(string name)
        {
            if (_students == null)
                return;

            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i].GetName() == name)
                    _students.RemoveAt(i);
            }
        }

        public Student? CreateStudent()
        {
            if (_students == null)
                return null;

            int count = _students.Count;
            for (int i = 0; i < _students.Count; i++)
            {
                Student student = new Student();
                _students.Add(student);

            }
            return _students[count];
            
        }
    }
}
