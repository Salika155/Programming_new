using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraTree
{
    public class ArbolMio<T>
    {
        public class Nodo<T>
        {
            private T _content;
            private List<Nodo<T>> _children = new List<Nodo<T>>();
            WeakReference<Nodo<T>> _parent;

            public Nodo(T content)
            {
                _content = content;
            }

            public Nodo(T content, Nodo<T> parent)
            {
                _content = content;
                SetParent(parent);
                
            }

            public Nodo(T content, Nodo<T> parent, List<Nodo<T>> children)
            {

            }

            public Nodo<T>? Parent
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

            public bool IsEmpty
            {
                get
                {
                    return _content == null;
                }
            }


            public Nodo<T>? GetParent()
            {
                if (_parent == null)
                    return null;

                Nodo<T> parent;
                if (_parent.TryGetTarget(out parent))
                {
                    return parent;
                }
                return null;
            }

            public int GetLevel()
            {
                if (Parent == null)
                    return 0;
                return Parent.GetLevel() + 1;
            }

            public int IndexOf(Nodo<T> index)
            {
                if (index == null)
                    return -1;

                for (int i = 0; i < _children.Count; i++)
                {
                    if (_children[i] == index)
                        return i;
                }
                return -1;
            }

            public void RemoveChild(Nodo<T> child)
            {
                int index = IndexOf(child);
                if (index != -1 && index < ChildCount)
                {
                    _children.RemoveAt(index);
                }
                return;
            }

            public Nodo<T> GetRoot()
            {
                if (_parent == null)
                    return this;
                return Parent.GetRoot();

            }

            public Nodo<T>? GetChildAt(int index)
            {
                if (index < 0 || index >= _children.Count)
                    return null;
                return _children[index];
            }

            private void SetParent(ArbolMio<T>.Nodo<T> nodo)
            {
                throw new NotImplementedException();
            }

            public void UnLink()
            {
                if (Parent != null)
                {
                    Parent.RemoveChild(this);

                }
                Parent = null;
            }

            public void AddChild(Nodo<T> child)
            {
                if (child == null || child == this)
                    return;
                child.UnLink();
                child.Parent = this;
                _children.Add(child);
            }

            public bool HasSibling(Nodo<T> sibiling)
            {
                if (_parent != null)
                    return Parent.ChildCount > 0;
                return false;
            }

            public bool ContainsAncestor(Nodo<T> ancestor)
            {
                var parent = GetParent();
                if (ancestor == null || parent == null)
                    return false;
                if (parent == ancestor)
                    return true;
                return parent.ContainsAncestor(ancestor);
            }

            public bool ContainsDescendant(Nodo<T> descendant)
            {
                if (descendant == null)
                    return false;

                for(int i = 0; i < _children.Count; i++)
                {
                    var child = _children[i];
                    if (child.Equals(descendant) || child.ContainsDescendant(descendant))
                        return true;
                }
                return false;
            }
        }
    }
}
