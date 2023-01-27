namespace Baraja
{
    class Program
    {
        static void Main(string[] args)
        {
            Baraja baraja = new Baraja();
            // Añadir _list a la baraja
            baraja.AñadirCarta(new Carta(5, CardType.Espadas));
            baraja.AñadirCarta(3, CardType.Bastos);
            baraja.AñadirCarta(5, CardType.Oros);
            baraja.AñadirCarta(7, CardType.Copas);

            // Imprimir cantidad de _list en la baraja
            Console.WriteLine("Cantidad de _list en la baraja: " + baraja.CardCount);

            // Extraer carta en posición 1
            Carta cartaExtraida = baraja.ExtraerCartaAtIndex(21);
            Console.WriteLine("Carta extraida en posición 1: " + cartaExtraida.Numero + " de " + 12);

            // Extraer carta con número 5 y palo "espadas"
            Carta cartaEspecifica = baraja.ExtraerCarta(5, CardType.Espadas);
            Console.WriteLine("Carta extraida específica: " + cartaEspecifica.Numero + " de " + 12);

            // Barajar la baraja
            baraja.Barajar();
            Console.WriteLine("Baraja barajada!");

            // Extraer las primeras 3 _list
            List<Carta> primerasCartas = baraja.ExtraerPrimeras(3);
            Console.WriteLine("Primeras 3 _list extraidas:");
            foreach (Carta c in primerasCartas)
            {
                Console.WriteLine(c.Numero + " de " + 12);
            }

            // Resetear la baraja
            baraja.Resetear();
            Console.WriteLine("Baraja reseteada!");
            Console.WriteLine("Cantidad de _list en la baraja: " + baraja.CardCount);

            Console.ReadKey();
        }
    }
}