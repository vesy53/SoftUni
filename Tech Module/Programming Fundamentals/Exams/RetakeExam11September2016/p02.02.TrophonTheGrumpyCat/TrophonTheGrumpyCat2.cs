namespace p02._02.TrophonTheGrumpyCat
{
    using System;
    using System.Linq;

    class TrophonTheGrumpyCat2
    {
        static void Main(string[] args)
        {
            long[] prices = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();
            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();
            string typeOfPrice = Console.ReadLine();

            long[] leftPart = prices
                .Take(entryPoint)
                .ToArray();
            long[] rightPart = prices
                .Skip(entryPoint + 1)
                .ToArray();

            leftPart = typeOfItems.Equals("cheap") ?
                leftPart.Where(x => x < prices[entryPoint]).ToArray() :
                leftPart.Where(x => x >= prices[entryPoint]).ToArray();

            rightPart = typeOfItems.Equals("cheap") ?
                rightPart.Where(x => x < prices[entryPoint]).ToArray() :
                rightPart.Where(x => x >= prices[entryPoint]).ToArray();

            long leftSum = 0;
            long rightSum = 0;

            if (typeOfPrice.Equals("positive"))
            {
                leftSum = leftPart
                    .Where(x => x >= 0)
                    .Sum();
                rightSum = rightPart
                    .Where(x => x >= 0)
                    .Sum();
            }
            else if (typeOfPrice.Equals("negative"))
            {
                leftSum = leftPart
                    .Where(x => x < 0)
                    .Sum();
                rightSum = rightPart
                    .Where(x => x < 0)
                    .Sum();
            }
            else if (typeOfPrice.Equals("all"))
            {
                leftSum = leftPart
                    .Sum();
                rightSum = rightPart
                    .Sum();
            }

            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }
    }
}
