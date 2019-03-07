namespace p01._01.SantasCookies
{
    using System;

    class SantasCookies
    {
        static void Main(string[] args)
        {
            long amountOfBatches = long.Parse(Console.ReadLine());

            int singleCookieGrams = 25;
            int cup = 140;
            int smallSpoon = 10;
            int bigSpoon = 20;
            int cookiesPerBox = 5;

            int totalBoxes = 0;

            for (int i = 0; i < amountOfBatches; i++)
            {
                int flourInGram = int.Parse(Console.ReadLine());
                int sugarInGram = int.Parse(Console.ReadLine());
                int cacaoInGram = int.Parse(Console.ReadLine());

                int flourCup = flourInGram / cup;
                int sugarSpoon = sugarInGram / bigSpoon;
                int cacaoSpoon = cacaoInGram / smallSpoon;

                int sumGrams = (cup + smallSpoon + bigSpoon);
                int total = sumGrams * Math.Min(flourCup, Math.Min(sugarSpoon, cacaoSpoon));

                double totalCookiesPerBake = total / singleCookieGrams;

                int boxesPerBatch = (int)Math.Floor(totalCookiesPerBake / cookiesPerBox);

                totalBoxes += boxesPerBatch;

                if (boxesPerBatch > 0)
                {
                    Console.WriteLine($"Boxes of cookies: {boxesPerBatch}");
                }

                if (flourCup <= 0 ||
                    sugarSpoon <= 0 ||
                    cacaoSpoon <= 0)
                {
                    Console.WriteLine(
                        "Ingredients are not enough for a box of cookies.");
                }
            }

            Console.WriteLine($"Total boxes: {totalBoxes}");
        }
    }
}
