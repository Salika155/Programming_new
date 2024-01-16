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

            Console.WriteLine("---------------------");

            //Set

            DamLib.Set<string> stack = new DamLib.Set<string>();

            stack.Add("hola");
            stack.Add("que");
            stack.Add("tal");
            stack.Add(null);

            Console.WriteLine("Elemento del top es: " + stack.Contains);
            Console.WriteLine("El número de elementos dentro de la cola es: " + stack.Count);

            string stackElement1 = stack.Remove();
            Console.WriteLine("Elemento saliente es: " + stackElement1);
            string stackElement2 = stack.Remove();
            Console.WriteLine("Elemento saliente es: " + stackElement2);
            Console.WriteLine("Elemento del top es: " + stack.Contains);
            string stackElement3 = stack.Remove();
            Console.WriteLine("Elemento saliente es: " + stackElement3);
            Console.WriteLine("El número de elementos dentro de la cola es: " + stack.Count);

            string stackElement4 = stack.Remove();
            Console.WriteLine("Elemento saliente es: " + stackElement4);
            string stackElement5 = stack.Remove();
            Console.WriteLine("Elemento saliente es: " + stackElement5);

            Console.WriteLine("---------------------");

            //SetWithHash

            DamLib.SetWithHash<string> sethash = new DamLib.SetWithHash<string>();

            sethash.Add("hola");
            sethash.Add("que");
            sethash.Add("tal");
            sethash.Add(null);

            Console.WriteLine("Elemento del top es: " + sethash.Contains);
            Console.WriteLine("El número de elementos dentro de la cola es: " + sethash.Contains);

            //string stackhashElement1 = sethash.Remove();
            //Console.WriteLine("Elemento saliente es: " + stackhashElement1);
            //string stackhashElement2 = sethash. Remove();
            //Console.WriteLine("Elemento saliente es: " + stackhashElement2);
            //Console.WriteLine("Elemento del top es: " + sethash.Count);
            //string stackhashElement3 = sethash.Remove();
            //Console.WriteLine("Elemento saliente es: " + stackhashElement3);
            //Console.WriteLine("El número de elementos dentro de la cola es: " + sethash.Count);

            //string stackhashElement4 = sethash.Remove();
            //Console.WriteLine("Elemento saliente es: " + stackhashElement4);
            //string stackhashElement5 = sethash.Remove();
            //Console.WriteLine("Elemento saliente es: " + stackhashElement5);

            Console.WriteLine("---------------------");

            DamLib.ItemSet<string> item = new DamLib.ItemSet<string>();

            item.Add("hola");
            item.Add("que");
            item.Add("tal");
            item.Add(null);

            Console.WriteLine("Elemento del top es: " + item.Contains);
            Console.WriteLine("El número de elementos dentro de la cola es: " + item.Contains);

            //Stack <string> s = new Stack<string>();
            //s.Pop(); 

            //buscar informacion default(T);

        }
    }
}