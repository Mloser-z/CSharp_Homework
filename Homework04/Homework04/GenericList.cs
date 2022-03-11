using System;

namespace Homework04
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            head = tail = null;
        }

        public Node<T> Head
        {
            get => head;
        }
        
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public static void ForEach(GenericList<T> list, Action<T> action)
        {
            if (list.tail != null)
            {
                Node<T> p = list.head;
                while (p != null)
                {
                    action(p.Data);
                    p = p.Next;
                }
            }
        }
    }
}