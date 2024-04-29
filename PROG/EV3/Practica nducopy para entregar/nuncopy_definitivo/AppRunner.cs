﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace nuncopy_definitivo
{
    public class AppRunner
    {
        #region Intento de implementar JSON
        //public static void RunApp(string[] inputDirectories)
        //{
        //    // Ruta del archivo JSON
        //    string jsonFilePath = "C:\\Users\\carre\\Desktop\\carpeta_origen\\json.json"; // Cambiar por la ruta de tu archivo JSON
        //    // Leer el contenido del archivo JSON
        //    string jsonContent = File.ReadAllText(jsonFilePath);

        //    // Verificar si el archivo existe
        //    if (File.Exists(jsonFilePath))
        //    {
        //        try
        //        {
        //            // Deserializar el JSON a un objeto
        //            JsonFile inputOutputDirectories = JsonSerializer.Deserialize<JsonFile>(jsonContent);

        //            // Establecer los directorios en el FileUnifier
        //            FileUnifier fileUnifier = new FileUnifier();
        //            ArgumentManager.SetDirectories(fileUnifier, inputOutputDirectories.inputDirectories, inputOutputDirectories.outputDirectory);

        //            // Llamar a los métodos de la clase FileUnifier
        //            if (fileUnifier.HasDirectories && fileUnifier.IsOutputPathSet)
        //            {
        //                fileUnifier.ListFiles();
        //                fileUnifier.CompareFiles();
        //                fileUnifier.CopyFiles();
        //                if (fileUnifier.HasDuplicades)
        //                {
        //                    fileUnifier.ExportDuplicates = false;
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Error al procesar el archivo JSON: {ex.Message}");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("El archivo JSON no existe.");
        //    }
        //}
        #endregion

        public static void RunApp(string[] args)
        {
            string jsonFilePath = ".json";
            FileUnifier fileUnifier = new FileUnifier();

            // No consegui pasarle el json como argumento, asi que los sigo pasando por aqui
            string[] inputDirectories = new string[] { "C:\\Users\\carre\\Desktop\\Brandon Sanderson", "C:\\Users\\carre\\Desktop\\carpeta_origen",
            "C:\\Users\\carre\\Desktop\\carpeta_destino" };

            string outputDirectory = args[inputDirectories.Length - 1];

            ArgumentManager.SetDirectories(fileUnifier, inputDirectories, outputDirectory);

            if (fileUnifier.HasDirectories && fileUnifier.IsOutputPathSet)
            {
                fileUnifier.ListFiles();
                fileUnifier.CompareFiles();
                fileUnifier.CopyFiles();
                if (fileUnifier.HasDuplicades)
                {
                    fileUnifier.ExportDuplicates = false;
                }
                else
                {
                    Console.WriteLine("No hay archivos duplicados.");
                }
            }

            #region Explicacion del funcionamiento de la app
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

            //Con esto se obtienen los archivos de los directorios
            //var files = Directory.GetDirectories(inputDirectories[0], "*.*", SearchOption.AllDirectories);
            //var files = Directory.GetFiles(inputDirectories[0], "*.*", SearchOption.AllDirectories);

            #endregion
        }
    }
}