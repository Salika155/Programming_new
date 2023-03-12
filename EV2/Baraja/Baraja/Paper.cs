using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Baraja;

namespace Baraja
{

    public enum CardType
    {
        Oros,
        Espadas,
        Bastos,
        Copas
    }
        //enum con palos
    class Carta
    {
        //Atributos privados
        private int _numero;
        private CardType _type; 

        //Properties
        public int Numero => _numero; 
        public CardType Type => _type; 

        //Constructores
        public Carta(CardType type)
        {
            // Javi: Esta linea no tiene sentido
            CardType carta = CardType.Oros;
        }


        public Carta(int numero, CardType palo)
        {
            this._numero = Numero;
            this._type = Type;
        }
    }
}
    
