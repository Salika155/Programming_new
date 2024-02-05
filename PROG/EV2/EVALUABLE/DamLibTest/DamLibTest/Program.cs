using DamLib;
using System.Text.Json;
using System;


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
            Console.WriteLine("---------------------");


            //Stack <string> s = new Stack<string>();
            //s.Pop(); 

            //buscar informacion default(T);



            //    var root = new Node<string>();
            //    // ...
            //    root.FindNode((comosea) =>
            //    {
            //        return true;
            //    });



            // Crear una instancia de Tree<int>
            Tree<int> intTree = new Tree<int>();

            // Crear algunos nodos y agregarlos al árbol
            // Establecer el nodo raíz en el árbol
            Tree<int>.Node<int> root = new Tree<int>.Node<int>(1);
            Tree<int>.Node<int> child1 = new Tree<int>.Node<int>(2);
            Tree<int>.Node<int> child2 = new Tree<int>.Node<int>(3);
            Tree<int>.Node<int> child3 = new Tree<int>.Node<int>(4);
            Tree<int>.Node<int> child4 = new Tree<int>.Node<int>(5);
            Tree<int>.Node<int> child5 = new Tree<int>.Node<int>(6);
            Tree<int>.Node<int> child6 = new Tree<int>.Node<int>(7);
            Tree<int>.Node<int> child7 = new Tree<int>.Node<int>(8);
            Tree<int>.Node<int> child8 = new Tree<int>.Node<int>(9);
            Tree<int>.Node<int> child9 = new Tree<int>.Node<int>(10);


            // Agregar hijos a la raíz
            root.AddChild(child1);
            root.AddChild(child2);
            child1.AddChild(child3);
            child3.AddChild(child4);
            child2.AddChild(child5);
            child3.AddChild(child6);

            // Set the root node of the tree
            

            // Realizar algunas operaciones
            Console.WriteLine("Root Value: " + root.GetRoot().Content);
            Console.WriteLine("Is Root? " + root.IsRoot);
            Console.WriteLine("Is Root? " + child6.IsRoot);
            Console.WriteLine("Level Value: " + child4.GetLevel());
            Console.WriteLine("Is Descendant? " + root.ContainsDescendant(child6));
            Console.WriteLine("Is Descendant? " + child5.ContainsDescendant(child6));
            Console.WriteLine("Is Ancestor? " + child3.ContainsAncestor(child1));
            Console.WriteLine("Is Ancestor? " + child5.ContainsAncestor(child4));
            Console.WriteLine("Number of Childs: " + child1.ChildCount);
            Console.WriteLine("Number of Childs: " + child3.ChildCount);



            // Agregar más nodos y realizar operaciones adicionales
            Tree<int>.Node<int> grandchild = new(11);
            child1.AddChild(grandchild);

            Console.WriteLine("Is Leaf? " + child1.IsLeaf);
            Console.WriteLine("Level: " + grandchild.Level);

            //// Realizar una búsqueda en el árbol
            //Tree<int>.Node<int>? foundNode = intTree.FindNode(node => node.Content.Equals(11));
            //if (foundNode != null)
            //{
            //    Console.WriteLine("Node Found: " + foundNode.Content);
            //}
            //else
            //{
            //    Console.WriteLine("Node Not Found");
            //}


        }   
    }
}