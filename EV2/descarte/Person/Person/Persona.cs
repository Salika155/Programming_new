using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace Person
{

    public enum PersonaSex
    {
        MALE,
        FEMALE,
    }
    public class Persona
    {
        private string _name;
        private int _age;
        private string _nif;
        private PersonaSex _gender;
        private double _weight;
        private double _height;

        public Persona() 
        {
            
        }

        public Persona(PersonaSex gender)
        {
            _gender = gender;
        }

        public Persona(string name, int age, PersonaSex gender)
        {
            _name = name;
            _age = age;
            _gender = gender;
        }

        public Persona(string name, int age, PersonaSex gender, double weight, double height)
        {
            _gender = gender;
            _weight = weight;
            _height = height;
            _name = name;
            _age = age;
            _nif = GenerateDNI();
        }


        //propierties
        public string Name { get { return _name; } set { _name = value; } }

        public int Age { get { return _age; } set { _age = value; } }

        public string Nif { get { return _nif; } }

        public PersonaSex Gender { get { return _gender; } set { _gender = value;} }

        public double Weight { get { return _weight; } set {_weight = value;} }

        //height metros
        public double Height { get { return _height;} set { _height = value;} }

        //metodos
        public string ToString()
        {
            return String.Format("Name: {0}, Age {1}, nif {2}, gender {3}, weight {4}, height {5}", _name, _age, _nif, _gender, _weight, _height);
        }
        //weight /  (height * height)
        public double CalcularIMC()
        {
            double imc = Weight / (Height * Height);

            return imc;
        }

        public bool esMayorDeEdad()
        {
            if (Age < 18)
                return false;
            else
                return true;

        }

        public bool ConfirmaSexo(PersonaSex sex)
        {
            if (Gender == sex)
            return true;
            else
                return false;
        }

        public string GenerateDNI()
        {
            Random r = new Random();

            string dni = "" + r.Next(1, 99999999);
            while(dni.Length < 8)
            {
                dni = "0" + dni;
            }
            dni += (char)r.Next(65, 90);
            return dni;
        }

    }


}
