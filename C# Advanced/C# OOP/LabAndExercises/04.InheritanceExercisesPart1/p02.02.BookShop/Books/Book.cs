namespace p02._02.BookShop.Books
{
    using p02._02.BookShop.Core;
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
                Validation.ValidateAuthor(value);

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
                Validation.ValidateTitle(value);

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
                Validation.ValidatePrice(value);

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
    }
}
