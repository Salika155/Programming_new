﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasBiblio
{
    /// <summary>
    /// Clase para definir las bombas que tendra el tablero en el juego.
    /// </summary>
    public class Bombs
    {
        public Position position;
      
       
        public Bombs(Position position)
        {
            this.position = position;
            
        }

        public Position Position { get; }
    }
}