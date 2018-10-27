namespace p05._02.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class BookLibrary2
    {
        static void Main(string[] args)
        {
            Library library = CreateLibrary();
            PrintPricesByAuthor(library);
        }

        static void PrintPricesByAuthor(Library library)
        {
            var booksData = new Dictionary<string, decimal>();

            foreach (var book in library.Books)
            {
                string author = book.Author;
                decimal price = book.Price;

                if (!booksData.ContainsKey(author))
                {
                    booksData.Add(author, 0);
                }

                booksData[author] += price;
            }

            booksData = booksData
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var bookPrice in booksData)
            {
                string author = bookPrice.Key;
                decimal price = bookPrice.Value;

                Console.WriteLine($"{author} -> {price:F2}");
            }
        }

        static Library CreateLibrary()
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

            return myLibrary;
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
