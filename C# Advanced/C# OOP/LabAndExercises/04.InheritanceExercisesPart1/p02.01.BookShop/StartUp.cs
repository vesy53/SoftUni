namespace p02._01.BookShop
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                string author = Console.ReadLine();    
                string title = Console.ReadLine();
                decimal price = decimal.Parse(Console.ReadLine());

                Book book = new Book(author, title, price);

                GoldenEditionBook goldenBook = new GoldenEditionBook(author, title, price);

                Console.WriteLine(book + Environment.NewLine);
                Console.WriteLine(goldenBook);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
