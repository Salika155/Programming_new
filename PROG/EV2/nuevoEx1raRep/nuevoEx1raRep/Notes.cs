using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevoEx1raRep
{
   
    public class Notes
    {
        private List<Note> noteList = new List<Note>();

        private double _math;
        private double _literature;
        private double _english;
        private double _history;
        private double _science;
        private double _notesCount;


        public Notes() 
        {
            for (int i = 0; i < (int)AsignatureType.Count - 1; i++)
            {
                Note note = new((AsignatureType)i);
                noteList.Add(note);
            }
        }

        public Notes(Notes notes)
        {
            for (int i = 0; i < notes.Count; i++)
            {
                noteList.Add(notes.noteList[i]);
            }

        }

        public bool IsValid(int index)
        {
            return index >= 0 && index < noteList.Count;
        }

        public double Count
        {
            get => _notesCount;
            set { _notesCount = value; }
        }

        public double Math
        {
            get => _math;
            set => _math = value;
        }

        public double Literature
        {
            get => _literature;
            set => _literature = value;
        }

        public double English
        {
            get => _english;
            set => _english = value;
        }

        public double History
        {
            get => _history;
            set => _history = value;
        }

        public double Science
        {
            get => _science;
            set => _science = value;
        }

        public Notes Clone()
        {
            Notes notes = new Notes();

            notes.Math = _math;
            notes.Literature = _literature;
            notes.English = _english;
            notes.History = _history;
            notes.Science = _science;

            return notes;
        }

        public Note? GetNoteAt(int index)
        {
            if (IsValid(index))
                return noteList[index];
            return null;
        }

        public Note? GetNoteByAsignature(AsignatureType asignature)
        {
            foreach (var note in noteList)
            {
                if (note.Asignature == asignature)
                    return note;
            }
            return null;
        }

        public double GetMarkWithAsignature(AsignatureType asignature)
        {
            Note? note = GetNoteByAsignature(asignature);
            if (note != null)
                return note.Value;
            return 0;
        }

        public void SetMarkWithAsignature(AsignatureType asignature, double mark)
        {
            Note? note = GetNoteByAsignature(asignature);
            if (note != null)
                note.Value = mark;
        }

        public double GetMayorMark()
        {
            double mayor = 0;
            foreach (var note in noteList)
            {
                if (note.Value > mayor)
                    mayor = note.Value;
            }
            return mayor;
        }

        public double GetNoteWithHigherQualification()
        {
            double mayor = 0;
            foreach (var note in noteList)
            {
                if (note.Value > mayor)
                    mayor = note.Value;
            }
            return mayor;
        }

        public double GetNoteWithLowerQualification()
        {
            double menor = 10;
            foreach (var note in noteList)
            {
                if (note.Value < menor)
                    menor = note.Value;
            }
            return menor;
        }






        //public static double GetQualificationForSignature(Notes notes, string subject)
        //{
            
        //}
        //public static void SetQualificationForSignature(Notes notes, string subject, double qualification)
        //{
            
        //}

        //public static double GetAverageAll(Notes notes)
        //{
            
        //}

        //public static double GetSignatureWithHigherQualification(Notes notes)
        //{
            
        //}

        //public static double GetSignatureWithLowerQualification(Notes notes)
        //{
            
        //}

        //public static double GetHigherMark(Notes notes)
        //{
            
        //}

        //public static double GetLowerMark(Notes notes)
        //{
            
        //}


    }
}
