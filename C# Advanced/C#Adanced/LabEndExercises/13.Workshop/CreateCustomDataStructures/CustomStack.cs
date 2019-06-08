namespace CreateCustomDataStructures
{
    using System;

    public class CustomStack
    {
        private const int InitialCapacity = 4;
        private const int InitialCount = 0;

        private int[] array;
        private int count;

        public CustomStack()
        {
            this.array = new int[InitialCapacity];
            this.count = InitialCount;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Push(int element)
        {
            if (this.array.Length == this.count)
            {
                int[] nextArray = new int[this.array.Length * 2];

                for (int i = 0; i < this.array.Length; i++)
                {
                    nextArray[i] = this.array[i];
                }

                this.array = nextArray;
            }

            this.array[this.count] = element;
            this.count++;
        }

        public int Pop()
        {
            ValidateArrayLength();

            int lastIndex = this.count - 1;
            int lastElement = this.array[lastIndex];
            this.count--;

            return lastElement;
        }

        public int Peek()
        {
            ValidateArrayLength();

            int lastIndex = this.count - 1;
            int lastElement = this.array[lastIndex];

            return lastElement;
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < this.count; i++)
            {
                action(this.array[i]);
            }
        }

        private void ValidateArrayLength()
        {
            if (this.array.Length == 0)
            {
                throw new InvalidOperationException(
                    "CustomStack is empty");
            }
        }
    }
}
