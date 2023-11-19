﻿using System.Runtime.InteropServices;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jar jar = new Jar();

            Console.WriteLine("La capacidad actual de la jarra es de: " + jar.GetCapacity());

            jar.SetCapacity(1500);
            Console.WriteLine("La nueva capacidad de la jarra es de: " + jar.GetCapacity());

            jar.SetQuantity(500);
            Console.WriteLine("La cantidad que contiene la taza es de: " + jar.GetQuantity());

            Console.WriteLine("La jarra esta llena al " + jar.GetPercent() * 100 + "%");

            Console.WriteLine("Lo que queda para llenarse es " + jar.GetRemain());

            jar.SetQuantity(0);
            Console.WriteLine("La cantidad que contiene la taza es de: " + jar.GetQuantity());

            jar.AddQuantity(240);
            Console.WriteLine("La cantidad tras añadir es de: " + jar.GetQuantity());
            Console.WriteLine("---------------------------------------------------------");

            CoffeeMachine coffeeMachine = new CoffeeMachine();

            Console.WriteLine("El estado de la cafetera es: "+ coffeeMachine.GetState());

            coffeeMachine.ChangeToNextState();
            Console.WriteLine("El estado de la cafetera es: " + coffeeMachine.GetState());
            Console.WriteLine("---------------------------------------------------------");

            CoinChange coinChange = new CoinChange();

            CoinValor coin = CoinValor.C100;
            int centims = CoinChange.ToNumber(coin);
            Console.WriteLine(centims / 100 + " Euros");

            int centimss = 200;
            CoinValor moneda = CoinChange.ToMoneda(centimss);
            Console.WriteLine(moneda);

            //double cantidad = 134.45;
            //List<CoinValor> monedas = CoinChange.GetCoin((int)cantidad);
            //Console.WriteLine(monedas);
            Console.WriteLine("---------------------------------------------------------");

            Card card = new(54, Palo.TREBOLES);
            Console.WriteLine(card);
            Console.WriteLine(card.GetFigureType());
            Console.WriteLine(card.IsFigure() + " " + card.IsValid());
            Console.WriteLine("---------------------------------------------------------");

            ChessFigure figure = new(2, 5, ChessFigureColor.WHITE, ChessFigureType.BISHOP);
            Console.WriteLine(figure.GetFigureType());
            Console.WriteLine(figure.GetFigureType() + " " + figure.IsValid());
            Console.WriteLine("---------------------------------------------------------");

            Datetime datetime = new Datetime();
            Console.WriteLine("La fecha de hoy es: " + datetime);

            datetime.SetYear(1993);
            datetime.SetMonth(12);
            datetime.SetDay(31);
            Console.WriteLine("La fecha actualizada es: " + datetime);
            datetime.IncrementDays();
            Console.WriteLine("El año es válido: " + datetime.IsValid());

            Console.WriteLine("La fecha de hoy es: " + datetime);
            datetime.IncrementSeconds();
            Console.WriteLine("El año es bisieto: " + datetime.IsLeap());
            Console.WriteLine(datetime.GetDayOfWeek());
            Console.WriteLine(datetime.ToString());
            Console.WriteLine(datetime.Equals(datetime));

            

        }
    }
}