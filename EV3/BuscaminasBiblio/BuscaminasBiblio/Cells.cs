﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasBiblio
{
    /// <summary>
    /// Clase para generar celdas, las cuales forman parte del tablero y tienen una posicion en este
    /// ademas de dos estados: abierto/cerrado
    /// </summary>
    // Javi: Los nombres deben ir en singular
    public class Cells
    {
        
        public Position position;
        // Javi: No hace falta llevar dos booleanos en danza, con uno de ellos es suficiente
        public bool Isopen;
        public bool Isclose;

        public Cells(bool Open, bool Close, int x, int y)
        {
            Position = new Position(x, y);
            Isopen = Open;
            Isclose = Close;
        }

        public Position Position { get; }
        
        public void IsOpen()
        {
            Isopen = true;
            Isclose = false;
        }

        public void IsClose()
        {
            Isopen = false;
            Isclose = true;
        }

        public void IsBomb()
        {

        }
        public void IsFlag()
        {

        }
    }
}
