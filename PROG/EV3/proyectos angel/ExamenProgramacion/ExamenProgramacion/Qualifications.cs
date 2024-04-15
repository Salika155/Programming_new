namespace ExamenProgramacion
{
    public enum Signatures
    {
        MATHS = 0,
        SCIENCE = 1,
        LANGUAGE = 2,
        HISTORY = 3,
        LAST = 4,
    }

    public class Qualifications
    {
        List<double> _marks = new();


        public Qualifications()
        {
            for (int i = 0; i < GetSignaturesCount(); i++)
                _marks.Add(0);
        }
        public Qualifications(bool deafault_all_marks_10) //Esto esta hecho solo para pruebas
        {
            for (int i = 0; i < GetSignaturesCount(); i++)
                _marks.Add(10);
        }
        public Qualifications(double math, double science, double language, double history)
        {
            _marks.Add(math);
            _marks.Add(science);
            _marks.Add(language);
            _marks.Add(history);
            if (GetSignaturesCount() - 4 > 1)
            {
                for (int i = 0; i < GetSignaturesCount() - 4; i++)
                    _marks.Add(0);
            }
        }
        public static int GetSignaturesCount() //Esto es un intento de hacer que de igual el número de asignaturas poniendo en el enum un valor last, para así que en todas las funciones se tome como referencia a la hora de recorrer la lista.
        {
            return (int)Signatures.LAST;
        }
        public void SetQualification(Signatures sg, double mark)
        {
            if (sg == Signatures.LAST)
                return;
            if (mark > 0 && mark <= 10)
            {
                for (int i = 0; i < GetSignaturesCount(); i++)
                {
                    _marks[i] = mark;
                }
            }
        }
        public double GetQualificationForSignature(Signatures sg)
        {
            if (sg == Signatures.LAST)
                return int.MinValue;

            return _marks[(int)sg];
        }
        public double GetQualificationAverage()
        {
            double aux = 0;
            for (int i = 0; i < GetSignaturesCount(); i++)
                aux += _marks[i];

            return aux/GetSignaturesCount();
        }
        public Signatures GetHightMarkSignature()
        {
            double hight = 0;
            int hight_index = 4;
            for (int i = 0; i < GetSignaturesCount(); i++)
            {
                if (_marks[i] > hight)
                {
                    hight = _marks[i];
                    hight_index = i;
                }
            }
            return (Signatures)hight_index;
        }
        public Signatures GetLowestMarkSignature()
        {
            double min = 20; //Estaba pensando en poner el maxValue pero como en el constructor se comprueba que no puede ser más de 10, con esto debe bastar
            int lowest_index = 4;
            for (int i = 0; i < GetSignaturesCount(); i++)
            {
                if (_marks[i] < min)
                {
                    min = _marks[i];
                    lowest_index = i;
                }
            }
            return (Signatures)lowest_index;
        }
        public double GetHightMark()
        {
            double mark = 0;
            for (int i = 0; i < GetSignaturesCount(); i++)
            {
                if (_marks[i] > mark)
                    mark = _marks[i];
            }
            return mark;
        }
        public double GetLowestMark()
        {
            double mark = 20;
            for (int i = 0; i < GetSignaturesCount(); i++)
            {
                if (_marks[i] < mark)
                    mark = _marks[i];
            }
            return mark;
        }
    }
}
