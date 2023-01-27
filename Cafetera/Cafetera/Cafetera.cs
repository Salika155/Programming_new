using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetera
{

    public class Cafetera
    {
        private int _capacidadMaxima;
        private int _cantidadActual;
        private EstadoCafetera _estado;

        public enum EstadoCafetera
        {
            Full,
            Empty,
            Current,
        }

        //constructor predeterminado
        public Cafetera()
        {
            this._capacidadMaxima = 1000;
            this._cantidadActual = 0;
            this._estado = EstadoCafetera.Empty;
        }

        // Constructor con capacidad máxima
        public Cafetera(int capacidadMaxima)
        {
            _capacidadMaxima = capacidadMaxima;
            _cantidadActual = capacidadMaxima;
            _estado = EstadoCafetera.Full;

            //_quantity=_capacity;
            //_capaity = _capacity;
            //opcion profesor: _capacity=_quantity=capacity;
        }

        // Constructor con capacidad máxima y cantidad actual
        public Cafetera(int capacidadMaxima, int cantidadActual)
        {

            if (_capacidadMaxima > capacidadMaxima)
                _cantidadActual = (cantidadActual > capacidadMaxima)
                ? capacidadMaxima : cantidadActual;
            _estado = (_cantidadActual == capacidadMaxima)
            ? EstadoCafetera.Full : EstadoCafetera.Current;
        }

        //_capacity = capacity;
        //if (capacity < quantity)
        //quantity = capacity
        //else
        //_quantity = quantity;

        public void FillCofee()
        {
            _cantidadActual = _capacidadMaxima;
            _estado = EstadoCafetera.Full;
        }

        public void ServeTaza(int capacidadTaza)
        {
            if (_cantidadActual < capacidadTaza)
            {
                _cantidadActual = 0;
                _estado = EstadoCafetera.Empty;
            }
            else
            {
                _cantidadActual -= capacidadTaza;
                _estado = EstadoCafetera.Current;
            }
        }
        //si devuelve algo es como la de la cuenta bancaria
        //devolviendo un entero seria:
        //public int ServeCoffee(int taza)
        //{
        //if (_quantity >= taza>)
        //quantity -= taza;
        //return 0;
        //}
        //else
        //{
        //int q = quantity;
        //_quantity = 0;
        //return taza - q;
        //}
        //pensar en negativos

        // Método para vaciar la cafetera
        public void EmptyCofeepot()
        {
            _cantidadActual = 0;
            _estado = EstadoCafetera.Empty;
        }

        // Método para añadir café a la cafetera
        public void PutCofeepot(int cantidadCafe)
        {
            _cantidadActual+= cantidadCafe;
            if (_cantidadActual > _capacidadMaxima)
            {
                _cantidadActual = _capacidadMaxima;
            }
            _estado = (_cantidadActual == _capacidadMaxima) ?
                EstadoCafetera.Full : EstadoCafetera.Current;

        }



        // Método para obtener el estado de la cafetera

        public EstadoCafetera ObtenerEstado()
        {
            return _estado;
        }

        //switch espera variable

        //if (_quantity == 0)
        //return estadocafetera.empty;
        //if (_quanity == :capacity)
        //return full;
        //return in_process;

        // Método para clonar la cafetera

        public Cafetera CloneCafetera()
        {
            return new Cafetera(_capacidadMaxima, _cantidadActual);
        }

        //caferer c = new caferer();
        //{
        //c.quantity=_quantity;
        //c.capacity=_capacity;
        //}
        //return c

        // Propiedad para obtener la capacidad máxima de la cafetera

        public int CapacidadMaxima
        {
            get { return _capacidadMaxima;}
        }

        // Propiedad para obtener la cantidad actual de café en la cafetera
        public int CantidadActual
        {
            get { return _cantidadActual;}
        }

        // Propiedad para obtener el estado de la cafetera

        public EstadoCafetera Estado
        {
            get { return _estado;}
        }


    }


}
