namespace CoffeeMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeMaker coffeeMaker1 = new CoffeeMaker();

            Console.WriteLine("Capacidad actual de la cafetera es de: " + coffeeMaker1.ActualCapacity);
            Console.WriteLine("El estado de la cafetera ahora es: " + coffeeMaker1.GetState());

            coffeeMaker1.FillCoffeeMaker(500);
            Console.WriteLine("Capacidad actual tras llenar la cafetera es de: " + coffeeMaker1.ActualCapacity);
            Console.WriteLine("El Estado de la cafetera ahora es: " + coffeeMaker1.GetState());

            coffeeMaker1.ServeCup(200);
            Console.WriteLine("Al servir una taza de café de la cafetera la capacidad actual de la cafetera es de: " + coffeeMaker1.ActualCapacity);
            Console.WriteLine("El Estado de la cafetera ahora es: " + coffeeMaker1.GetState());

            coffeeMaker1.ServeCup(300);
            Console.WriteLine("Al servir una taza de café de la cafetera la capacidad actual de la cafetera es de: " + coffeeMaker1.ActualCapacity);
            Console.WriteLine("El Estado de la cafetera ahora es: " + coffeeMaker1.GetState());

            coffeeMaker1.FillCoffeeMaker(1000);
            Console.WriteLine("Capacidad actual tras llenar la cafetera es de: " + coffeeMaker1.ActualCapacity);
            Console.WriteLine("El Estado de la cafetera ahora es: " + coffeeMaker1.GetState());

            coffeeMaker1.EmptyCoffeeMaker();
            Console.WriteLine("Capacidad actual tras llenar la cafetera es de: " + coffeeMaker1.ActualCapacity);
            Console.WriteLine("El Estado de la cafetera ahora es: " + coffeeMaker1.GetState());


        }
    }
}