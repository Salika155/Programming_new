namespace Rectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Crear un nuevo rectángulo
                Rectangulo rect1 = new Rectangulo(1, 1, 4, 5);

                // Crear otro rectángulo
                Rectangulo rect2 = new Rectangulo(2, 3, 2, 3);

                // Imprimir la diagonal del rectángulo
                Console.WriteLine("Diagonal del rectángulo: " + rect1.obtenerDiagonal());

                // Imprimir el área del rectángulo
                Console.WriteLine("Área del rectángulo: " + rect1.obtenerArea());

                // Imprimir el perímetro del rectángulo
                Console.WriteLine("Perímetro del rectángulo: " + rect1.obtenerPerimetro());

                // Comprobar si los rectángulos se intersectan
                Console.WriteLine("¿Los rectángulos se intersectan? " + rect1.intersectaCon(rect2));

                Console.ReadLine();
            }
        }
    }
}