namespace p10._01.BookLibraryModification
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Globalization;
    using System.Collections.Generic;

    class BookLibraryModification
    {
        static void Main(string[] args)
        {
            int booksCount = int.Parse(Console.ReadLine());
            List<Book> books = ReadBooks(booksCount);

            string dateAsStr = Console.ReadLine();
            DateTime date = DateTime
                .ParseExact(
                    dateAsStr, 
                    "dd.MM.yyyy",
                    CultureInfo
                    .InvariantCulture);

            books = books
                .Where(x => x.ReleaseDate > date)
                .OrderBy(x => x.ReleaseDate)
                .ThenBy(x => x.Title)
                .ToList();

            File.WriteAllText("output.txt", string.Empty);

            foreach (var book in books)
            {
                string title = book.Title;
                DateTime releaseDate = book.ReleaseDate;

                File.AppendAllText
                (
                    "output.txt",
                    $"{title} -> {releaseDate.ToString("dd.MM.yyyy")}" +
                    $"{Environment.NewLine}"
                );
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
                DateTime releaseDate = DateTime
                    .ParseExact(
                        booksArgs[3],
                        "dd.MM.yyyy", 
                        CultureInfo
                        .InvariantCulture);
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

    class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string ISBNNumber { get; set; }

        public decimal Price { get; set; }

        public Book(
            string title,
            string author,
            string publisher,
            DateTime releaseDate,
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
