using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad
{
    public class Comunidad
    {
        private List<Vivienda> _viviendas;
        private string _calle;
        private int _numero;
        private string _codigoPostal;
        private string _ciudad;

        public Comunidad()
        {
            _viviendas = new List<Vivienda>();
        }

        public int NumeroDeViviendas
        {
            get { return _viviendas.Count; }
        }

        public int NumeroDePersonas
        {
            get
            {
                int totalPersonas = 0;
                foreach (Vivienda vivienda in _viviendas)
                {
                    totalPersonas += vivienda.NumeroDePersonas;
                }
                return totalPersonas;
            }
        }

        public string Calle { get { return _calle; } set { _calle = value; } }
        public int Numero { get { return _numero; } set { _numero = value; } }
        public string CodigoPostal { get { return _codigoPostal; } set { _codigoPostal = value; } }
        public string Ciudad { get { return _ciudad; } set { _ciudad = value; } }

        public void AñadirVivienda(Vivienda vivienda)
        {
            _viviendas.Add(vivienda);
        }

        public void BorrarVivienda(string piso, string letra)
        {
            _viviendas.Clear();
            Vivienda viviendaABorrar = null;
            foreach (Vivienda vivienda in _viviendas)
            {
                //if (vivienda._Piso == piso && vivienda.Letra == letra)
                {
                    viviendaABorrar = vivienda;
                    break;
                }
            }
            if (viviendaABorrar != null)
            {
                _viviendas.Remove(viviendaABorrar);
            }
        }

        public bool ContienePersonaConNombre(string nombre)
        {
            foreach (Vivienda vivienda in _viviendas)
            {
                if (vivienda.ContienePersonaConNombre(nombre))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ContienePersonaConCorreo(string correo)
        {
            foreach (Vivienda vivienda in _viviendas)
            {
                if (vivienda.ContienePersonaConCorreo(correo))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ContienePersonaConTelefono(string telefono)
        {
            foreach (Vivienda vivienda in _viviendas)
            {
                if (vivienda.ContienePersonaConTelefono(telefono))
                {
                    return true;
                }
            }
            return false;
        }

        public bool TieneViviendaVacias()
        {
            foreach (Vivienda vivienda in _viviendas)
            {
                //if (vivienda.Personas.Count == 0)
                    return true;
            }
            return false;
        }

        public List<Vivienda> ViviendasVacias()
        {
            List<Vivienda> viviendasVacias = new List<Vivienda>();
            foreach (Vivienda vivienda in _viviendas)
            {
                //if (vivienda.Personas.Count == 0)
                    viviendasVacias.Add(vivienda);
            }
            return viviendasVacias;
        }

        public void Clear()
        {
            _viviendas.Clear();
        }
    }


}




