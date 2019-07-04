namespace p02._01.BookShop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price) 
            : base(author, title, price)
        {
        }

        public override decimal Price
        {
            get
            {
                return base.Price;
            }

            set
            {
                base.Price = value * 1.3M; 
            }
        }
    }
}
