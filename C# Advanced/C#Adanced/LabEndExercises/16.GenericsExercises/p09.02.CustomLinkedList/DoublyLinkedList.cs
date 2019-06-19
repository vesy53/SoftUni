namespace p09._02.CustomLinkedList
{
    using System;
    using System.Collections.Generic;

    public class DoublyLinkedList<T>
        where T : IComparable<T>
    {
        private class ListNode
        {
            public ListNode(T value)
            {
                this.Value = value;
            }

            public T Value { get; }

            public ListNode NextNode { get; set; }

            public ListNode PreviousNode { get; set; }
        }

        private ListNode head;
        private ListNode tail;

        public int Count { get; private set; }

        public void AddFirst(T element)
        {
            ListNode newHead = new ListNode(element);

            if (this.Count == 0)
            {
                this.head = this.tail = newHead;
            }
            else
            {
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }

            this.Count++;
        }

        public void AddLast(T element)
        {
            ListNode newTail = new ListNode(element);

            if (this.Count == 0)
            {
                this.head = this.tail = newTail;
            }
            else
            {
                newTail.PreviousNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public T RemoveFirst()
        {
            ValidateCount();

            T firstElement = this.head.Value;
            this.head = this.head.NextNode;

            if (this.head != null)
            {
                this.head.PreviousNode = null;
            }
            else
            {
                this.tail = null;
            }

            this.Count--;

            return firstElement;
        }

        public T RemoveLast()
        {
            ValidateCount();

            T lastElement = this.tail.Value;
            this.tail = this.tail.PreviousNode;

            if (this.tail != null)
            {
                this.tail.NextNode = null;
            }
            else
            {
                this.head = null;
            }

            this.Count--;

            return lastElement;
        }

        public T[] ToArray()
        {
            T[] array = new T[this.Count];
            int counter = 0;

            ListNode currentNode = this.head;

            while (currentNode != null)
            {
                array[counter++] = currentNode.Value;

                currentNode = currentNode.NextNode;
            }

            return array;
        }

        public void ForEach(Action<T> action)
        {
            ListNode currentNode = this.head;

            while (currentNode != null)
            {
                action(currentNode.Value);

                currentNode = currentNode.NextNode;
            }
        }

        public List<T> ToList()
        {
            List<T> list = new List<T>();

            var currentNode = this.head;

            while (currentNode != null)
            {
                list.Add(currentNode.Value);

                currentNode = currentNode.NextNode;
            }

            return list;
        }

        public bool Contains(T value)
        {
            ListNode currentNode = this.head;

            while (currentNode != null)
            {
                if (currentNode.Value.CompareTo(value) == 0)
                {
                    return true;
                }

                currentNode = currentNode.NextNode;
            }

            return false;
        }

        private void ValidateCount()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException(
                    "The list is empty");
            }
        }
    }
}
