using DamLib;
using System.Text.Json;

namespace DamLibTest
{
    public class Program
    {
        public class Test1Result
        {
            public bool Empty { get; set; }
            public int Count { get; set; }
            public bool Empty1 { get; set; }
            public int Count1 { get; set; }
            public bool EmptyJuan { get; set; }
            public int CountJuan { get; set; }
            public bool ContainsJuan { get; set; }
            public bool EmptyJuan2 { get; set; }
            public int CountJuan2 { get; set; }
            public bool ContainsJuan2 { get; set; }
            public bool EmptyAna { get; set; }
            public int CountAna { get; set; }
            public bool ContainsAna2 { get; set; }
            public bool EmptyAna2 { get; set; }
            public int CountAna2 { get; set; }
            public bool ContainsAna { get; set; }

        }
        //Test de caja blanca
        public static Test1Result Test1(DamLib.ISet<string> set)
        {
            Test1Result result = new Test1Result(); 
            set.Clear();
            result.Empty = set.Empty;
            result.Count = set.Count;
            set.Remove(null);
            set.Add(null);
            set.Contains(null);
            set.Add("Juan");

            result.EmptyJuan = set.Empty;
            result.CountJuan = set.Count;
            result.ContainsJuan = set.Contains("Juan");

            return result;
        }

        #region Test
        //public interface ISet<T>
        //{
        //    //en c# puedo definir una propertie en interface
        //    //si tienes get y set normalmente en la misma crea una variable privada, pero en una interface es solo una llamada
        //    bool IsEmpty
        //    {
        //        get;
        //    }
        //    int Count { get; }
        //    void Clear();
        //    void Add(T item);
        //    void Remove(T item);
        //    bool Contains(T item);
        //}
        #endregion

        static void Main(string[] args)
        {

            Set<string> setExample = new Set<string>();
            Test1Result result1 = Test1(setExample);

            ItemSet<string> ItemSetExample2 = new ItemSet<string>();
            Test1Result result2 = Test1(ItemSetExample2);

            string stringResult = JsonSerializer.Serialize(result1);
            string stringResult2 = JsonSerializer.Serialize(result2);

            if (stringResult == stringResult2)
            {
                Console.WriteLine("Son iguales.");
            }
            else
            {
                Console.WriteLine("Son diferentes.");
                Console.WriteLine("Resultado 1: " + stringResult);
                Console.WriteLine("Resultado 2: " + stringResult2);
            }
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

            DamLib.Set<string> set = new DamLib.Set<string>();

            set.Add("hola");
            set.Add("que");
            Console.WriteLine("El número de elementos dentro del conjunto es: " + set.Count);
            set.Add("tal");
            set.Add(null);

            Console.WriteLine("El número de elementos dentro del conjunto es: " + setExample.Count);

            string elementSetToRemove = "que";
            set.Remove(elementSetToRemove);
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



            //    var root = new Node<string>();
            //    // ...
            //    root.FindNode((comosea) =>
            //    {
            //        return true;
            //    });



            DamLib.Tree<string> tree = new Tree<string>();

            

            

           
            

            


          
        }
    }
}