using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevoEx1raRep
{
    public class ClassroomOverAllMarks
    {
        public int StudentsHigherThan9;
        public int StudentsBetween7and9;
        public int StudentsBetween5and7;
        public int StudentsBetween3and5;
        public int StudentsLowerThan3;

        public ClassroomOverAllMarks(int count1, int count2, int count3, int count4, int count5)
        {
            StudentsHigherThan9 = count1;
            StudentsBetween7and9 = count2;
            StudentsBetween5and7 = count3;
            StudentsBetween3and5 = count4;
            StudentsLowerThan3 = count5;
        }
    }

    public class Statistics
    {
        public static double GetAverageIMC(Classroom classroom)
        {
            double sum = 0;
            int count = 0;
            for (int i = 0; i < classroom.Count; i++)
            {
                sum += classroom.GetStudentAt(i).GetIMC();
                count++;
            }
            return sum / classroom.Count;
        }

        public static Student GetBestStudent(Classroom classroom)
        {
            Student bestStudent = classroom.GetStudentAt(0);
            for (int i = 1; i < classroom.Count; i++)
            {
                if (classroom.GetStudentAt(i).GetBestMark() > bestStudent.GetBestMark())
                bestStudent = classroom.GetStudentAt(i);
            }
            return bestStudent;
        }

        public static Student GetYoungestStudent(Classroom classroom)
        {
            Student youngestStudent = classroom.GetStudentAt(0);
            for (int i = 1; i < classroom.Count; i++)
            {
                if (classroom.GetStudentAt(i).GetAge() < youngestStudent.GetAge())
                youngestStudent = classroom.GetStudentAt(i);
            }
            return youngestStudent;
        }

        public static List<Student> OrderStudentsWithAge(List<Student> students)
        {
            Student aux;
            for (int i = 0; i < students.Count - 1; i++)
            {
                for (int j = i + 1; j < students.Count; j++)
                {
                    if (students[i].GetAge() > students[j].GetAge())
                    {
                        aux = students[i];
                        students[i] = students[j];
                        students[j] = aux;
                    }
                }
            }
            return students;
        }

        public static List<Student> GetStudentWithGenderOrderedByAge(GenderType gender, Classroom classroom)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < classroom.Count; i++)
            {
                if (classroom.GetStudentAt(i).Gender == gender)
                    students.Add(classroom.GetStudentAt(i));
            }
            return OrderStudentsWithAge(students);
        }

        public static ClassroomOverAllMarks GetStadistics(Classroom classroom)
        {
            int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0;
            for (int i = 0; i < classroom.Count; i++)
            {
                double mark = classroom.GetStudentAt(i).Notes.GetMayorMark();
                if (mark >= 9)
                    count1++;
                else if (mark >= 7 && mark < 9)
                    count2++;
                else if (mark >= 5 && mark < 7)
                    count3++;
                else if (mark >= 3 && mark < 5)
                    count4++;
                else
                    count5++;
            }
            return new ClassroomOverAllMarks(count1, count2, count3, count4, count5);
        }
    }
}
