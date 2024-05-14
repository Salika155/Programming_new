using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimera3RA
{
    public class Classroom
    {
        private List<Student> students = new List<Student>();
        private string? _nameClassroom = "";

        public string Name
        {
            get => _nameClassroom;
            set => _nameClassroom = value;
        }

        public int Count => students.Count;
        public Classroom()
        {

        }

        public Classroom(string nameclassroom)
        {
            _nameClassroom = nameclassroom;
        }

        public Classroom(List<Student> students)
        {
            if (students != null)
            {
                for (int i = 0; i < students.Count; i++)
                {
                    Student s = students[i];
                    if (s != null)
                        students.Add(s.Clone());
                }
            }
        }

        //como tengo que gestionar una lista tengo que hacer un getstudentat

        public Student? GetStudentAt(int index)
        {
            if (index < 0 || index >= students.Count)
                return null;
            return students[index];
        }

        //clonar lista

        public void AddStudent(Student student)
        {
            if (student == null)
                return;
            students.Add(student);
        }

        public void RemoveStudentsAt(int index)
        {
            if (index < 0 || index >= students.Count)
                return;
            students.RemoveAt(index);
        }

        public bool CointainsStudentWithName(string name)
        {
            return IndexOfStudentWithName(name) >= 0;
        }

        public int IndexOfStudentWithName(string name)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == name)
                    return i;
            }
            return -1;
        }

        public void RemoveStudentWithName(string name)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == name)
                    students.RemoveAt(i);
                i--;
            }
        }
    }
}
