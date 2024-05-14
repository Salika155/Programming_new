using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimera3RA
{
    public enum AsignaturasType
    {
        MATEMATICAS,
        LENGUAJE,
        HISTORIA,
        CIENCIA,
        DESC
    }

    public class Notes
    {
        private double _math;
        private double _science;
        private double _history;
        private double _language;

        private readonly List<double> signatures = new List<double>();

        public Notes()
        {

        }

        public double Math
        {
            get => _math;
            set => _math = value;
        }

        public double Science
        {
            get => _science;
            set => _science = value;
        }

        public double History
        {
            get => _history;
            set => _history = value;
        }

        public double Language
        {
            get => _language;
            set => _language = value;
        }

        public double GetQualificationForSignature(AsignaturasType asignatura)
        {
            if (asignatura == AsignaturasType.CIENCIA)
                return Science;
            if (asignatura == AsignaturasType.HISTORIA)
                return History;
            if (asignatura == AsignaturasType.LENGUAJE)
                return Language;
            if (asignatura == AsignaturasType.MATEMATICAS)
                return Math;
            return -1;
        }

        public void SetQualificationForAsignature(AsignaturasType asignatura, double value)
        {
            if (asignatura == AsignaturasType.CIENCIA)
                Science = value;
            if (asignatura == AsignaturasType.HISTORIA)
                History = value;
            if (asignatura == AsignaturasType.LENGUAJE)
                Language = value;
            if (asignatura == AsignaturasType.MATEMATICAS)
                Math = value;
        }

        public double GetAverage()
        {
            return (_math + _science + _language + _history) / GetSignatureCount();
        }

        public int GetSignatureCount()
        {
            return signatures.Count;
        }

        public double GetMajorQualification()
        {
            double majorqualif = _math;

            if (_history >= majorqualif)
                majorqualif = _history;
            if (_language >= majorqualif)
                majorqualif = _language;
            if (_science >= majorqualif)
                majorqualif = _science;
            if (_math >= majorqualif)
                majorqualif = _math;
            return majorqualif;
        }

        public double GetMinorQualification()
        {
            double minorqualif = _math;

            if (_history >= minorqualif)
                minorqualif = _history;
            if (_language >= minorqualif)
                minorqualif = _language;
            if (_science >= minorqualif)
                minorqualif = _science;
            if (_math >= minorqualif)
                minorqualif = _math;
            return minorqualif;
        }
    

        public AsignaturasType GetMajorQualificationSignature()
        {
            double majornote = GetMajorQualification();

            if (_math == majornote)
                return AsignaturasType.MATEMATICAS;
            if (_science == majornote)
                return AsignaturasType.CIENCIA;
            if (_language == majornote)
                return AsignaturasType.LENGUAJE;
            return AsignaturasType.HISTORIA;
        }

        public AsignaturasType GetMinorQualificationSignature()
        {
            double majornote = GetMinorQualification();

            if (_math == majornote)
                return AsignaturasType.MATEMATICAS;
            if (_science == majornote)
                return AsignaturasType.CIENCIA;
            if (_language == majornote)
                return AsignaturasType.LENGUAJE;
            return AsignaturasType.HISTORIA;
        }

        public Notes Clone()
        {
            Notes notes = new Notes();

            notes._math = Math;
            notes._history = History;
            notes._language = Language;
            notes._science = Science;

            return notes;
        }
    }
}
