using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasBiblio
{
    /// <summary>
    /// Clase para definir las banderas en el tablero
    /// </summary>
    public class Flag
    {
        public Position  position;
        // Javi: No veo sentido para estos atributos
        public bool PutFlag;
        public bool QuitFlag;
        private int x;
        private int y;

        public Flag(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Flag(bool put, bool quit)
        {
            PutFlag = put;
            QuitFlag = quit;
        }

        public Flag()
        {

        }

        public Position Position { get; }

       
    }
}
