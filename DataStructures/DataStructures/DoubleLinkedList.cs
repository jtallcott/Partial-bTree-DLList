using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewTest
{
    public class DoubleLinkedList<T>
    {
        private class DoubleLinkedListNode<T>
        {
            public T Value = default(T);
            public DoubleLinkedListNode<T> Prev = null;
            public DoubleLinkedListNode<T> Next = null;
            
            public DoubleLinkedListNode(T v)
            {
                Value = v;
            }
        }

        private DoubleLinkedListNode<T> _first = null;
        private DoubleLinkedListNode<T> _last = null;
    
        public void InsertAtEnd(T newValue)
        {
            if (_first == null) //Empty List
            {
                _first = new DoubleLinkedListNode<T>(newValue);
                _last = _first;
                return;
            }
            else 
            {
                _last.Next = new DoubleLinkedListNode<T>(newValue);
                _last.Next.Prev = _last;
                _last = _last.Next;
            }
        }

        public T RemoveFirst()
        {
            if(_first == null) //Nothing in the list, return null or 0.
                return default(T);

            var value = _first.Value;

            if (_first == _last) //Exactly one item in list, remove it.
            {
                _first = null;
                _last = null;
            }
            else
            {
                _first.Next.Prev = null;
                _first = _first.Next;
            }
            
            return value;
        }
    }
}
