namespace p03._01.ChoreWars
{
    using System;
    using System.Text.RegularExpressions;

    class ChoreWars
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex dishesPattern = new Regex(@"<(?<dishes>[a-z\d]+)>");
            Regex cleaningPattern = new Regex(@"\[(?<cleaning>[A-Z\d]+)\]");
            Regex laundryPattern = new Regex(@"\{(?<laundry>.*)\}");

            int sumDishes = 0;
            int sumCleaning = 0;
            int sumLaundry = 0;

            while (input != "wife is happy")
            {
                Match matchDishes = dishesPattern.Match(input);
                Match matchCleaning = cleaningPattern.Match(input);
                Match matchLaundry = laundryPattern.Match(input);

                if (matchDishes.Success)
                {
                    string dishes = matchDishes.Groups["dishes"].Value;

                    sumDishes = TakeSum(dishes, sumDishes);
                }
                else if (matchCleaning.Success)
                {
                    string cleaning = matchCleaning.Groups["cleaning"].Value;

                    sumCleaning = TakeSum(cleaning, sumCleaning);
                }
                else if (matchLaundry.Success)
                {
                    string laundry = matchLaundry.Groups["laundry"].Value;

                    sumLaundry = TakeSum(laundry, sumLaundry);
                }

                input = Console.ReadLine();
            }

            int totalSum = sumDishes + sumCleaning + sumLaundry;

            Console.WriteLine($"Doing the dishes - {sumDishes} min.");
            Console.WriteLine($"Cleaning the house - {sumCleaning} min.");
            Console.WriteLine($"Doing the laundry - {sumLaundry} min.");
            Console.WriteLine($"Total - {totalSum} min.");
        }

        static int TakeSum(string symbols, int sum)
        {
            foreach (char @char in symbols)
            {
                if (char.IsDigit(@char))
                {
                    int currNum = @char - 48;
                    sum += currNum;
                }
            }

            return sum;
        }
    }
}
