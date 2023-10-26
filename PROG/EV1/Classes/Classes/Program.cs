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




        }
    }
}