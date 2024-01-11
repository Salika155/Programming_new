namespace DamLibTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Stack s;
            //DamLib.Stack s1;


            DamLib.Stack<string> s = new DamLib.Stack<string>();

            //Stack
            s.Push("hola");
            s.Push("que");
            s.Push("tal");
            s.Push(null);

            Console.WriteLine("Elemento del top es: " + s.GetTop());

            Console.WriteLine("El número de elementos dentro del stack es: " + s.GetCount());

            string popElement1 = s.Pop();
            Console.WriteLine("Elemento saliente es: " + popElement1);
            string popElement2 = s.Pop();
            Console.WriteLine("Elemento saliente es: " + popElement2);
            Console.WriteLine("Elemento del top es: " + s.GetTop());
            string popElement3 = s.Pop();
            Console.WriteLine("Elemento saliente es: " + popElement3);
            Console.WriteLine("El número de elementos dentro del stack es: " + s.GetCount());
            string popElement4 = s.Pop();
            Console.WriteLine("Elemento saliente es: " + popElement4);
            string popElement5 = s.Pop();
            Console.WriteLine("Elemento saliente es: " + popElement5);

            Console.WriteLine("---------------------");

            //Queue
            DamLib.Queue<string> q = new DamLib.Queue<string>();

            q.EnQueue("hola");
            q.EnQueue("que");
            q.EnQueue("tal");
            q.EnQueue(null);

            Console.WriteLine("Elemento del top es: " + q.First);
            Console.WriteLine("El número de elementos dentro de la cola es: " + q.Count);

            string deqElement1 = q.Dequeue();
            Console.WriteLine("Elemento saliente es: " + deqElement1);
            string deqElement2 = q.Dequeue();
            Console.WriteLine("Elemento saliente es: " + deqElement2);
            Console.WriteLine("Elemento del top es: " + q.First);
            string deqElement3 = q.Dequeue();
            Console.WriteLine("Elemento saliente es: " + deqElement3);
            Console.WriteLine("El número de elementos dentro de la cola es: " + q.Count);

            string deqElement4 = q.Dequeue();
            Console.WriteLine("Elemento saliente es: " + deqElement4);
            string deqElement5 = q.Dequeue();
            Console.WriteLine("Elemento saliente es: " + deqElement5);


            //Stack <string> s = new Stack<string>();
            //s.Pop(); 

            //buscar informacion default(T);

        }
    }
}