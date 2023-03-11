using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Comunidad
{

    public enum Gender
        {
        Male,
        Female,
        Other
        }

    class Persona
    {
        private string _Name;
        private int _Age;
        private Gender _Gender;
        private string _Mail;
        private string _Phone;

        //Propiedades

        public string Name { get { return _Name; } }

        public int Age { get { return _Age;} }

        public Gender Gender { get { return _Gender;} }


        private bool CheckMail(string mail)
        {
            return IsMail(mail);
        }

        private bool CheckPhone(string phone)
        {
            return IsPhone(phone);
        }

        private string Mail { get { return _Mail; }
            set
            {
                bool correoValido = CheckFailsMails.IsMail(value);
                if (correoValido)
                    _Mail = value;
            }
        }

        private string Phone
        {
            get { return _Phone; }
            set
            {
                bool telefonoValido = CheckFailsPhones.IsPhone(value);
                if (telefonoValido)
                    _Phone = value;
            }
        }

        //constructores
        public Persona() { }

        public Persona(string nombre, int edad)
        {
            this._Name = nombre;
            this._Age = edad;
        }

        public string ToString()
        {
            return JsonSerializer.Serialize(Name + "-" + Age + "-" + Gender + "-" + Mail + "-" + Phone + "-");
        }



        public Persona Clone()
        {
            return new Persona()
            {
                _Name = this.Name,
                _Age = this.Age,
                _Gender = this.Gender,
                _Mail = this.Mail,
                _Phone = this.Phone
            };
        }

        //validaciones mail
        public static bool IsMail(string mail)
        {
            
            if (CheckFailsMails.GetNumberOf(mail) != 1)
                return false;
            if (CheckFailsMails.ContTwoDots(mail))
                return false;
            if (CheckFailsMails.ContNotValid(mail) == 0)
                return false;
            if (CheckFailsMails.SeePointAfterArroba(mail) == 0)
                return false;
            if (mail[0] == '@' || mail[0] == '.')
                return false;
            if (mail[mail.Length - 1] == '@' || mail[mail.Length - 1] == '.')
                return false;
            return true;
        }


        public class CheckFailsMails
        {
            public static int GetNumberOf(string mail) // Checkea que no haya más de dos @.
            {
                int length = mail.Length;
                int num = 0;
                for (int i = 0; i < length; i++)
                {
                    char c = mail[i];
                    if (c == '@')
                        num++;
                }
                return num;
            }

            public static bool ContTwoDots(string mail) // Checkea que no hayan dos puntos seguidos.
            {
                int length = mail.Length;
                for (int i = 1; i < length; i++)
                {
                    char c = mail[i];
                    if (c == '.' && (c - 1) == '.')
                        return true;
                }
                return false;
            }
            public static int ContNotValid(string mail) // Checkea que no haya un caracter especial.
            {
                int length = mail.Length;
                int num = 0;
                for (int i = 0; i < length; i++)
                {
                    char c = mail[i];
                    if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z' || c >= '0' && c <= '9' || c == '@' || c == '.')
                        num++;
                    if (num == length)
                        return 1;
                }
                return 0;
            }
            public static int SeePointAfterArroba(string mail) // Checkea si hay punto despues del @.
            {
                int length = mail.Length;
                int num = 0;
                int arroba = 0;
                int dot = 0;
                for (int i = 0; i < length; i++)
                {
                    char c = mail[i];
                    if (c == '@')
                    {
                        num++;
                        arroba = i;
                    }
                    if (num == 1)
                    {
                        if (c == '.')
                            dot = i;
                    }
                }
                if ((dot - arroba) == 1)
                    return 0;
                if (dot == 0)
                    return 0;
                return 1;
            }

            internal static bool IsMail(string value)
            {
                throw new NotImplementedException();
            }
        }

        //validaciones phone

        public static bool IsPhone(string phone)
        {

            if (CheckFailsPhones.GetPhoneLength(phone) != true)
                return false;
            //if (CheckFailsPhones.GetPhoneCharacters(phone) != true)
                return true;
            return false;
        }

        public class CheckFailsPhones
        {
            public static bool GetPhoneLength(string phone)
            {
                // Verifica que la longitud sea correcta.
                return phone.Length == 9;
            }

            public static int GetPhoneCharacters(string phone)
            {
                // Verifica que todos los caracteres sean dígitos.
                int length = phone.Length;
                int num = 0;
                for (int i = 0; i < length; i++)
                {
                    char c = phone[i];
                    if (c >= '0' && c <= '9')
                        num++;
                    if (num == length)
                        return 1;
                }
                return 0;
            }

            internal static bool IsPhone(string value)
            {
                throw new NotImplementedException();
            }
        }
    }
}
