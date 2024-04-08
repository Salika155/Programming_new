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
        private AsignatureType i;

        public AsignatureType Asignature
        {
            get => _asignature;
            set => _asignature = value;
        }

        public double Value
        {
            get => _value;
            set => _value = value;
        }

        public Note()
        {
        }

        public Note (AsignatureType asignature, double value)
        {
            _asignature = asignature;
            _value = value;
        }

        public Note(AsignatureType i)
        {
            this.i = i;
        }
    }
}
