namespace p06._01.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class BookLibraryModification
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Library myLibrary = new Library
            (
                "MyPersonalLibrary",
                new List<Book>()
            );

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
                string numISBN = currentInput[4];
                decimal price = decimal.Parse(currentInput[5]);

                Book currrentBook = new Book
               (
                 title,
                 author,
                 publisher,
                 releaseDate,
                 numISBN,
                 price
               );

                myLibrary.Books.Add(currrentBook);
            }

            DateTime inputDate = DateTime
                .ParseExact(
                    Console.ReadLine(),
                    "dd.MM.yyyy",
                    CultureInfo
                    .InstalledUICulture);

            var booksData = new Dictionary<string, DateTime>();

            foreach (var book in myLibrary.Books)
            {
                string title = book.Title;
                DateTime releaseDate = book.ReleaseDate;

                if (!booksData.ContainsKey(title))
                {
                    booksData.Add(title, new DateTime(0001, 01, 01));
                }

                booksData[title] = releaseDate;
            }

            booksData = booksData
                .Where(x => x.Value > inputDate)
                .OrderBy(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var book in booksData)
            {
                string title = book.Key;
                DateTime releaseDate = book.Value;

                Console.WriteLine(
                    $"{title} -> {releaseDate.ToString("dd.MM.yyyy")}");
            }
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

        public decimal Price { get; set; }

        public Book(
            string title,
            string author, 
            string publisher,
            DateTime releaseDate,
            string numISBN,
            decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.NumberISBN = numISBN;
            this.Price = price;
        }
    }
}
