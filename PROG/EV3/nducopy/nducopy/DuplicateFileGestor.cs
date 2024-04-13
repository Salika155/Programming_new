﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nducopy
{
    public class DuplicateFileGestor
    {
        //HACER FUNCION CON BUCLE, RECORRER UN STREAM Y ALMACENAR EN UN ARRAY DE BYTES
        //PARA COMPARAR CON OTRO ARCHIVO PRIMERO SE COMPARAN LOS HASHES. SI COINCIDEN,
        //SE COMPARA EL CONTENIDO DE LOS ARCHIVOS MEDIANTE EL ARRAY DE BYTES
        //EL HASH SE CALCULA CON SHA256
        //LUEGO SE DEBERIA COMPARAR EL TAMAÑO DEL FICHERO
        //SE UTILIZARIA UN HASH TIPO ENTERO EXTRAIDO DEL FICHERO COMO PASO PREVIO A LA COMPARACION
        //DE HASH.
        //PARA LA ESTRUCTURA DE CARPETAS DENTRO DE OTRAS CARPETAS DE ORIGEN A LA CARPETA DE DESTINO
        //SE PUEDE GENERAR EL HASH DE MANERA SECUENCIAL SIN NECESIDAD DE TENER TODO EL FICHERO EN
        //MEMORIA RAM. 
        //SI EL FICHERO NO TIENE FORMATO DE FECHA, Y ES TIPO DE VIDEO O IMAGEN, INTENTAR PONERLE COMO
        //NOMBRE DE FICHERO ALGO QUE INDIQUE LA FECHA DE CREACION DEL FICHERO.
        //FUNCION PARA COMPARAR DOS FICHEROS QUE NO NECESITEN QUE EL CONTENIDO ENTERO DEL FICHERO
        //ESTE EN MEMORIA RAM.
        private string _pathOut = "";
        private List<string> _directories = new List<string>();
        private List<FileUser> _files = new List<FileUser>();
        private List<FileUser> _duplicates = new List<FileUser>();
        private bool _isCopy = false;
        private bool _isSuccess = false;

        public bool HasDirectories => _directories.Count > 0;
        public bool HasFiles => _files.Count > 0;
    }
}
