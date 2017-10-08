using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class Node<T>
    {
        private T _value;
        private Node<T> _prev;
        private Node<T> _next;

        public Node(T value)
        {
            _value = value;
        }
        public T Value
        {
            get { return _value; }
        }
        public Node<T> Prev 
        { 
            get { return _prev; }
            set { _prev = value; }
        }
        public Node<T> Next
        {
            get { return _next; }
            set { _next = value; }
        }
    }
    class DoubleLinkedList<T> : IEnumerable<T>
    {
        private int _count;
        private Node<T> _first;
        private Node<T> _current;
        private Node<T> _last;
        public DoubleLinkedList()
        {
            _first = _current = _last = null;
        }
        public int Count
        {
            get { return _count; }
        }
        public Node<T> First
        {
            get { return _first; }
            set { _first = value; }
        }
        public Node<T> Current
        {
            get { return _current; }
            set { _current = value; }
        }
        public Node<T> Last
        {
            get { return _last; }
            set { _last = value; }
        }
        public void PushFront(T value)
        {
            if (value != null)
            {
                Node<T> newNode = new Node<T>(value);
                if (_first == null)
                {
                    _first = newNode;
                    _last = newNode;
                }
                else
                {

                }
                _count++;
            }
            else throw new ArgumentNullException();
        }
        public void PushBack(T value)
        {
            if (value != null)
            {
                Node<T> newNode = new Node<T>(value);
                if (_first == null)
                {
                    _first = newNode;
                    _last = newNode;
                }
                else
                {
                    _last.Next = newNode;
                    newNode.Prev = _last;
                    _last = newNode;
                }
                _count++;
            }
            else throw new ArgumentNullException();
        }

        public class Enumerator : IEnumerator<T>
        {
            private DoubleLinkedList<T> _list;
            int i = -1;

            public Enumerator(DoubleLinkedList<T> list)
            {
                _list = list;
            }

            public T Current
            {
                get { return _list.Current.Value; }
            }

            public bool MoveNext()
            {
                i++;
                _list.Current = _list.Current.Next;
                return i >= _list.Count ? false : true;
            }

            public void Reset()
            {
                i = -1;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(this);
        }
    }
}
