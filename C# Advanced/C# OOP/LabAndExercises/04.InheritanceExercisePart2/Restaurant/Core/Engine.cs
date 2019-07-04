namespace Restaurant.Core
{
    using System;
    using System.Collections.Generic;

    using Restaurant.Products;
    using Restaurant.Products.Beverages.ColdBeverages;
    using Restaurant.Products.Beverages.HotBeverages;
    using Restaurant.Products.Foods.Desserts;
    using Restaurant.Products.Foods.MainDishes;
    using Restaurant.Products.Foods.Starters;

    public class Engine
    {
        public void Run()
        {
            List<Product> products = new List<Product>();

            ColdBeverage coldBeverage = new ColdBeverage("Coka-Cola", 1.20M, 0.750);

            Coffee coffee = new Coffee("Expreso", 500);
            Tea tea = new Tea("Black", 0.90M, 200);

            Cake cake = new Cake("Choco");
            Soup soup = new Soup("Chicken", 2.20M, 200);
            Fish fish = new Fish("Hake", 3.60M);

            products.Add(coldBeverage);
            products.Add(coffee);
            products.Add(tea);
            products.Add(cake);
            products.Add(soup);
            products.Add(fish);

            foreach (Product product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
