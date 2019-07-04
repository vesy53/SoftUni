namespace p05._01.StackOfStrings
{
    using System;
    using System.Collections.Generic;

    public class StackOfStrings : List<string>
    {
        private List<string> list;

        public StackOfStrings()
        {
            this.list = new List<string>();
        }

        public int Count => this.list.Count;

        public void Push(string element)
        {
            this.list.Add(element);
        }

        public bool IsEmpty()
        {
            return this.list.Count == 0;
        }

        public string Pop()
        {
            VerificateStak();

            int index = list.Count - 1;
            string result = list[index];
            list.Remove(result);

            return result;
        }

        public string Peek()
        {
            VerificateStak();

            int index = list.Count - 1;
            string result = list[index];

            return result;
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
