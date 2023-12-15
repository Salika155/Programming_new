using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{

    public interface ICosa
    {
        void Cosica1();

    }

    public interface IPerro : ICosa
    {
        void Metodo1();

        void Metodo2();

        void Metodo3();

    }


    public abstract class Perro
    {
        public abstract void Metodo1();

        public abstract void Metodo2();

        public abstract void Metodo3();

        public abstract void Metodo4();

        public abstract void Metodo5();


    }
}
