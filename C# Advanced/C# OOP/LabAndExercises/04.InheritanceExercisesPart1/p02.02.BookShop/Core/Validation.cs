namespace p02._02.BookShop.Core
{
    using System;

    public static class Validation
    {
        public static void ValidateAuthor(string value)
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

        public static void ValidateTitle(string value)
        {
            if (value.Length < 3)
            {
                throw new ArgumentException(
                    "Title not valid!");
            }
        }

        public static void ValidatePrice(decimal value)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    "Price not valid!");
            }
        }
    }
}
