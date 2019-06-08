namespace p01._01.ListyIterator
{
    using System;
    using System.Collections.Generic;

    public class ListyIterator<T>
    {
        private IList<T> collections;
        private int internalIndex;

        public ListyIterator(params T[] collections)
        {
            this.Reset();
            this.collections = new List<T>(collections);
        }

        public bool Move()
        {
            if (this.internalIndex < this.collections.Count - 1)
            {
                this.internalIndex++;

                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            // if (this.internalIndex < this.collections.Count - 1)
            if (this.internalIndex + 1 < this.collections.Count)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (collections.Count == 0)
            {
                throw new InvalidOperationException(
                    "Invalid Operation!");
            }

            Console.WriteLine(
                this.collections[this.internalIndex]);
        }

        public void Reset()
        {
            this.internalIndex = 0;
        }
    }
}
