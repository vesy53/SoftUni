namespace p01._01.Library
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.Books = new List<Book>(books);
        }

        public List<Book> Books { get; set; }

        public IEnumerator<Book> GetEnumerator()
        {
            return this.Books
                .Select((t, i) => Books[i])
                .GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
