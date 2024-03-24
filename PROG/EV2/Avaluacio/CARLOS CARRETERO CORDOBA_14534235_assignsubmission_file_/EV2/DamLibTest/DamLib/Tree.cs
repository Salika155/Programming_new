using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DamLib
{
    public class Tree <T>
    {
        public class Node<T>
        {
            private T _content;
            private List<Node<T>> _children = new List<Node<T>>();
            private Node<T>? _parent;
            // Javi: NO!! Esto no es un atributo
            private Node<T>? _root;
            //WeakReference<Node<T>> _parentWeak;

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
                    // Javi: Muy bien
                    if (_parent != null)
                    {
                        _parent.RemoveChild(this);
                    }
                    _parent = value;

                    if (_parent != null)
                    {
                        _parent._children.Add(this);
                    }
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
                    // Javi: Por que no llamas a la funcion que tienes abajo??
                    if (_parent == null)
                        return 0;
                    return _parent.Level + 1;
                }
            }

            private Node<T> Root
            {
                get
                {
                    // Javi: Por que no llamas a la funcion que tienes abajo??
                    if (_parent == null)
                        return this;
                    return _parent.Root;
                }
            }

            // Javi: Mejor, IndexOfChild
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
                if (index != -1)
                {
                    _children.RemoveAt(index);
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
                    _parent.RemoveChild(this);
                _parent = null;
            }
            
            //private void Unlink1()
            //{
            //    if (_parent != null)
            //    {
            //        _parent.RemoveChild(this);
            //        _parent = null;
            //    }
            //}

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
            //    if (index >= 0)

            //        _children.RemoveAt(index);
            //}

            //public int IndexOf(Node<T> node)
            //{

            //}

            public void SetParent(Node<T> node)
            {
                if (node == null)
                    Unlink();
                else
                    node.AddChild(this);
            }

            public bool HasSibling()
            {
                if (_parent != null)
                    return _parent._children.Count > 0; // Javi: 1
                return false;
            }

            public bool ContainsAncestor(Node<T> node)
            {
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
                    if (_children[i] == node)
                        return true;
                    if (_children[i].ContainsDescendant(node))
                        return true;
                }
                return false;
            }

            // Javi: Pon esto arriba del todo
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

            // Javi: Arriba del todo
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

                    // Javi: Mal
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
        }
    }
}

//para hacer weakreference tengo que hacer funcion getparent y cambiar el setparent
