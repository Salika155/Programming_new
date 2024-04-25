using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuncopy_definitivo
{
    public class AppRunner
    {
        FileUnifier fileUnifier = new FileUnifier();

        public static void RunApp(string[] args)
        {
            throw new NotImplementedException();
            //pasarle el path con el directorio de los archivos a comparar, incluyendo subdirectorios
            //pasarle el path con el directorio de salida

            //abrir los archivos y obtener el hash de cada uno

            //empezar a comparar los archivos mediante el hash
            //si el hash es igual, comparar por tamaño de archivo
            //si el tamaño de archivo es igual, comparar por contenido
            //el contenido se compara línea por línea mediante arrays de bytes de cada línea
            //si el contenido es igual y cumple todo lo anterior, se marca como duplicado
            //si el archivo no es duplicado, se copia al directorio de salida

            //en el directorio de salida, creara los subdirectorios necesarios para mantener la estructura de los archivos
            //crea una copia de los archivos no duplicados en el directorio de salida
        }
    }
}
