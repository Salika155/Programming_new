using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oca
{
    internal class Board
    {
        public const int SquaresTotal = 63;

        private Dictionary<int, int> specialSquares = new Dictionary<int, int>
        {
        { 1, 5 },   // De oca a oca y tiro porque me toca
        { 9, 14 },  // De oca a oca y tiro porque me toca
        { 18, 23 }, // De oca a oca y tiro porque me toca
        { 27, 32 }, // De oca a oca y tiro porque me toca
        { 36, 41 }, // De oca a oca y tiro porque me toca
        { 45, 50 }, // De oca a oca y tiro porque me toca
        { 54, 63 }, // De oca a oca y tiro porque me toca
        { 6, 12 },  // De puente a puente y tiro porque me da la corriente
        { 12, 6 },  // De puente a puente y tiro porque me da la corriente
        { 26, 53 }, // De dado a dado y tiro porque me ha tocado
        { 53, 26 }, // De dado a dado y tiro porque me ha tocado
        { 19, 0 },  // La posada
        { 31, 0 },  // El pozo
        { 43, 0 },  // El laberinto
        { 52, 0 },  // La cárcel
        { 58, 0 }   // La muerte
        };

        public int GetNextSquare(int currentSquare)
        {
            if (specialSquares.ContainsKey(currentSquare))
            {
                return specialSquares[currentSquare];
            }
            else
                return currentSquare;
        }
    }
}
