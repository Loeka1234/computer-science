using System;

namespace AlgorithmsAndDataStructures.LinkedList
{
    /// <summary>
    ///     Has the logic to connect the node objects to create the linked list structure
    /// </summary>
    public class SimpleLinkedList<T>
    {
        // start node of the linked list chain
        private Node<T> _head;
        private Node<T> _tail;

        public void AddLast(T data)
        {
            var newItem = new Node<T>
            {
                Data = data
            };
            if (_head == null)
            {
                _head = _tail = newItem;
            }
            else
            {
                _tail.Next = newItem;
                _tail = newItem;
            }
        }

        public void AddFirst(T data)
        {
            var newItem = new Node<T>
            {
                Data = data
            };
            if (_head == null)
            {
                _head = newItem;
                _tail = newItem;
            }
            else
            {
                newItem.Next = _head;
                _head = newItem;
            }
        }

        public void ReadAll()
        {
            if (_head == null) return;

            var current = _head;
            Console.WriteLine(current.Data);
            while (current.Next != null)
            {
                current = current.Next;
                Console.WriteLine(current.Data);
            }
        }
    }
}