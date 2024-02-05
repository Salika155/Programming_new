using DamLib;

namespace BasuraTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine("Root Value: " + root.GetRoot()._item);
            Console.WriteLine("Is Root? " + root.IsRoot);
            Console.WriteLine("Is Root? " + child6.IsRoot);
            Console.WriteLine("Level Value: " + child4.GetLevel());
            Console.WriteLine("Is Descendant? " + root.ContainsDescendant(child6));
            Console.WriteLine("Is Descendant? " + child5.ContainsDescendant(child6));
            Console.WriteLine("Is Ancestor? " + child3.ContainsAncestor(child1));
            Console.WriteLine("Is Ancestor? " + child5.ContainsAncestor(child4));




            // Agregar más nodos y realizar operaciones adicionales
            Tree<int>.Node<int> grandchild = new(11);
            child1.AddChild(grandchild);

            Console.WriteLine("Is Leaf? " + child1.IsLeaf);
            Console.WriteLine("Level: " + grandchild.Level);


            Console.WriteLine("------------------------------------------");


            // Crear una instancia de Tree<int>
            TreeWithWeakReference<int> intTree1 = new TreeWithWeakReference<int>();

            // Crear algunos nodos y agregarlos al árbol
            // Establecer el nodo raíz en el árbol
            TreeWithWeakReference<int>.Node<int> root1 = new TreeWithWeakReference<int>.Node<int>(1);
            TreeWithWeakReference<int>.Node<int> child11 = new TreeWithWeakReference<int>.Node<int>(2);
            TreeWithWeakReference<int>.Node<int> child21 = new TreeWithWeakReference<int>.Node<int>(3);
            TreeWithWeakReference<int>.Node<int> child31 = new TreeWithWeakReference<int>.Node<int>(4);
            TreeWithWeakReference<int>.Node<int> child41 = new TreeWithWeakReference<int>.Node<int>(5);
            TreeWithWeakReference<int>.Node<int> child51 = new TreeWithWeakReference<int>.Node<int>(6);
            TreeWithWeakReference<int>.Node<int> child61 = new TreeWithWeakReference<int>.Node<int>(7);
            TreeWithWeakReference<int>.Node<int> child71 = new TreeWithWeakReference<int>.Node<int>(8);
            TreeWithWeakReference<int>.Node<int> child81 = new TreeWithWeakReference<int>.Node<int>(9);
            TreeWithWeakReference<int>.Node<int> child91 = new TreeWithWeakReference<int>.Node<int>(10);


            // Agregar hijos a la raíz
            root1.AddChild(child11);
            root1.AddChild(child21);
            child11.AddChild(child31);
            child31.AddChild(child41);
            child21.AddChild(child51);
            child31.AddChild(child61);

            // Set the root node of the tree


            // Realizar algunas operaciones
            Console.WriteLine("Root Value: " + root1.GetRoot().Content);
            Console.WriteLine("Is Root? " + root1.IsRoot);
            Console.WriteLine("Is Root? " + child61.IsRoot);
            Console.WriteLine("Level Value: " + child41.GetLevel());
            Console.WriteLine("Is Descendant? " + root1.ContainsDescendant(child61));
            Console.WriteLine("Is Descendant? " + child51.ContainsDescendant(child61));
            Console.WriteLine("Is Ancestor? " + child31.ContainsAncestor(child11));
            Console.WriteLine("Is Ancestor? " + child51.ContainsAncestor(child41));
            Console.WriteLine("Number of Childs: " + child11.ChildCount);
            Console.WriteLine("Number of Childs: " + child31.ChildCount);



            // Agregar más nodos y realizar operaciones adicionales
            TreeWithWeakReference<int>.Node<int> grandchild1 = new(11);
            child11.AddChild(grandchild1);

            Console.WriteLine("Is Leaf? " + child11.IsLeaf);
            Console.WriteLine("Level: " + grandchild1.Level);

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
