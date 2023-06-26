using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public enum GenderType
        {
        Male,
        Female,
        Other
        }
    public class Person
    {
        private string _name;
        private int _age;
        private string _dni;
        private GenderType _gender;
        private double _weigth;
        private double _height;

        public Person()
        {
            _gender = GenderType.Male;
            _dni = GenerateDNI();

        }

        public Person(string name, int age, GenderType gender)
        {
            _name = name;
            _age = age;
            _gender = gender;
            _dni = GenerateDNI();
        }

        public Person(string name, int age, string dni, GenderType gender, double weight, double height)
        {
            _name = name;
            _age = age;
            _dni = GenerateDNI();
            _gender = gender;
            _weigth = weight;
            _height = height;
        }

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Dni { get => _dni; }
        public GenderType Gender { get => _gender; set => _gender = value; }
        public double Weight { get => _weigth;  set => _weigth = value; } 
        public double Height { get => _height; set => _height = value; }

        public double CalculateIMC()
        {    
            return Weight / (Height * Height);
        }

        public bool IsMoreThan18()
        {
            return  (Age >= 18);
        }

        public bool ConfirmGender(GenderType gender)
        {
            if (_gender == gender)
                return true;
            return false;
        }

        public override string ToString()
        {
            return "Name: " + _name + "\n Age: " + _age + "\n Dni: " + _dni + "\n Gender: " + _gender + "\n Weight: " + _weigth + "\n Height: " + _height;
        }

        public static string GenerateDNI()
        {
            int dniNumb = Utils.RandomRangeInt(0, 99999999);
            char letter = GetDNILetter(dniNumb);

            string result = dniNumb.ToString() + letter;
            return result;
        }

        private static char GetDNILetter(int letter)
        {
            while (letter > 26)
            {
                letter = letter / 26;
            }
            return (char)(letter + 65);
        }

    }

}
