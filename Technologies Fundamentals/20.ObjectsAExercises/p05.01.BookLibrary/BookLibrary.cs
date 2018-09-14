namespace p05._01.BookLibrary
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class BookLibrary
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<Book> books = new List<Book>();

            for (int i = 0; i < num; i++)
            {
                string[] currentInput = Console.ReadLine()
                    .Split();

                string title = currentInput[0];
                string author = currentInput[1];
                string publisher = currentInput[2];
                string releaseDate = currentInput[3];
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

            var booksPrice = new Dictionary<string, double>();

            Library library = new Library("MyPersonalLibrary", books);

            foreach (Book book in books)
            {
                string author = book.Author;
                double price = book.Price;

                if (!booksPrice.ContainsKey(author))
                {
                    booksPrice.Add(author, 0);
                }

                booksPrice[author] += price;
            }

            booksPrice = booksPrice
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var bookPrice in booksPrice)
            {
                string author = bookPrice.Key;
                double price = bookPrice.Value;

                Console.WriteLine($"{author} -> {price:F2}");
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

        public string ReleaseDate { get; set; }

        public string NumberISBN { get; set; }

        public double Price { get; set; }

        public Book(
            string title, 
            string author, 
            string publisher, 
            string releaseDate, 
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
