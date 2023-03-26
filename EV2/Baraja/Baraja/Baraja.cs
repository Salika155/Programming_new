using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Baraja
{


    class Baraja
    {
        //Atributos privados
        private List<Carta> _list = new List<Carta>(); //todos objetos en lista salvo excepcion son private, para evitar que sea null y que molesten
        


        //Properties
        public int CardCount => _list.Count;

        //Métodos
        public Carta? ObtenerCartaAtIndex(int index)
        {
            if (index < 0 || index >= CardCount)
                return null;

            return _list[index];
        }

        public Carta? ExtraerCartaAtIndex(int index)
        {
            if (index < 0 || index >= CardCount)
                return null;
            Carta aux = _list[index];
            _list.RemoveAt(index);
            return aux;
        }

        public Carta? ExtraerCarta(int numero, CardType type)
        {
            int index = FindCardIndex(numero, type);
            return ExtraerCartaAtIndex(index);

        }

        private int FindCardIndex(int numero, CardType type)
        {
            for (int i = 0; i < CardCount; i++)
            {
                var c = _list[i];
                if (c.Numero == numero && c.Type == type)
                    return i;
            }
            return -1;
        }

        // Javi: Una ñ!??!??!?!?!?!?!??!
        public void AñadirCarta(int numero, CardType type)
        {
            Carta carta = new Carta(numero, type);
            int index = FindCardIndex(carta.Numero, carta.Type);
            
            if (index >= 0)
            return;
            _list.Add(carta);

            //if (index < 0)
            //-list.Add
            //bool result = true;
            //for (int i = 0; i <= _list.Count; i++)
            //{
                //if (_list[i].Numero == CardCount && _list[i].Type == type)
                    //result = false;
            //}
            //if (result)
            //_list.Add(new Carta(CardCount, type));
        }



        public void AñadirCarta(Carta carta)
        {
            for (int i = 1; i <= 12; i++)
            {
                // Javi: No es correcto
                if (carta.Numero == i)
                _list.Add(carta);
            }

        }

        public void Barajar()
        {
            for (int i = 0; i < CardCount; i++)
            {
                int i0 = Utils.GetRandomInteger(0, CardCount);
                swap(i0, i);
            }

        }

        private void swap(int index1, int index2)
        {
            Carta aux = _list[index1];
            _list[index1] = _list[index2];
            _list[index2] = aux;
        }

        public List<Carta> ExtraerPrimeras(int cantidad)
        {
            List<Carta> primerasCartas = new List<Carta>();
            for (int i = 0; i < cantidad; i++)
            {
                if (i < _list.Count)
                {
                    // Javi: Casi!!!! es _list[0]
                    primerasCartas.Add(_list[i]);
                    _list.RemoveAt(i);
                }
            }
            return primerasCartas;
        }

        public void Resetear()
        {
            List<Carta> resetcartas = new List<Carta>();
            for (int i = 0; i < 12; i++)
                resetcartas.Add(new Carta(i, CardType.Oros));
            for (int i = 0; i < 12; i++)
                resetcartas.Add(new Carta(i, CardType.Copas));
            for (int i = 0; i < 12; i++)
                resetcartas.Add(new Carta(i, CardType.Espadas));
            for (int i = 0; i < 12; i++)
                resetcartas.Add(new Carta(i, CardType.Bastos));
        }
            
            
        //for (int i = 1; i <= 12; i++)
        //  _list.Add(new Carta(i, palo));
    }
}

    
                


    




            


        
    

