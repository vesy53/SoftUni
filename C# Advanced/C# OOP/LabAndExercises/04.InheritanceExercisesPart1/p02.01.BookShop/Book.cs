namespace p02._01.BookShop
{
    using System;
    using System.Text;

    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public string Author
        {
            get
            {
                return this.author;
            }

            set
            {
                ValidateAuthor(value);

                this.author = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                ValidateTitle(value);

                this.title = value;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                ValidatePrice(value);

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:F2}");

            return builder.ToString().TrimEnd();
        }

        private void ValidateAuthor(string value)
        {
            string[] names = value
                .Split(" ");

            if (names.Length > 1)
            {
                string lastName = names[1];
                char firstSymbol = lastName[0];

                if (char.IsDigit(firstSymbol))
                {
                    throw new ArgumentException(
                        "Author not valid!");
                }
            }
        }

        private static void ValidateTitle(string value)
        {
            if (value.Length < 3)
            {
                throw new ArgumentException(
                    "Title not valid!");
            }
        }

        private static void ValidatePrice(decimal value)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    "Price not valid!");
            }
        }
    }
}
