using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1raEv2023_24
{
    public class Statistic
    {
        private List<Student> students = new List<Student>();
        public double GetAverageIMC(Classroom classroom)
        {
            return 0;
        }

        public Student? GetYoungestStudent(Classroom classroom)
        {
            if (students == null)
                return null;

            for (int i = 0; i < students.Count; i++)
            {
                int min = int.MaxValue;
                if (students[i].GetAge() >= min)
                    min = students[i].GetAge();
                i++;
            }
            return null;
            
        }

        public Student? GetSortedStudentForSignature(Classroom classroom, Asignaturas asignaturas)
        {
            if (classroom == null || students == null)
                return null;

            for (int i = 0; i < students.Count; i++)
            {
                //if (students.GetIMC())
            }
            return null;
            

        }

        public GenderType GetStudentsWithGender()
        {
            
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].GetGenderType() == GenderType.M )
                    return GenderType.M;
                if (students[i].GetGenderType() == GenderType.F)
                    return GenderType.F;
            }
            return GenderType.DESC;


        }

        public List<Student>? GetStadistics(Classroom classroom)
        {
            if (students == null || classroom == null)
                return null;

            return students;
        }
    }
}
