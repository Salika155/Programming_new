namespace nuevoEx1raRep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student("John", 20);
            //Student student2 = new Student("Alice", 22);
            //Student student3 = new Student("Bob", 19);
            //Student student4 = new Student("Alfred", 17);
            //Student student5 = new Student("Mary", 21);
            //Student student6 = new Student("Eve", 18);

            //// Crear una clase
            //Classroom classroom = new Classroom();

            //// Agregar estudiantes a la clase
            //classroom.AddStudent(student1);
            //classroom.AddStudent(student2);
            //classroom.AddStudent(student3);
            //classroom.AddStudent(student4);
            //classroom.AddStudent(student5);
            //classroom.AddStudent(student6);

            //// Probar algunos métodos
            //Console.WriteLine($"Número de estudiantes en la clase: {classroom.Count}");

            //// Buscar un estudiante por nombre
            //string searchName = "Alice";
            //int index = classroom.GetStudentWithName(searchName);
            //if (index != -1)
            //{
            //    Console.WriteLine($"El estudiante {searchName} está presente en la clase.");
            //}
            //else
            //{
            //    Console.WriteLine($"El estudiante {searchName} no está presente en la clase.");
            //}

            //// Eliminar un estudiante por nombre
            //string removeName = "John";
            //classroom.RemoveStudentByName(removeName);
            //Console.WriteLine($"Número de estudiantes después de eliminar a {removeName}: {classroom.Count}");


            //// Crear notas para los estudiantes
            //student1.Notes.Math = 8.5;
            //student1.Notes.Literature = 7.0;
            //student1.Notes.English = 9.2;
            //student1.Notes.History = 6.5;
            //student1.Notes.Science = 8.0;

            //student2.Notes.Math = 9.0;
            //student2.Notes.Literature = 8.5;
            //student2.Notes.English = 7.5;
            //student2.Notes.History = 8.0;
            //student2.Notes.Science = 9.5;

            //student3.Notes.Math = 7.8;
            //student3.Notes.Literature = 6.0;
            //student3.Notes.English = 7.2;
            //student3.Notes.History = 8.2;
            //student3.Notes.Science = 7.5;

            //student4.Notes.Math = 9.5;
            //student4.Notes.Literature = 8.0;
            //student4.Notes.English = 7.5;
            //student4.Notes.History = 8.5;
            //student4.Notes.Science = 9.0;

            //student5.Notes.Math = 7.1;
            //student5.Notes.Literature = 6.8;
            //student5.Notes.English = 7.4;
            //student5.Notes.History = 8.2;
            //student5.Notes.Science = 7.3;

            //student6.Notes.Math = 8.5;
            //student6.Notes.Literature = 7.0;
            //student6.Notes.English = 7.2;
            //student6.Notes.History = 5.5;
            //student6.Notes.Science = 6.0;


            //// Probar algunos métodos relacionados con las notas y el desempeño académico
            //Console.WriteLine("Calificaciones de matemáticas del estudiante John: " + student1.Notes.Math);
            //Console.WriteLine("Calificaciones de matemáticas del estudiante Alice: " + student2.Notes.Math);
            //Console.WriteLine("Calificaciones de matemáticas del estudiante Bob: " + student3.Notes.Math);

            ////Console.WriteLine("Calificación promedio de matemáticas de la clase: " + Statistics.GetStadistics(Student.GetAverageAsignature(classroom));

            //Student bestStudent = Statistics.GetBestStudent(classroom);
            //Console.WriteLine("Mejor estudiante de la clase: " + bestStudent.Name);

            //Student youngestStudent = Statistics.GetYoungestStudent(classroom);
            //Console.WriteLine("Estudiante más joven de la clase: " + youngestStudent.Name);

            //Note note = new Note(AsignatureType.Science);
            //note.SetValue(7.5);
            //Console.WriteLine("Nota de ciencias: " + note.GetValue());

            Student student1 = new Student("John", 20);
            Student student2 = new Student("Alice", 22);
            Student student3 = new Student("Bob", 19);

            // Crear una clase y agregar estudiantes
            Classroom classroom = new Classroom();
            classroom.AddStudent(student1);
            classroom.AddStudent(student2);
            classroom.AddStudent(student3);

            // Probar algunos métodos de Classroom
            Console.WriteLine($"Número de estudiantes en la clase: {classroom.Count}");

            // Obtener un estudiante por nombre
            string searchName = "Alice";
            int index = classroom.GetStudentWithName(searchName);
            if (index != -1)
            {
                Console.WriteLine($"El estudiante {searchName} está presente en la clase.");
            }
            else
            {
                Console.WriteLine($"El estudiante {searchName} no está presente en la clase.");
            }

            // Eliminar un estudiante por nombre
            string removeName = "John";
            classroom.RemoveStudentByName(removeName);
            Console.WriteLine($"Número de estudiantes después de eliminar a {removeName}: {classroom.Count}");

            // Crear notas para los estudiantes
            student1.Notes.Math = 8.5;
            student1.Notes.Literature = 7.0;
            student1.Notes.English = 9.2;
            student1.Notes.History = 6.5;
            student1.Notes.Science = 8.0;

            student2.Notes.Math = 9.0;
            student2.Notes.Literature = 8.5;
            student2.Notes.English = 7.5;
            student2.Notes.History = 8.0;
            student2.Notes.Science = 9.5;

            student3.Notes.Math = 7.8;
            student3.Notes.Literature = 6.0;
            student3.Notes.English = 7.2;
            student3.Notes.History = 8.2;
            student3.Notes.Science = 7.5;

            // Probar algunos métodos de Statistics
            Student bestStudent = Statistics.GetBestStudent(classroom);
            Console.WriteLine("Mejor estudiante de la clase: " + bestStudent.Name);

            Student youngestStudent = Statistics.GetYoungestStudent(classroom);
            Console.WriteLine("Estudiante más joven de la clase: " + youngestStudent.Name);

            // Obtener y establecer notas individuales
            Note note = student1.Notes.GetNoteByAsignature(AsignatureType.Science);
            if (note != null)
            {
                Console.WriteLine("Nota de ciencias para John: " + note.GetValue());
                note.SetValue(7.8); // Cambiar la nota de ciencias para John
                Console.WriteLine("Nueva nota de ciencias para John: " + note.GetValue());
            }

            // Imprimir las notas de un estudiante
            Console.WriteLine("Notas de Alice:");
            Console.WriteLine($"Matemáticas: {student2.Notes.Math}");
            Console.WriteLine($"Literatura: {student2.Notes.Literature}");
            Console.WriteLine($"Inglés: {student2.Notes.English}");
            Console.WriteLine($"Historia: {student2.Notes.History}");
            Console.WriteLine($"Ciencias: {student2.Notes.Science}");
        }
    }
}
