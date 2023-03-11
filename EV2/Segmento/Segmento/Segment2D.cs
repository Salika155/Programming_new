using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
//using json

namespace Segmento
{
    class Punto2D
    {
        private double _X;
        private double _Y;

        public Punto2D()
        {

        }
        public Punto2D(double x, double y)
        {
            _X = x;
            _Y = y;
        }
    }

    class Segment2D
    {
        private Punto2D _puntoA;
        private Punto2D _puntoB;

        public Segment2D() 
        { 
        _puntoA = new Punto2D();
        _puntoB = new Punto2D();
        }

        // Constructor por defecto


        // Constructor con 2 puntos
        public Segment2D(Punto2D puntoa, Punto2D puntob)
        {
            _puntoA = puntoa;
            _puntoB = puntob;
            if (_puntoA == null)
            {
                _puntoA = new Punto2D();
            }


            // Método para desplazar la línea a la derecha
            public void MoveLeft(double displacement)
            {
                this._puntoA += displacement;
                this._puntoB += displacement;
            }

            // Método para desplazar la línea a la izquierda
            public void MoveRight(double displacement)
            {
                _puntoA.x -= displacement;
                _puntoB.x -= displacement;
            }

            // Método para desplazar la línea hacia arriba
            public double MoveUp(double distance)
            {
                _puntoA.y += distance;
                _puntoB.y += distance;
            }

            public double MoveDown(double distance)
            {
                _puntoA.y -= distance;
                _puntoB.y -= distance;
            }


            // Método ToString
            public string toString()
            {
                return "Segmento de puntos: (" + _puntoA.x + ", " + _puntoB.y + ") y (" + _puntoB.x + ", " + _puntoB.y + ")";
                // return Json.Serialize(This);

            }

            //public Point2D (PointA)
            //{
            //  get => _a;
            //set
            //{
            //_a = value;
            //if (-a == null)
            //_a = new PointA;
            //}
            //}

            //public double GetLength()
            //{
            // double dx = _a.x - _b.x;
            //double dy
            //return

            // Método para obtener la medida del segmento
            public double obtenerMedia()
            {
                double medida = Math.Sqrt(Math.Pow(_puntoA.x - _puntoB.x, 2) + Math.Pow(_puntoA.y - _puntoB.y, 2));
                return medida;
            }

            // Método para obtener el punto medio del segmento
            public Punto2D obtenerPuntoMedio()
            {
                Punto2D puntoMedio = new Punto2D();
                puntoMedio.x = (_puntoA.x + _puntoB.x) / 2;
                puntoMedio.y = (_puntoB.y + _puntoB.y) / 2;
                return puntoMedio;
            }


            // Método para intercambiar los valores Y de los dos puntos del segmento
            public void inteCambiarY()//swap
            {
                double aux = _puntoA.y;
                _puntoA.y = _puntoB.y;
                _puntoB.y = aux;
            }


            // Método para determinar si dos segmentos se intersectan
            public bool IntersectaCon(Segment2D otroSegmento)
            {
                double denominador = ((otroSegmento.PuntoB.y - otroSegmento.PuntoA.y) * (PuntoB.x - PuntoA.x)) -
                                     ((otroSegmento.PuntoB.x - otroSegmento.PuntoA.x) * (PuntoB.y - PuntoA.y));
                double numerador1 = ((otroSegmento.PuntoA.y - PuntoA.y) * (PuntoB.x - PuntoA.x)) -
                                     ((otroSegmento.PuntoA.x - PuntoA.x) * (PuntoB.y - PuntoA.y));
                double numerador2 = ((otroSegmento.PuntoA.y - PuntoA.y) * (otroSegmento.PuntoB.x - otroSegmento.PuntoA.x)) -
                                     ((otroSegmento.PuntoA.x - PuntoA.x) * (otroSegmento.PuntoB.y - otroSegmento.PuntoA.y));

                if (denominador == 0)
                {
                    return numerador1 == 0 && numerador2 == 0;
                }

                double r = numerador1 / denominador;
                double s = numerador2 / denominador;

                return (r >= 0 && r <= 1) && (s >= 0 && s <= 1);
            }

        }

    }

    
}
