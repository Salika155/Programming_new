using System;
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
    
    public class Cell
    {
        public Position position;
        
        public bool Isopen { get; set; }
        public bool Isbomb { get; set; }
        public bool Isflag { get; set; }
        public int NeightborBombs { get; set; }

        public Cell(bool Open, Position position)
        {
            this.position = position;
            Isopen = Open;  
        }

        public Cell() 
        {
            Isbomb = false;
            Isflag = false;
            NeightborBombs = 0;
            Isopen= false;
        }

        public Position Position { get; }
        
        public void IsOpen()
        {
            Isopen = true;
        }

        public bool IsBomb()
        {
            return Isbomb;
        }
        public bool IsFlag()
        {
            return Isflag;
        }

        public void SetBomb()
        {
            Isbomb = true;
        }

        public void SetFlag() 
        {
            Isflag = true;
        }
    }
}
