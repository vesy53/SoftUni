﻿namespace p03._01.ComparableBook
{
    using System.Collections;
    using System.Collections.Generic;

    public class Library : IEnumerable<Book>
    {

        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
            this.books.Sort();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;

            public LibraryIterator(List<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }

            public Book Current => this.books[this.currentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                return ++this.currentIndex < this.books.Count;
            }

            public void Reset()
            {
                this.currentIndex = -1;
            }
        }
    }
}