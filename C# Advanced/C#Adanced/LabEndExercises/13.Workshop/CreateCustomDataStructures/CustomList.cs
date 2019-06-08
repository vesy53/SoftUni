namespace CreateCustomDataStructures
{
    using System;

    public class CustomList
    {
        private const int InitialCapacity = 2;

        private int[] array;

        public CustomList()
        {
            this.array = new int[InitialCapacity];
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                ValidateIndex(index);

                return array[index];
            }

            set
            {
                ValidateIndex(index);

                array[index] = value;
            }
        }

        public void Add(int element)
        {
            if (this.Count == this.array.Length)
            {
                this.Resize();
            }

            this.array[this.Count] = element;
            this.Count++;
        }

        public int RemoveAt(int index)
        {
            ValidateIndex(index);

            int element = this.array[index];
            this.array[index] = default(int);
            this.Shift(index);

            this.Count--;

            if (this.Count <= this.array.Length / 4)
            {
                this.Shrink();
            }

            return element;
        }

        public void Insert(int index, int element)
        {
            ValidateIfIndexIsOutOfRange(index);

            if (this.Count == this.array.Length)
            {
                this.Resize();
            }

            this.ShiftToRight(index);

            this.array[index] = element;
            this.Count++;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (element.Equals(this.array[i]))

                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            ValidateBothIndexes(firstIndex, secondIndex);

            int temp = this.array[firstIndex];
            this.array[firstIndex] = this.array[secondIndex];
            this.array[secondIndex] = temp;
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                action(this.array[i]);
            }
        }

        private void ShiftToRight(int index)
        {
            for (int i = Count; i < index; i--)
            {
                this.array[i] = this.array[i - 1];
            }
        }

        private void Shrink()
        {
            int[] copyArray = new int[this.array.Length / 2];

            for (int i = 0; i < this.Count; i++)
            {
                copyArray[i] = this.array[i];
            }

            this.array = copyArray;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
        }

        private void Resize()
        {
            int[] copyArray = new int[this.array.Length * 2];

            for (int i = 0; i < this.array.Length; i++)
            {
                copyArray[i] = this.array[i];
            }

            this.array = copyArray;
        }

        private void ValidateBothIndexes(
            int firstIndex,
            int secondIndex)
        {
            if (firstIndex < 0 ||
                secondIndex < 0 ||
                firstIndex >= this.Count ||
                secondIndex >= this.Count)
            {
                throw new IndexOutOfRangeException(
                    "Invalid index!!!");
            }
        }

        private void ValidateIfIndexIsOutOfRange(int index)
        {
            if (index > this.Count)
            {
                throw new IndexOutOfRangeException();
            }
        }

        private void ValidateIndex(int index)
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
