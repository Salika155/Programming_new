﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Detecta_Copias
{
    internal class DirectoryManager
    {
        public string[] GetFiles(string directoryPath, string searchPattern = "*.*", SearchOption searchOption = SearchOption.AllDirectories)
        {
            return Directory.GetFiles(directoryPath, searchPattern, searchOption);
        }

        public bool DirectoryExists(string directoryPath)
        {
            return Directory.Exists(directoryPath);
        }

        public void CreateDirectory(string directoryPath)
        {
            Directory.CreateDirectory(directoryPath);
        }


    }
}
