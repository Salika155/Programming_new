namespace ExamenProgramacion
{
    public class Stadistics
    {
        public static double GetAverageIMC(Classroom classroom)
        {
            if (classroom == null)
                return double.NaN;
            double sum = 0;
            for (int i = 0; i < classroom.GetStudentsCount(); i++)
            {
                 Student? st = classroom.GetStudentAt(i);
                if (st != null)
                    sum += st.GetIMC();
            }
            return sum/classroom.GetStudentsCount();
        }

        public static Student? GetBestStudent(Classroom classroom)
        {
            double mark = 0;
            Student? best = null;
            for (int i = 0; i < classroom.GetStudentsCount(); i++)
            {
                Student? st = classroom.GetStudentAt(i);
                if (st != null)
                {
                    if (st.GetHightQualification() > mark)
                    {
                        mark = st.GetHightQualification();
                        best = st;
                    }
                }
            }
            return best;
        }
        public static Student? GetYoungestStudent(Classroom classroom)
        {
            int age = int.MaxValue;
            Student? youngest = null;
            for (int i = 0; i < classroom.GetStudentsCount(); i++)
            {
                Student? st = classroom.GetStudentAt(i);
                if (st != null)
                {
                    if (st.GetAgeInMonth() < age )
                    {
                        age = st.GetAgeInMonth();
                        youngest = st;
                    }
                }
            }
            return youngest;
        }
        public static List<Student> GetSortedStudentsForSignature(Classroom classroom, Signatures signature)
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < classroom.GetStudentsCount(); i++)
            {
                Student? st = classroom.GetStudentAt(i);
                if (st != null)
                {
                    students.Add(st);
                }
            }
            for (int i = 0; i < students.Count; i++)
            {
                for (int j = i+1; j < students.Count; j++)
                {
                    var si = students[i].GetQualificationsForSignature(signature);
                    var sj = students[j].GetQualificationsForSignature(signature);

                    if (sj > si)
                    {
                        var aux = students[j];
                        students[j] = students[i];
                        students[i] = aux;
                    }
                }
            }
            return students;
        }
        public static List<Student> GetStudentWithGender(Classroom classroom, Gender gender)
        {
            List<Student> result = new();
            for (int i = 0; i < classroom.GetStudentsCount(); i++)
            {
                Student? st = classroom.GetStudentAt(i);
                if (st != null)
                {
                    if (st.GetGender() == gender)
                        result.Add(st);
                }
            }
            return result;
        }
        public static List<double> GetStadistics(Classroom classroom) //Devuelvo los valores acordados en el examen en forma de lista en el que se ordenan las agrupaciones de notas de mayor a menor.
        {
            List<double> result = new();
            for (int i = 0; i < 5; i++)
                result.Add(0);

            for (int i = 0; i < classroom.GetStudentsCount(); i++)
            {
                Student? st = classroom.GetStudentAt(i);
                if (st != null)
                {
                    var q = st.GetAverageQualifications();

                    if (q > 9)
                        result[0] += q;
                    else if (q <= 9 && q >= 7)
                        result[1] += q;
                    else if (q < 7 && q >= 5)
                        result[2] += q;
                    else if (q < 5 && q >= 3)
                        result[3] += q;
                    else if (q > 3 && q >= 0)
                        result[4] += q;
                }
            }
            return result;
        }
    }
}
