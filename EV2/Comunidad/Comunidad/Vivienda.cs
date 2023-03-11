using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad
{
    public class Vivienda
    {
        private List<Persona> personas;
        private int piso;
        private char letra;


        public int NumeroDePersonas
        {
            get { return personas.Count; }
        }

        public int _Piso
        {
            get { return piso; }
            set { piso = value; }
        }

        public char Letra
        {
            get { return letra; }
            set { letra = value; }
        }

        public Vivienda()
        {
            personas = new List<Persona>();
        }

        //rehacer
        public void AddPersona(Persona persona)
        {
            //if (!personas.Any(p => p.Mail == persona.Mail || p.Phone == persona.Phone))
            {
                personas.Add(persona);
            }
        }


        public void DeletePersonaByName(string name)
        {
            personas.RemoveAll(persona => persona.Name == name);
        }

        public void BorrarPersonaPorCorreo(string correo)
        {
            personas.RemoveAll(persona => persona.Mail == correo);
        }

        public bool ContienePersonaConNombre(string nombre)
        {
            return personas.Any(persona => persona.Name == nombre);
        }

        public bool ContienePersonaConCorreo(string correo)
        {
            return personas.Any(persona => persona.Mail == correo);
        }

        public bool ContienePersonaConTelefono(string telefono)
        {
            return personas.Any(persona => persona.telefono == telefono);
        }

        public void Clear()
        {
            personas.Clear();
        }
    }
}

