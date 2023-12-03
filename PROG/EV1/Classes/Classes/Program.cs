using System.Runtime.InteropServices;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cafetera jarra
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

            //maquina estados
            CoffeeMachine coffeeMachine = new CoffeeMachine();

            Console.WriteLine("El estado de la cafetera es: "+ coffeeMachine.GetState());

            coffeeMachine.ChangeToNextState();
            Console.WriteLine("El estado de la cafetera es: " + coffeeMachine.GetState());
            Console.WriteLine("---------------------------------------------------------");

            //monedas
            CoinChange coinChange = new CoinChange();

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

            //tengo que probar domino




            //ajedrez
            ChessFigure figure = new(2, 5, ChessFigureColor.WHITE, ChessFigureType.BISHOP);
            Console.WriteLine(figure.GetFigureType());
            Console.WriteLine(figure.GetFigureType() + " " + figure.IsValid());
            Console.WriteLine("---------------------------------------------------------");

            //datetime
            Datetime datetime = new Datetime();
            //fallaba -> ya no, me faltaba añadir tostring al datetime
            Console.WriteLine("La fecha de hoy es: " + datetime.ToString());

            datetime.SetYear(1993);
            datetime.SetMonth(12);
            datetime.SetDay(31);
            //fallaba -> ya no, me faltaba añadir tostring al datetime
            Console.WriteLine("La fecha actualizada es: " + datetime.ToString());
            Console.WriteLine("El numero de dia de hoy es: " + datetime.GetDay());
            Console.WriteLine("El mes en el que estamos es: " + datetime.GetMonth());
            Console.WriteLine("El año en el que estamos es: "+ datetime.GetYear());
            Console.WriteLine("El dia de la semana que estamos es: " + datetime.GetDayOfWeek());
            datetime.IncrementDays();
            Console.WriteLine("El año es válido: " + datetime.IsValid());
            //fallaba -> ya no, me faltaba añadir tostring al datetime
            Console.WriteLine("La fecha de hoy es: " + datetime.ToString());
            datetime.IncrementSeconds();
            Console.WriteLine("El año es bisieto: " + datetime.IsLeap());
            Console.WriteLine(datetime.GetDayOfWeek());
            Console.WriteLine("La fecha de hoy es: " + datetime.ToString());
            Console.WriteLine(datetime.Equals(datetime.ToString()));

            int year1 = 1993;
            int year2 = 2023;
            int leapCount = Datetime.GetLeapCountBetween(year1, year2);
            Console.WriteLine(leapCount);
            

        }
    }
}