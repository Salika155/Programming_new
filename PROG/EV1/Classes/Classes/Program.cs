using System.Runtime.InteropServices;

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


            

            CoinValor coin = CoinValor.C100;
            int centims = CoinChange.ToNumber(coin);
            Console.WriteLine(centims / 100 + " Euros");

            //aqui tengo que hacer cosas
            int centimos = 200;
            CoinValor moneda = CoinChange.ToMoneda(centimos);
            Console.WriteLine(moneda);

           //creo la variable con el valor, utilizao el objeto coinchange con el getcoin para obtener el valor de
           //las monedas de la lista, para sacar el de las que le estoy pasando.
           //creo un nuevo "objeto" instancia coinchange y le doy un nombre.
           //utilizo este ultimo creado, para imprimir las monedas.
            double cantidad = 13.40;
            List<CoinValor> monedas = CoinChange.GetCoin((int)cantidad);
            CoinChange coinChange0 = new CoinChange();
            coinChange0.PrintMonedas(monedas);
            Console.WriteLine("---------------------------------------------------------");

            double cantidad1 = 134021;
            List<CoinValor> monedas1 = CoinChange.GetCoin((int)cantidad1);
            CoinChange coinChange1 = new CoinChange();
            coinChange1.PrintMonedas(monedas1);
            Console.WriteLine("---------------------------------------------------------");

            //poker
            Card card = new(5, Palo.TREBOLES);
            Console.WriteLine(card.GetPalo());
            Console.WriteLine(card.GetNumber());
            Console.WriteLine(card.GetFigureType());
            Console.WriteLine(card.IsFigure() + " " + card.IsValid());
            Card card2 = new(39, Palo.TREBOLES);
            Console.WriteLine(card2.GetPalo());
            Console.WriteLine(card2.GetNumber());
            Console.WriteLine(card2.GetFigureType());
            Console.WriteLine(card2.IsFigure() + " " + card2.IsValid());
            Card card3 = new(-9, Palo.UNKNOWN);
            Console.WriteLine(card3.GetPalo());
            Console.WriteLine(card3.GetNumber());
            Console.WriteLine(card3.GetFigureType());
            Console.WriteLine(card3.IsFigure() + " " + card3.IsValid());

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
            Console.WriteLine(datetime.GetDay());
            Console.WriteLine(datetime.GetMonth());
            Console.WriteLine(datetime.GetYear());
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