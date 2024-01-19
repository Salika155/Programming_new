using DamLib;

namespace DamLibTest
{
    public class Program
    {
        //Test de caja blanca
        public static void Test1(Set<string> set)
        {

        }
        static void Main(string[] args)
        {

            Set<string> setExample = new Set<string>();
            Test1(setExample);

            //Stack s;
            //DamLib.Stack s1;


            DamLib.Stack<string> s = new DamLib.Stack<string>();

            Console.WriteLine("Stack");
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
            Console.WriteLine("Queue");

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
            Console.WriteLine("Set");

            //Set

            DamLib.Set<string> set = new Set<string>();

            setExample.Add("hola");
            setExample.Add("que");
            Console.WriteLine("El número de elementos dentro del conjunto es: " + setExample.Count);
            setExample.Add("tal");
            setExample.Add(null);

            Console.WriteLine("El número de elementos dentro del conjunto es: " + setExample.Count);

            string elementSetToRemove = "que";
            setExample.Remove(elementSetToRemove);
            Console.WriteLine("Elemento eliminado = " + elementSetToRemove);

            Console.WriteLine("---------------------");
            Console.WriteLine("SetWithHash");

            //SetWithHash

            DamLib.SetWithHash<string> sethash = new SetWithHash<string>();

            sethash.Add("hola");
            sethash.Add("que");
            Console.WriteLine("El número de elementos dentro del conjunto es: " + sethash.Count);
            sethash.Add("tal");
            sethash.Add(null);

            Console.WriteLine("El número de elementos dentro del conjunto es: " + sethash.Count);

            string elementToRemove = "que";
            sethash.Remove(elementToRemove);
            Console.WriteLine($"Elemento '{elementToRemove}' eliminado");

            Console.WriteLine("---------------------");
            Console.WriteLine("ItemSet");

            //ItemSet
            DamLib.ItemSet<string> itemSet = new ItemSet<string>();

            itemSet.Add("hola");
            itemSet.Add("que");
            itemSet.Add("tal");
            itemSet.Add(null);

            Console.WriteLine("---------------------");
            Console.WriteLine("El número de elementos en el conjunto es: " + itemSet.Count);

            Console.WriteLine("¿Contiene 'hola'? " + itemSet.Contains("hola"));
            Console.WriteLine("Conjunto actual: ");
            for (int i = 0; i < itemSet.Count; i++)
            {
                //Console.WriteLine(itemSet[i]);
            }

            itemSet.Remove("que");

            Console.WriteLine("¿El conjunto está vacío? " + itemSet.Empty);
            




            //Stack <string> s = new Stack<string>();
            //s.Pop(); 

            //buscar informacion default(T);

        }
    }
}