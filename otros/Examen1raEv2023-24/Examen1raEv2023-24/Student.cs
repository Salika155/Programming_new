using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1raEv2023_24
{
    public enum GenderType
    {
        M,
        F,
        DESC
    }
    public class Student
    {
        private string _name;
        private int _age;
        private GenderType _gender;
        private double _altura;
        private double _peso;
        private double _nota;

        public Student()
        {

        }

        public Student(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public Student(string name, int age, GenderType gender, double altura, double peso, double nota) : this(name, age)
        {
            _gender = gender;
            _altura = altura;
            _peso = peso;
            _nota = nota;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetAge()
        {
            return _age;
        }

        public GenderType GetGenderType()
        {
            if (_gender == GenderType.M)
                return GenderType.M;
            else return GenderType.F;
        }

        public double GetAltura()
        {
            return _altura;
        }

        public double GetPeso()
        {
            return _peso;
        }

        public double GetNota()
        {
            return _nota;
        }

        public void SetNota(double note)
        {
            _nota = note;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        public void SetGenderType(GenderType gender)
        {
            _gender = gender;
        }

        public void SetAltura(int altura)
        {
            _altura = altura;
        }

        public void SetPeso(double peso)
        {
            _peso = peso;
        }

        public double GetIMC(double peso, double altura)
        {
            double IMC = peso / (altura * altura);
            return IMC;
        }

        public bool IsElder()
        {
            if (_age < 18) return false; return true;
        }

        //public Student GetAverage(double nota)
        //{

        //}

        public Student CloneStudent()
        {
            return new Student(_name, _age, _gender, _altura, _peso, _nota);
            //nota no debe de cambiar si cambio la nota de un estudiante clonado, osea
            //del que procede
        }
    }
}
