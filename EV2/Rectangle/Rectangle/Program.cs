namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(0, 0, 3, 3);
            Rectangle r2 = new Rectangle(0, 0, 4, 4);

            Console.WriteLine("Los rectangulos r1 y r2 se intersectan? " + r1.IntersectWith(r2));
            Console.WriteLine("La diagonal del r1 es: " + r1.GetDiagonal());
            Console.WriteLine("La diagonal del r2 es: " + r2.GetDiagonal());
            Console.WriteLine("El area del r1 es: " + r1.GetArea());
            Console.WriteLine("El area del r2 es: " + r2.GetArea());
            Console.WriteLine("El perimetro del r1 es: " + r1.GetPerimeter());
            Console.WriteLine("El perimetro r2 es: " + r2.GetPerimeter());

            Rectangle r3 = new Rectangle(5, 5, 13, 23);
            Rectangle r4 = new Rectangle(1, 1, 3, 3);

            Console.WriteLine("Los rectangulos r3 y r4 se intersectan? " + r3.IntersectWith(r4));
            Console.WriteLine("La diagonal del r3 es: " + r3.GetDiagonal());
            Console.WriteLine("La diagonal del r4 es: " + r4.GetDiagonal());
            Console.WriteLine("El area del r3 es: " + r3.GetArea());
            Console.WriteLine("El area del r4 es: " + r4.GetArea());
            Console.WriteLine("El perimetro del r3 es: " + r3.GetPerimeter());
            Console.WriteLine("El perimetro r4 es: " + r4.GetPerimeter());

            Rectangle r5 = new Rectangle(5, 15, 8, 18);
            Rectangle r6 = new Rectangle(4, 4, 7, 18);

            Console.WriteLine("Los rectangulos r5 y r6 se intersectan? " + r5.IntersectWith(r6));

            Rectangle r7 = new Rectangle(15, 12, 15, 12);
            Rectangle r8 = new Rectangle(5, 2, 5, 2);

            Console.WriteLine("Los rectangulos r7 y r8 se intersectan? " + r7.IntersectWith(r8));

            Rectangle r9 = new Rectangle(0, 0, 2, 2);
            Rectangle r10 = new Rectangle(1, 1, 2, 2);

            Console.WriteLine("Los rectangulos r9 y r10 se intersectan? " + r9.IntersectWith(r10));

        }
    }
}