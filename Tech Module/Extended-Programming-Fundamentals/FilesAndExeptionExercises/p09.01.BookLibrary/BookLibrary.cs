namespace p09._01.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class BookLibrary
    {
        static void Main(string[] args)
        {
            var booksCount = int.Parse(Console.ReadLine());

            var books = new List<Book>();

            books = ReadBooks(booksCount);

            var booksPrice = new Dictionary<string, decimal>();

            Library library = new Library("DefaultLibrary", books);

            TakeBooksPrice(library.Books, booksPrice);

            booksPrice = booksPrice
                 .OrderByDescending(x => x.Value)
                 .ThenBy(x => x.Key)
                 .ToDictionary(x => x.Key, x => x.Value);

            File.WriteAllText("output.txt", string.Empty);

            foreach (var book in booksPrice)
            {
                string author = book.Key;
                decimal price = book.Value;

                File.AppendAllText
                (
                    "output.txt",
                    $"{author} -> {price:F2}" +
                    $"{Environment.NewLine}"
                );
            }
        }

        static void TakeBooksPrice(
            List<Book> books,
            Dictionary<string, decimal> booksPrice)
        {
            foreach (var book in books)
            {
                string author = book.Author;
                decimal price = book.Price;

                if (!booksPrice.ContainsKey(author))
                {
                    booksPrice.Add(author, 0.0m);
                }

                booksPrice[author] += price;
            }
        }

        static List<Book> ReadBooks(int booksCount)
        {
            List<Book> books = new List<Book>();

            for (int i = 0; i < booksCount; i++)
            {
                string[] booksArgs = Console.ReadLine()
                    .Split()
                    .ToArray();
                string title = booksArgs[0];
                string author = booksArgs[1];
                string publisher = booksArgs[2];
                string releaseDate = booksArgs[3];
                string isbnNumber = booksArgs[4];
                decimal price = decimal.Parse(booksArgs[5]);

                Book currrentBook = new Book
                (
                    title,
                    author,
                    publisher,
                    releaseDate,
                    isbnNumber, 
                    price
                );

                books.Add(currrentBook);
            }

            return books;
        }
    }

    class Library
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }

        public Library(string name, List<Book> books)
        {
            this.Name = name;
            this.Books = books;
        }

    }

    class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public string ReleaseDate { get; set; }

        public string ISBNNumber { get; set; }

        public decimal Price { get; set; }

        public Book(
            string title,
            string author,
            string publisher, 
            string releaseDate,
            string isbnNumber,
            decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.ISBNNumber = isbnNumber;
            this.Price = price;
        }
    }
}
