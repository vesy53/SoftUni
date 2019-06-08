namespace p02._01.Collection
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ListyIterator<T> : IEnumerable<T>
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
            bool hasNext = this.HasNext();

            if (hasNext)
            {
                this.internalIndex++;

                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.internalIndex < this.collections.Count - 1)
           // if (this.internalIndex + 1 < this.collections.Count)
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

        public IEnumerator<T> GetEnumerator()
        {
            // simple method

            for (int i = 0; i < this.collections.Count; i++)
            {
                yield return this.collections[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
