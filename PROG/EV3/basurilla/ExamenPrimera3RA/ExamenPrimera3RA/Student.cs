using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimera3RA
{
    public enum Gender
    {
        M,
        F,
        DESC
    }

    public class Student
    {
        Student student = new Student();

        private string _name = "";
        private int _age;
        private Gender _gender = Gender.DESC;
        private double _height;
        private double _width;
        private Notes _notes = new Notes();

        private readonly List<double> signatures = new List<double>();

        public Student()
        {

        }

        public Student(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public Gender Gender
        {
            get => GetGender();
            set => _gender = value;
        }

        public double Width
        {
            get => _width;
            set => _width = value;
        }

        public double Height
        {
            get => _height;
            set => _height = value;
        }

        public Notes GetNotes
        {
            get => _notes;
            set => _notes = value;
        }

        public double GetIMC()
        {
            if (Width < 0.00001 || Height < 0.00001)
                return double.NaN;
            return Width / (Height * Height);
        }

        public double GetBestQualification() => _notes.GetMajorQualification();

        public double GetAverageNote()
        {
            return _notes.History + _notes.Language + _notes.Math + _notes.Science / GetSignatureCount();
        }

        private double GetSignatureCount()
        {
            return signatures.Count;
        }

        public bool IsElder() => _age >= 18;

        public Gender GetGender() => _gender;
        public Student Clone()
        {
            Student s = new Student();

            s._name = Name;
            s._age = Age;
            s._gender = Gender;
            s._height = Height;
            s._width = Width;
            s._notes = GetNotes.Clone();

            return s;
        }
    }
}
