using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimera3RA
{
    public class Statistic
    {
        public class NoteStadistics
        {
            public int MajorThan9;
            public int MajorThan7;
            public int MajorThan5;
            public int MajorThan3;
            public int MajorThan0;

        }

        private List<Student> _students = new List<Student>();

        public static double GetAverageIMC(Classroom classroom)
        {
            if (classroom == null)
                return double.MinValue; 

            double result = 0.0;

            // Itera sobre todos los estudiantes en el aula y suma sus IMC
            for (int i = 0; i < classroom.Count; i++)
            {
                Student? s = classroom.GetStudentAt(i);
                result += s.GetIMC();
            }
            return result / classroom.Count; // Calcula el promedio dividiendo la suma total por la cantidad de estudiantes
        }

        public static Student? GetBestStudent(Classroom classroom)
        {
            if (classroom == null || classroom.Count == 0)
                return null;

            Student? best = classroom.GetStudentAt(0); // Se inicializa con el primer estudiante

            // Itera sobre todos los estudiantes en el aula para encontrar al estudiante con la mejor calificación
            for (int i = 1; i < classroom.Count; i++)
            {
                Student? s = classroom.GetStudentAt(i);
                if (s.GetBestQualification() > best.GetBestQualification())
                {
                    best = s; // Actualiza el mejor estudiante si encuentra uno con una calificación más alta
                }
            }
            return best; 
        }

        public static Student? GetYoungestStudent(Classroom? classroom)
        {
            if (classroom == null || classroom.Count == 0)
                return null; 

            Student? youngest = classroom.GetStudentAt(0); // Se inicializa con el primer estudiante

            // Itera sobre todos los estudiantes en el aula para encontrar al más joven
            for (int i = 1; i < classroom.Count; i++)
            {
                Student? s = classroom.GetStudentAt(i);
                if (s.Age < youngest.Age)
                {
                    youngest = s; // Actualiza el estudiante más joven si encuentra uno más joven
                }
            }
            return youngest; // Devuelve el estudiante más joven encontrado
        }

        public static List<Student>? GetSortedStudentsForSignature(Classroom? classroom, AsignaturasType asignaturas)
        {
            List<Student>? sorted = GetAllStudents(classroom); // Obtiene todos los estudiantes del aula
            if (sorted == null)
                return null; // Si la lista es nula, devuelve nulo

            SortedStudentsForSignature(sorted, asignaturas); // Ordena los estudiantes según la asignatura especificada
            return sorted; // Devuelve la lista de estudiantes ordenada
        }

        private static List<Student>? GetAllStudents(Classroom? classroom)
        {
            if (classroom == null || classroom.Count == 0)
                return null; // Si el aula es nula o está vacía, devuelve nulo

            List<Student>? students = new List<Student>();

            // Itera sobre todos los estudiantes en el aula y los agrega a la lista
            for (int i = 0; i < classroom.Count; i++)
            {
                Student? s = classroom.GetStudentAt(i);
                students.Add(s);
            }
            return students; // Devuelve la lista de estudiantes
        }

        private static void SortedStudentsForSignature(List<Student> sorted, AsignaturasType asignaturas)
        {
            // Ordena la lista de estudiantes según las calificaciones de una asignatura específica
            for (int i = 0; i < sorted.Count - 1; i++)
            {
                for (int j = i + 1; j < sorted.Count; j++)
                {
                    double qualification_i = sorted[i].GetNotes.GetQualificationForSignature(asignaturas);
                    double qualification_j = sorted[j].GetNotes.GetQualificationForSignature(asignaturas);

                    if (qualification_j > qualification_i)
                    {
                        Student aux = sorted[i];
                        sorted[i] = sorted[j];
                        sorted[j] = aux;
                    }
                }
            }
        }

        public static List<Student>? GetAllStudents(Classroom? classroom, Gender gender)
        {
            if (classroom == null || classroom.Count == 0)
                return null; // Si el aula es nula o está vacía, devuelve nulo

            List<Student>? students = new List<Student>();

            // Itera sobre todos los estudiantes en el aula y agrega aquellos que coincidan con el género especificado
            for (int i = 0; i < classroom.Count; i++)
            {
                Student? s = classroom.GetStudentAt(i);
                if (s.Gender == gender)
                    students.Add(s);
            }
            return students; // Devuelve la lista de estudiantes filtrada por género
        }

        public static List<Student>? GetStudentsWithGender(Classroom classroom, Gender gender)
        {
            if (classroom == null || classroom.Count == 0)
                return null; // Si el aula es nula o está vacía, devuelve nulo

            List<Student> allstudents = new List<Student>();

            // Itera sobre todos los estudiantes en el aula y agrega aquellos que coincidan con el género especificado
            for (int i = 0; i < classroom.Count; i++)
            {
                Student? s = classroom.GetStudentAt(i);
                if (s.Gender == gender)
                    allstudents.Add(s);
            }
            return allstudents; // Devuelve la lista de estudiantes filtrada por género
        }

        public static NoteStadistics GetStadistics(Classroom? classroom)
        {
            if (classroom == null || classroom.Count == 0)
                return new NoteStadistics(); // Si el aula es nula o está vacía, devuelve un objeto NoteStadistics vacío

            NoteStadistics? statistics = new NoteStadistics(); // Inicializa un objeto NoteStadistics para almacenar las estadísticas

            // Itera sobre todos los estudiantes en el aula para calcular las estadísticas
            for (int i = 0; i < classroom.Count; i++)
            {
                Student? s = classroom.GetStudentAt(i);
                double qualification = s.GetNotes.GetAverage(); // Obtiene el promedio de las notas del estudiante

                // Incrementa los contadores en función del promedio de notas
                if (qualification >= 9)
                    statistics.MajorThan9++;
                else if (qualification >= 7)
                    statistics.MajorThan7++;
                else if (qualification >= 5)
                    statistics.MajorThan5++;
                else if (qualification >= 3)
                    statistics.MajorThan3++;
                else
                    statistics.MajorThan0++;
            }
            return statistics; // Devuelve el objeto NoteStadistics con las estadísticas calculadas
        }
    }
}
