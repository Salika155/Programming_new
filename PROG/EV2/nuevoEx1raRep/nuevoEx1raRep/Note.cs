using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevoEx1raRep
{
    public enum AsignatureType
    {
        Math, Literature, English, History, Science, Count
    }
    public class Note
    {
        private AsignatureType _asignature;
        private double _value;

        public Note(AsignatureType asignature)
        {
            _asignature = asignature;
        }

        public AsignatureType GetAsignature()
        {
            return _asignature;
        }

        public double GetValue()
        {
            return _value;
        }  
        
        public void SetValue(double value)
        {
            if (IsValid(value))
            _value = value;
        }

        public bool IsValid(double value)
        {
           return value >= 0 && value <= 10;
        }
    }
}
