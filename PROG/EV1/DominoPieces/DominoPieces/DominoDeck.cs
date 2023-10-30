using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoPieces
{
    internal class DominoDeck
    {
        DominoPiece _piece = new DominoPiece();

        //+ExtractPiece(index:int):DominoPiece
        public DominoPiece ExtractPiece(int index)
        {
            int random = Utils.GetRandom(0, _piece.Count - 1)
                return ExtractPiece(random);
        }

        //+ExtractPiece():DominoPiece

        public DominoPiece ExtractPiece(int index)
        {
            if (index < 0 || index >= GetPieceCount())
                return null;

            var p = _piece[index];
            _piece.RemoveAt(index);
            return p;
        }



        //+GetPieceCount():int
        public int GetPieceCount()
        {
            if ()

        }



        //+AddPiece(piece.DominoPiece)
        public void AddPìece(DominoPiece piece)
        {
            if (ContainsPiece(piece) == false)
                return

        }

        public bool ContainsPiece(DominoPiece piece)
        {
            if (piece == null)
                return false;
            for (int i = 0; i < GetPieceCount(); i++)
            {
                if (GetPieceAt(i)).IsEqual(piece))
                        return true;
            }
        }


        //+Shuffle()



    }
}
