using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasBiblio
{
    /// <summary>
    /// Clase para definir las bombas que tendra el tablero en el juego.
    /// </summary>
    // Javi: Mal nombre de la clase: Las clases, salvo algunas excepciones, se hacen siempre en singular
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
