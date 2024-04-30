using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IDatabase
    {
        void AddStudent(Student student);
        Student? GetStudent(long id);
        void UpdateStudent(Student student, long id);
        void RemoveStudent(long id);
        Student? GetStudentAt(int index);
        int GetStudentCount();

    }
}
