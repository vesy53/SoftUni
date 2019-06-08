namespace p02._02.Collection
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
            // Enumerator implementation
            return new ListyIteratorEnumerator(this.collections);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class ListyIteratorEnumerator : IEnumerator<T>
        {
            private IList<T> collections;
            private int currentIndex;

            public ListyIteratorEnumerator(IList<T> collections)
            {
                this.Reset();
                this.collections = collections;
            }

            public T Current => this.collections[this.currentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            { }

            public bool MoveNext()
            {
                if (++this.currentIndex < this.collections.Count)
                {
                    return true;
                }

                return false;
            }

            public void Reset()
            {
                this.currentIndex = -1;
            }
        }
    }
}
