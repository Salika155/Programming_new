using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Database : IDatabase
    {
        private static Database _database = new Database();
        private Dictionary<long, Student> _students = new Dictionary<long, Student>();
        private long _studentId = 1;

        public static Database Instance => _database;
        public int StudentCount => _students.Count;


        private Database()
        {

        }


        public int GetStudentCount()
        {
            throw new NotImplementedException();
        }

        public void RemoveStudent(long id)
        {
            throw new NotImplementedException();
        }

        void IDatabase.AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        Student IDatabase.GetStudent(long id)
        {
            throw new NotImplementedException();
        }

        Student IDatabase.GetStudentAt(int index)
        {
            throw new NotImplementedException();
        }

        void IDatabase.UpdateStudent(Student student, long id)
        {
            throw new NotImplementedException();
        }
    }
}
