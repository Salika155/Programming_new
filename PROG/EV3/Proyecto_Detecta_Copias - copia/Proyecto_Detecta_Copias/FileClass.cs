using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Detecta_Copias
{
    public class FileClass
    {
        public string Ruta { get; set; }
        public string Name { get; set; }
        public bool IsDuplicate { get; set; }

        public FileClass(string ruta)
        {
            Ruta = ruta;
            Name = System.IO.Path.GetFileName(ruta);
            IsDuplicate = false;
        }



    }
}
