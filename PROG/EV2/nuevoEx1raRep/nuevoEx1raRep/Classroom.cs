using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevoEx1raRep
{
    public class Classroom
    {
        private List<Student> _students = new List<Student>();
        private string? _name = "";

        public Classroom()
        {
        }

        public Classroom(List<Student> students)
        {
            _students = students;

        }

        public int Count 
        {
            get => _students.Count;
        }

        public string? Name
        {
            get => _name;
            set => _name = value;
        }

        public Student? GetStudentAt(int index)
        {
            if (index >= 0 && index < _students.Count)
                return _students[index];
            return null;

        }

        public void AddStudent(Student student)
        {
            if (student == null)
                return;
            _students.Add(student);
        }

        public void RemoveStudentAt(int index)
        {
            if (index >= 0 && index < _students.Count)
                _students.RemoveAt(index);
        }

        public int GetStudentWithName(string name)
        {
            if (name == null)
                return -1;
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i].Name == name)
                    return i;
            }
            return -1;
        }

        public List<int> GetStudentsIndexWithName(string name)
        {
            List<int> result = new List<int>();
            for(int i = 0; i < _students.Count; i++)
            {
                if (_students[i].Name == name)
                    result.Add(i);
            }
            return result;
        }



        public bool ContainStudentWithName(string name)
        {
            if (name == null)
                return false;
            //foreach (var student in _students)
            //{
            //    if (student.Name == name)
            //        return true;
            //}
            //return false;
            return (GetStudentsIndexWithName != null);

        }

        public void RemoveStudentByName(string name)
        {
            if (name == null)
                return;
            //for (int i = 0; i < _students.Count; i++)
            //{
            //    if (_students[i].Name == name)
            //    {
            //        _students.RemoveAt(i);
            //        return;
            //    }
            //}
            int deleteCount = 0;
            List<int> result = GetStudentsIndexWithName(name);
            foreach (var index in result)
            {
                _students.RemoveAt(index - deleteCount);
                deleteCount++;
            }
        }

        //public int IndexOfStudentWithName(string name)
        //{
        //    if (name == null)
        //        return -1;
        //   for (int i = 0; i < _students.Count; i++)
        //   {
        //        if (_students[i].Name == name)
        //            return i;
        //   }
        //   return -1;
        //}
        //public List<Student> GetStudentsWithAge(int age)
        //{
        //    List<Student> students = new List<Student>();
        //    foreach (var student in _students)
        //    {
        //        if (student.Age == age)
        //            students.Add(student);
        //    }
        //    return students;
        //}
    }
}
