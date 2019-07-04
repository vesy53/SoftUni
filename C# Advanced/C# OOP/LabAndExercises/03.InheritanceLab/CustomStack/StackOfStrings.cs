namespace CustomStack
{
    using System;
    using System.Collections.Generic;

    public class StackOfStrings : Stack<string>
    {
        private Stack<string> stack;

        public StackOfStrings()
        {
            this.stack = new Stack<string>();
        }

        public int Count => this.stack.Count;

        public void PushElement(string element)
        {
            this.stack.Push(element);
        }

        public bool IsEmpty()
        {
            return this.stack.Count == 0;
        }

        public string PopElement()
        {
            VerificateStak();

            string element = stack.Peek();
            stack.Pop();

            return element;
        }

        public string PeekElement()
        {
            VerificateStak();

            string element = stack.Peek();

            return element;
        }

        private void VerificateStak()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("Stack is empty");
            }
        }
    }
}
