using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        private string _pathOut = string.Empty;
        private List<string> _directories = new List<string>();
        private List<FileUser> _files = new List<FileUser>();
        private List<FileUser> _duplicates = new List<FileUser>();
        private bool _isCopy = false;
        private bool _isSuccess = false;

        public bool IsSetPathOut => !string.IsNullOrEmpty(_pathOut);
        public bool HasDirectories => _directories.Count > 0;
        public bool HasFiles => _files.Count > 0;
        public bool ExportDuplicates { get; set; }
        public bool ControlOutputContain { get; set; }

        public void AddDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                _directories.Add(path);
            }
        }

        public void SetPathOut(string path)
        {
            if (Directory.Exists(path))
            {
                string newPath = Path.Combine(path, "newFileCombined");
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                _pathOut = newPath;
            }
        }

        public void ListFiles()
        {
            foreach (string directory in _directories)
            {
                string[] allfiles = Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories);
                foreach (string file in allfiles)
                {
                    FileUser fileUser = new FileUser(file)
                    {
                        Path = file,
                        Hash = FileGestor.GetHashFromFile(file),
                        Size = new FileInfo(file).Length,
                    };
                    _files.Add(fileUser);
                }
            }
        }

        public void CompareFiles()
        {
            for (int i = 0; i < _files.Count; i++)
            {
                if (_files[i].Disabled)
                    continue;
                for (int j = i + 1; j < _files.Count; j++)
                {
                    var file1 = _files[i];
                    var file2 = _files[j];
                    if (file2.Disabled)
                        continue;
                    if (file1.Hash == file2.Hash && file1.Size == file2.Size)
                    {
                        file2.Disabled = true;
                        _duplicates.Add(file2);

                    }
                }
            }
        }



    }
}
