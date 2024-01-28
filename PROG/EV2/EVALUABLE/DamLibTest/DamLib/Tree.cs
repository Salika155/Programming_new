using System;
using System.Collections.Generic;
using System.Linq;
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
                    _parent._children.Remove(this);
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
