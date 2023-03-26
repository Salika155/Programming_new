using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BuscaminasBiblio
{
     public interface IBoard
     {
        //Anotaciones para mi: al ser una interfaz que implementa los metodos en otra clase, se cierran sin cuerpo ya que estas se implementaran en otro lugar.
        int GetWidth();

        int GetHeight();

        void CreateBoard(int width, int height);

        void Init(int x, int y, int bombCount);

        bool IsBombAt(int x, int y);

        int GetBombProximity(int x, int y);

        void PutFlagAt(int x, int y);

        bool IsFlagAt(int x, int y);

        void DeleteFlagAt(int x, int y);

        bool IsOpen(int x, int y);

        bool OpenCell(int x, int y);

        bool HasWin(int x, int y);

        
     }
}
