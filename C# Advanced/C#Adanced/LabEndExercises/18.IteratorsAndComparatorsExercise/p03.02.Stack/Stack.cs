namespace p03._02.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IEnumerable<T>
    {
        private const int DefaultCapacity = 4;

        private T[] stack;
        private int length;

        public Stack()
        {
            this.stack = new T[DefaultCapacity];
            this.length = 0;
        }

        public void Push(T element)
        {
            if (this.length == this.stack.Length)
            {
                int cloningLength = this.stack.Length * 2;
                T[] cloningArr = new T[cloningLength];

                for (int i = 0; i < this.stack.Length; i++)
                {
                    cloningArr[i] = this.stack[i];
                }

                this.stack = cloningArr;
            }

            this.stack[this.length] = element;
            this.length++;
        }

        public void Pop()
        {
            if (this.length == 0)
            {
                throw new ArgumentException("No elements");
            }

            this.length--;
            var lastElement = this.stack[this.length];
            this.stack[this.length] = default(T); // emptyIndex = null
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.stack.Length - 1; i >= 0; i--)
            {
                yield return this.stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();   
        }
    }
}
