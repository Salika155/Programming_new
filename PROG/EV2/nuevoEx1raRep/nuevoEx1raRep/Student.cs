using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace nuevoEx1raRep
{
    public enum GenderType
    {
        M, F, N
    }

    public class Student
    {
        private string _name = "";
        private int _age;
        private GenderType _gender;
        private double _height;
        private double _weight;
        private Notes _notes = new Notes();

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => GetAge();
            set => _age = value;
        }

        public GenderType Gender
        {
            get => _gender;
            set => _gender = value;
        }

        public double Height
        {
            get => _height;
            set => _height = value;
        }

        public double Weight
        {
            get => _weight;
            set => _weight = value;
        }

        public Notes Notes
        {
            get => _notes;
            set => _notes = value;
        }


        public Student()
        {
            
        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int GetAge()
        {
            return _age;
        }

        public double GetIMC()
        {
            return _weight / (_height * _height);
        }

        public static double GetCalculateIMC(double height, double weight)
        {
            return weight / (height * height);
        }

        public double GetBestMark()
        {
            double result = _notes.GetNoteAt(0).GetValue();
            for (int i = 1; i < _notes.Count; i++)
            {
                if (_notes.GetNoteAt(i).GetValue() > result)
                    result = _notes.GetNoteAt(i).GetValue();
            }
            return result;
        }
       

        public static double GetAverageAsignature(Notes notes)
        {
            double sum = notes.Count;

            return (notes.Math + notes.Literature + notes.English + notes.Science + notes.History) / sum ;
            
        }

        public static bool IsElder(Student student)
        {
            return student.Age >= 18;
        }

        public Student Clone()
        {
            Student s = new Student();

            s.Name = Name;
            s.Age = Age;
            s.Weight = Weight;
            s.Height = Height;
            s.Gender = Gender;
            s.Notes = _notes.Clone();
           
            return s;
        }
        

    }
}
