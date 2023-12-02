using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examen1raEv2023_24
{

    public enum Asignaturas
    {
        MATEMATICAS,
        LENGUAJE,
        HISTORIA,
        CIENCIA
    }
    
    public class Notes
    {
        List<Student> students = new List<Student>();

        private Asignaturas _asignaturas;
        private double _nota;
        

        public Notes()
        {

        }

        public Asignaturas GetAsignaturas()
        {
            if (_asignaturas == Asignaturas.MATEMATICAS)
                return Asignaturas.MATEMATICAS;
            if (_asignaturas == Asignaturas.LENGUAJE)
                return Asignaturas.LENGUAJE;
            if (_asignaturas == Asignaturas.CIENCIA)
                return Asignaturas.CIENCIA;
            else return Asignaturas.HISTORIA;
        }

        public double GetNota()
        {
            return _nota;
        }

        //no la completo
        public int GetNotaWithName(string name, double? nota)
        {
            if (name == null || nota == null)
                return -1;

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].GetName() == name && students[i].GetNota() == nota)
                {
                    List<Student> studentswithnota = new List<Student>();
                    studentswithnota.Add(students[i]);
                }
                return i;
            }
            return 0;
            
        }

        public void SetAsignatura(Asignaturas asignatura)
        {
            _asignaturas = asignatura;
        }

        public int GetQualificationForSignature(List<Student> student, Asignaturas asignaturas)
        {
            //for (int i = 0; i < students.Count; i++)
            //{
            //    for (int j = 0; j < _asignaturas.Count; j++)
            //    {
            //        if (student[i].GetNota() == _asignaturas[j].GetAsignature()
            //    }

            //}
            return 0;
        }


        public void SetQualificationForSignature(Asignaturas asignaturas)
        {


        }

        public double GetMediaAllAsignatures(Asignaturas asignaturas)
        {
            double media = 0;
            for (int i = 0; i < students.Count; i++)
            {


            }
            return media;
        }

        public Student? GetHigherAssignatureNote(Asignaturas asignaturas, Notes notas)
        {
            if (notas == null || students == null)
                return null;

            double max = double.MinValue;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].GetNota() <= max && (asignaturas == Asignaturas.MATEMATICAS ||
                    asignaturas == Asignaturas.CIENCIA || asignaturas == Asignaturas.LENGUAJE ||
                    asignaturas == Asignaturas.HISTORIA))
                {
                    for(int j = 0; j < students.Count; j++)
                    {
                        if (max <= students[i].GetNota())
                        {
                            students[i].SetNota(max);
                            i++;


                            
                        }
                    }
                    return students[i];

                }
            }
            return null;
        }

        public Asignaturas GetLowerAssignatureNote()
        {
            return Asignaturas.MATEMATICAS;
        }

        public Asignaturas GetLowerCalification()
        {
            return Asignaturas.MATEMATICAS;
        }

        public List<Student>? GetHigherCalification()
        {
            if (students == null)
                return null;

            for (int i = 0; i < students.Count; i++)
            {
                double max = double.MinValue;
                if (students[i].GetNota() >= max)
                {
                    max = students[i].GetNota();
                    i++;
                }
            }
            return students;
        }



    }
}
