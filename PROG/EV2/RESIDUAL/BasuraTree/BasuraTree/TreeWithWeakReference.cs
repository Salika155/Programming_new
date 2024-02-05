using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DamLib
{
    public class TreeWithWeakReference<T>
    {
        public class Node<T>
        {
            private T _content;
            private List<Node<T>> _children = new List<Node<T>>();
            //private Node<T>? _parent;
            //private Node<T>? _root;
            WeakReference<Node<T>> _parent;


            public Node(T content)
            {
                _content = content;
            }

            public Node(T content, Node<T> parent)
            {
                Content = content;
                SetParent(parent);
            }

            public Node(Node<T> content, List<Node<T>> children)
            {
                SetParent(content);
                foreach (var child in children)
                {
                    AddChild(child);
                }
            }

            public Node<T> Parent
            {
                get
                {
                    return GetParent();
                }
                set
                {
                    SetParent(this);
                }
            }

            public T Content
            {
                get
                {
                    return _content;
                }
                set
                {
                    _content = value;
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
                    return GetLevel();
                }
            }

            private Node<T> Root
            {
                get
                {
                    return GetRoot();
                }
            }

            public Node<T> GetParent()
            {
                if (_parent == null)
                    return null;

                Node<T> parent;
                if (_parent.TryGetTarget(out parent))
                {
                    return parent;
                }
                return null;
            }

            public void SetParent(Node<T> parent)
            {
                if (parent == null || parent == this || parent == GetParent())
                {
                    _parent = null;
                }
                else
                {
                    Unlink();
                    var newparent = new WeakReference<Node<T>>(parent);
                    _parent = newparent;
                }
            }


            public int IndexOf(Node<T> node)
            {
                for (int i = 0; i < _children.Count; i++)
                {
                    if (_children[i] == node)
                    {
                        return i;
                    }
                }
                return -1;
            }

            private void RemoveChild(Node<T> node)
            {
                int index = IndexOf(node);
                if (index != -1 && index < _children.Count)
                {
                    _children.RemoveAt(index);
                }
                return;
            }
            public int GetLevel()
            {
                if (_parent == null)
                    return 0;
                return Parent.GetLevel() + 1;
            }

            public Node<T> GetRoot()
            {
                if (_parent == null)
                    return this;
                return Parent.GetRoot();
            }

            public Node<T>? GetChildAt(int index)
            {
                if (index < 0 || index >= _children.Count)
                    return null;
                return _children[index];
            }

            public void Unlink()
            {
                if (Parent != null)
                    Parent.RemoveChild(this);
                Parent = null;
            }

            private void Unlink1()
            {
                if (Parent != null)
                {
                    Parent.RemoveChild(this);
                    Parent = null;
                }
            }

            public void AddChild(Node<T> child)
            {
                if (child == null || child == this)
                    return;
                child.Unlink();
                child.Parent = this;
                _children.Add(child);
            }

            //public void RemoveChild(Node<T> node)
            //{
            //    int index = IndexOf(node);
            //    if (index != -1 && index < _children.Count)
            //        _children.RemoveAt(index);
            //    return;
            //}

            //public int IndexOf(Node<T> node)
            //{

            //}

            //public void SetParent(Node<T> node)
            //{
            //    if (node == null)
            //        Unlink();
            //    else
            //        node.AddChild(this);
            //}

            public bool HasSibling()
            {
                if (_parent != null)
                    return Parent._children.Count > 0;
                return false;
            }

            public bool ContainsAncestor(Node<T> node)
            {
                var _parent = GetParent();
                if (node == null || _parent == null)
                    return false;
                if (_parent == node)
                    return true;

                //var child = _children[i];

                return _parent.ContainsAncestor(node);
            }

            public bool ContainsDescendant(Node<T> node)
            {
                //comprobar sea null
                if (node == null)
                    return false;
                for (int i = 0; i < _children.Count; i++)
                {
                    var child = _children[i];
                    if (child.Equals(node))
                        return true;
                    if (_children[i].ContainsDescendant(node))
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

            public delegate bool CheckDelegate<T>(Node<T> node);

            public Node<T>? FindNode(CheckDelegate<T> checker)
            {
                if (checker == null)
                    return null;

                if (checker(this))
                    return this;

                for (int i = 0; i < _children.Count; i++)
                {
                    var child = _children[i];
                    var nodeSearched = child.FindNode(checker);
                    if (nodeSearched != null)
                        return nodeSearched;
                }
                return null;
            }


            public delegate bool CheckDelegateNode<T>(T element);

            private List<Node<T>> FindNode(CheckDelegateNode<T> checker/* List<Node<T>> list*/)
            {
                var result = new List<Node<T>>();

                if (checker == null)
                    return result;

                if (checker(_content))
                {
                    result.Add(this);
                }

                for (int i = 0; i < _children.Count; i++)
                {
                    var child = _children[i];
                    var node = child.FindNode(checker);
                    if (node != null)
                        return node;
                }
                return result;

                //result.FindNode(checker, result)
                //FindNodes(this, checker, result);
                //return;
            }

            private void FindNodes(Node<T> node, CheckDelegateNode<T> checker, List<Node<T>> result)
            {
                if (checker(node._content))
                {
                    result.Add(node);
                }

                for (int i = 0; i < node._children.Count; i++)
                {
                    FindNodes(node._children[i], checker, result);
                }
            }

            public List<Node<T>>? Filter(CheckDelegateNode<T> checker)
            {
                var result = new List<Node<T>>();
                if (checker == null)
                    return result;
                if (checker(_content))
                {
                    result.Add(this);
                }
                for (int i = 0; i < _children.Count; i++)
                {
                    var child = _children[i];
                    var node = child.Filter(checker);

                    foreach (var childNode in node)
                    {
                        result.Add(childNode);
                    }
                    //if (node != null)
                    //    result.Add(child);

                    //puedo comprobar el contenido tambien con el checker this con la otra lambda
                }

                //FindNodes(this, checker, result);
                return result;
            }

            #region codigoviejo
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


            //Memory Leak cuando las referencias de fuera desaparecen y se crea unas referencias de objetos circular
            //existen referencias weak y strong, las strong son las hechas hasta ahora, las weak son referencias que no cuentan para el reference count.
            //el padre es el que tiene que ser weak, si no se produce la destruccion de la referencia pero el objeto queda en memoria
            //class Node<T>
            //{
            //Node<T> _parent;
            //WeakReference<Node<T>> _parent;
            //}

            //para trabajar con una weak reference primero la pasas a strong, trabajas con la variable y luego sera lo que tenga que ser con la weak;


            //foreach(var node in children)
            //{
            //AddChild(node);
            //}
            //para indexof es indispensable usar el for, el foreach se puede usar en otros casos

            //hacer un override tostring
            #endregion

            //para hacer weakreference tengo que hacer funcion getparent y cambiar el setparent
        }
    }
}
