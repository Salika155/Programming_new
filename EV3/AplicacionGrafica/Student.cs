using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionGrafica
{
    // Clase para la información del estudiante
    public class Student
    {
        public string _nombre { get; set; }
        public int _edad { get; set; }
        public string? _descripcion { get; set; }
        public int _posicion { get; set; }
    }

    // Función para agregar un estudiante a la lista
    private void AddStudentToList(string nombre, int edad, string descripcion, int posicion)
    {
        Student student = new Student
        {
            _nombre = nombre,
            _edad = edad,
            _descripcion = descripcion,
            _posicion = posicion
        };

        List<studentList>.Add(student);
    }


}
