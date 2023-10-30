using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DominoPieces
{
    internal class DominoDeck
    {

        private List <DominoPiece> _piece = new List<DominoPiece>();

        public DominoDeck()
        {

        }
        

        //+ExtractPiece():DominoPiece

        public DominoPiece? ExtractPiece(int index)
        {
            if (index < 0 || index >= GetPieceCount())
                return null;

            var p = _piece[index];
            _piece.RemoveAt(index);
            return p;
        }

        //+ExtractPiece(index:int):DominoPiece
        public DominoPiece? ExtractPiece()
        {
            if (_piece.Count == 0)
                return null;

            int random = Utils.GetRandom(0, _piece.Count - 1);
            return ExtractPiece(random);
        }

        //+GetPieceCount():int
        public int GetPieceCount()
        {
            if (_piece != null)
                return _piece.Count;
            return -1;
        }

        //+AddPiece(piece.DominoPiece)
        public void AddPìece(DominoPiece piece)
        {
            if (ContainsPiece(piece) == false)
                _piece.Add(piece);
        }

        public DominoPiece? GetPieceAt(int index)
        {
            if (index >= 0 && index < _piece.Count)
            {
                return _piece[index];
            }
            else
                return null;

        }

        public bool ContainsPiece(DominoPiece piece)
        {
            if (piece == null || piece.GetTtotalValue() == 0)
                return false;

            for (int i = 0; i < GetPieceCount(); i++)
            {
                if (GetPieceAt(i).IsEqual(piece));
                        return true;
            }   
            return false;
        }

        public void Shuffle(List<DominoPiece> pieces)
        {
            DominoDeck deck = new DominoDeck();
            Random random = new Random();
            int n = _piece.Count;

            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                DominoPiece temp = _piece[i];
                _piece[i] = _piece[j];
                _piece[j] = temp;
            }
        }

        public int GetPieceIndex(DominoPiece piece)
        {
            return -1;
        }





    }


   



    
}
