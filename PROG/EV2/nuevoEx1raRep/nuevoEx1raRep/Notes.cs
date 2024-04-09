using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevoEx1raRep
{
   
    public class Notes
    {
        private readonly List<Note> noteList = new List<Note>();

        private double _math;
        private double _literature;
        private double _english;
        private double _history;
        private double _science;
        private double _notesCount;


        public Notes() 
        {
            for (int i = 0; i < (int)AsignatureType.Count; i++)
            {
                Note note = new((AsignatureType)i);
                noteList.Add(note);
            }
        }

        public Notes(Notes notes)
        {
            for (int i = 0; i < notes.Count; i++)
            {
                noteList.Add(GetNoteAt(i));
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
            //return new Notes(this);
        }

        public Note? GetNoteAt(int index)
        {
            if (IsValid(index))
                return noteList[index];
            return null;
        }

        public Note? GetNoteByAsignature(AsignatureType asignature)
        {
            for (int i = 0; i < noteList.Count; i++)
            {
                if (noteList[i].GetAsignature() == asignature)
                    return noteList[i];
            }
            return null;
        }

        public double GetMarkWithAsignature(AsignatureType asignature)
        {
           for (int i = 0; i < noteList.Count; i++)
            {
                if (noteList[i].GetAsignature() == asignature)
                    return noteList[i].GetValue();
            }
            return -1;
        }

        public void SetMarkWithAsignature(AsignatureType asignature, double mark)
        {
            for (int i = 0; i < noteList.Count; i++)
            {
                if (noteList[i].GetAsignature() == asignature)
                    noteList[i].SetValue(mark);
            }
        }

        public double GetMayorMark()
        {
            int count = 0;
            double mayor = 0;
            for (int i = 0; i < noteList.Count;i++) 
            {
                mayor += noteList[i].GetValue();
                count++;
            }
            return mayor / count;
        }

        public Note GetNoteWithHigherQualification()
        {
           var note = noteList[0];
            for (int i = 0; i < noteList.Count; i++)
            {
                if (noteList[i].GetValue() > note.GetValue())
                    note = noteList[i];
            }
            return note;
        }

        public Note GetNoteWithLowerQualification()
        {
            var note = noteList[0];
            for (int i = 0; i < noteList.Count; i++)
            {
                if (noteList[i].GetValue() < note.GetValue())
                    note = noteList[i];
            }
            return note;
        }

        public AsignatureType GetAsignatureWithHigherMark()
        {
            return GetNoteWithHigherQualification().GetAsignature();
        }

        public AsignatureType GetAsignatureWithLowerMark()
        {
            return GetNoteWithLowerQualification().GetAsignature();
        }

        public double GetHigherMark()
        {
            return GetNoteWithHigherQualification().GetValue();
        }

        public double GetLowerMark()
        {
            return GetNoteWithLowerQualification().GetValue();
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
