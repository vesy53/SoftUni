namespace p06._02.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class BookLibraryModification2
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<Book> books = ReadBooks(num);

            DateTime inputDate = DateTime
                .ParseExact(
                    Console.ReadLine(),
                    "dd.MM.yyyy",
                    CultureInfo
                    .InvariantCulture);

            books = books
                .Where(x => x.ReleaseDate > inputDate)
                .OrderBy(x => x.ReleaseDate)
                .ThenBy(x => x.Title)
                .ToList();

            foreach (Book book in books)
            {
                string title = book.Title;
                DateTime releaseDate = book.ReleaseDate;

                Console.WriteLine(
                    $"{title} -> {releaseDate.ToString("dd.MM.yyyy")}");
            }
        }

        private static List<Book> ReadBooks(int num)
        {
            List<Book> books = new List<Book>();

            for (int i = 0; i < num; i++)
            {
                string[] currentInput = Console.ReadLine()
                    .Split();

                string title = currentInput[0];
                string author = currentInput[1];
                string publisher = currentInput[2];
                DateTime releaseDate = DateTime
                    .ParseExact(
                        currentInput[3],
                        "dd.MM.yyyy",
                        CultureInfo
                        .InvariantCulture);
                string numIBNS = currentInput[4];
                double price = double.Parse(currentInput[5]);

                Book currrentBook = new Book
                (
                    title,
                    author,
                    publisher,
                    releaseDate,
                    numIBNS,
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

        public DateTime ReleaseDate { get; set; }

        public string NumberISBN { get; set; }

        public double Price { get; set; }

        public Book(
            string title,
            string author,
            string publisher,
            DateTime releaseDate,
            string isbnNumber,
            double price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.NumberISBN = isbnNumber;
            this.Price = price;
        }
    }
}
