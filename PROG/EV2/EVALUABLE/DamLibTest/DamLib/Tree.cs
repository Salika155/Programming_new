using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamLib
{
    public class Tree
    {
        private class Node<T>
        {
            T Content;
            List<Node<T>> _children = new List<Node<T>>();
            Node<T> _parent;

            public Node(T content)
            {
                Content = content;
            }
        }
    }
}
