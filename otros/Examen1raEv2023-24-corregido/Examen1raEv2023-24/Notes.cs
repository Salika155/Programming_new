using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examen1raEv2023_24
{

    public enum Signatures
    {
        MATEMATICAS,
        LENGUAJE,
        HISTORIA,
        CIENCIA
    }

    public class Notes
    {
        List<Student> students = new List<Student>();

        private double _maths;
        private double _language;
        private double _history;
        private double _science;
        private double _nota;
        

        public Notes()
        {

        }

        
        public double GetNota()
        {
            return _nota;
        }

        //no la completo
        //public int GetNotaWithName(string name, double? nota)
        //{
        //    if (name == null || nota == null)
        //        return -1;

        //    for (int i = 0; i < students.Count; i++)
        //    {
        //        if (students[i].GetName() == name && students[i].GetNota() == nota)
        //        {
        //            List<Student> studentswithnota = new List<Student>();
        //            studentswithnota.Add(students[i]);
        //        }
        //        return i;
        //    }
        //    return 0;
            
        //}

       
        public double GetQualificationForSignature(Signatures signatures)
        {
            if (signatures == Signatures.MATEMATICAS)
                return GetMath();
            if (signatures == Signatures.CIENCIA)
                return GetScience();
            if (signatures == Signatures.LENGUAJE)
                return GetLanguage();
            if (signatures == Signatures.HISTORIA)
                return GetHistory();
            return 0.0;
            //se puede hacer retornando el valor _maths por ejemplo, o el getmath directamente
        }


        public void SetQualificationForSignature(Signatures signature, double value)
        {
            if (signature == Signatures.MATEMATICAS)
                _maths = value;
            if (signature == Signatures.CIENCIA)
                _science = value;
            if (signature == Signatures.LENGUAJE)
                _language = value;
            if (signature == Signatures.HISTORIA)
                _history = value;
        }

        //public double GetMediaAllAsignatures(Signatures asignaturas)
        //{
        //    double media = 0;
        //    for (int i = 0; i < students.Count; i++)
        //    {


        //    }
        //    return media;
        //}

        //public Student? GetHigherAssignatureNote(Signatures asignaturas, Notes notas)
        //{
        //    if (notas == null || students == null)
        //        return null;

        //    double max = double.MinValue;
        //    for (int i = 0; i < students.Count; i++)
        //    {
        //        if (students[i].GetNota() <= max && (asignaturas == Signatures.MATEMATICAS ||
        //            asignaturas == Signatures.CIENCIA || asignaturas == Signatures.LENGUAJE ||
        //            asignaturas == Signatures.HISTORIA))
        //        {
        //            for(int j = 0; j < students.Count; j++)
        //            {
        //                if (max <= students[i].GetNota())
        //                {
        //                    students[i].SetNota(max);
        //                    i++;


                            
        //                }
        //            }
        //            return students[i];

        //        }
        //    }
        //    return null;
        //}

        //public Signatures GetLowerAssignatureNote()
        //{
        //    return Signatures.MATEMATICAS;
        //}

        //public Signatures GetLowerCalification()
        //{
        //    return Signatures.MATEMATICAS;
        //}

        //public List<Student>? GetHigherCalification()
        //{
        //    if (students == null)
        //        return null;

        //    for (int i = 0; i < students.Count; i++)
        //    {
        //        double max = double.MinValue;
        //        if (students[i].GetNota() >= max)
        //        {
        //            max = students[i].GetNota();
        //            i++;
        //        }
        //    }
        //    return students;
        //}

        public double GetAverage()
        {
            return 0.0;
        }

       

        public Notes Clone()
        {
            Notes result = new Notes();

            result._maths = _maths;
            result._history = _history;
            result._language = _language;
            result._science = _science;

            return result;
        }

        public double GetMath()
        {
            return _maths;
        }

        public void SetMath(double value)
        {
            _maths = value;
        }

        public double GetHistory()
        {
            return _history;
        }

        public void SetHistory(double value)
        {
            _history = value;
        }

        public double GetLanguage() 
        {
            return _language;
        }

        public void SetLanguage(double value)
        {
            _language = value;
        }

        public double GetScience()
        {
            return _science;
        }

        public void SetScience(double value)
        {
            _science = value;
        }
    }
}
