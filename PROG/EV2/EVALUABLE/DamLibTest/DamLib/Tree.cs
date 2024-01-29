using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace DamLib
{
    public class Tree <T>
    {
        private class Node<T>
        {
            private T _content;
            private List<Node<T>> _children = new List<Node<T>>();
            private Node<T>? _parent;

            public Node(T content)
            {
                _content = content;
            }


            public Node<T> Parent
            {
                get
                {
                    return _parent;
                }
                set
                {
                    if (_parent != null)
                    {
                        _parent._children.Remove(this);
                    }
                    _parent = value;

                    if (_parent != null)
                    {
                        _parent._children.Add(this);
                    }
                }
            }

            public bool IsRoot
            {
                get
                {
                    return _parent == null;
                }
            }

            public bool IsLeaf
            {
                get
                {
                    return _children.Count == 0;
                }
            }

            public int ChildCount
            {
                get
                {
                    return _children.Count;
                }
            }

            public int Level
            {
                get
                {
                    if (_parent == null)
                        return 0;
                    return _parent.Level + 1;
                }
            }

            public Node<T> Root
            {
                get
                {
                    if (_parent == null)
                        return this;
                    return _parent.Root;
                }
            }

            public int GetLevel()
            {
                if (_parent == null)
                    return 0;
                return _parent.GetLevel() + 1;
            }

            public Node<T> GetRoot()
            {
                if (_parent == null)
                    return this;
                return _parent.GetRoot();
            }

            public Node<T>? GetChildAt(int index)
            {
                if (index < 0 || index >= _children.Count)
                    return null;
                return _children[index];
            }

            public void Unlink()
            {
                if (_parent != null)
                    _parent._children.Remove(this);
                _parent = null;
            }

            private void Unlink1()
            {
                if (_parent != null)
                {
                    _parent.RemoveChild(this);
                    _parent = null;
                }
            }

            public void AddChild(Node<T> child)
            {
                if (child == null)
                    return;
                child.Unlink();
                child._parent = this;
                _children.Add(child);
            }

            //public void RemoveChild(Node<T> node)
            //{
            //    int index = IndexOf(node);
            //      if (index >= 0)
                        
            //    _children.RemoveAt(index);
            //}

            //public int IndexOf(Node<T> node)
            //{

            //}

            void SetParent(Node<T> node)
            {
                if (node == null)
                    Unlink();
                else
                    node.AddChild(this);
            }

            bool HasSibling()
            {
                if(_parent != null)
                    return _parent._children.Count > 0;
                return false;
            }

            bool ContainsAncestor(Node<T> node)
            {
                if (node == null || _parent == null)
                    return false;
                if (_parent == node)
                    return true;
                return _parent.ContainsAncestor(node);
            }

            bool ContainsDescendant(Node<T> node)
            {
                //comprobar sea null
                if (node == null)
                    return false;
                for (int i = 0; i < _children.Count; i++)
                {
                    if (_children[i] == node)
                        return true;
                    if(_children[i].ContainsDescendant(node))
                    return true;

                }
                return false;
            }

            delegate void VisitDelegade<T>(Node<T> node);

            //recorrer todos los nodos
            void Visit(VisitDelegade<T> visitor)
            {
                if (visitor == null)
                    return;
                visitor(this);
                for (int i = 0; i < _children.Count; i++)
                {
                    _children[i].Visit(visitor);
                }
            }

            delegate bool CheckDelegate<T>(Node<T> node);

            Node<T> FindNode(CheckDelegate<T> checker)
            {

            }

            delegate bool CheckDelegateNode<T>(T element);

            Node<T> FindNode2(CheckDelegateNode<T> checker)
            {

            }


            //nODE <t> Parent {get; set;}
            //bool IsRoot {get;}
            //bool IsLeaf{get}
            //int ChildCount{get}
            //int Level {get}
            //node <T> Root {get;set}

            //int GetLevel()
            //{
            // if (_parent == null)
            //return 0;
            //return _parent.GetLevel()+1;

            //Node<T> GetRoot()
            //{
            //if (_parent == null)
            //return this;
            //return _parent.GetRoot();
            //}

            //Node<T> GetChildAt(int index)

            //void Unlink o Detach()
            //{_parent.Remove(this) (tiene que ser private) }

            //void AddChild(Node<T> child)


        }
    }
}
