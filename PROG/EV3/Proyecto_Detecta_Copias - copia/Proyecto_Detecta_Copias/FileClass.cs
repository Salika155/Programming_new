using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Detecta_Copias
{
    public class FileClass
    {
        private string _ruta;
        private string _name;
        private bool _isDuplicate;

        public string Ruta { get => _ruta;}
        public string Name { get => _name;}
        public bool IsDuplicate { get => _isDuplicate; }

        public FileClass(string ruta)
        {
            _ruta = ruta;
            _name = System.IO.Path.GetFileName(ruta);
            
        }
    }
}
