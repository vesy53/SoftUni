namespace p02._01.TrophonTheGrumpyCat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TrophonTheGrumpyCat
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();
            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItem = Console.ReadLine();
            string typeOfPriceRating = Console.ReadLine();

            List<long> leftPart = new List<long>();
            List<long> rightPart = new List<long>();

            long entryNum = numbers[entryPoint];

            switch (typeOfItem)
            { 
               case "cheap":
                   for (int i = 0; i < entryPoint; i++)
                   {
                        if (numbers[i] < entryNum)
                        {
                            leftPart.Add(numbers[i]);
                        }
                   }

                   for (int i = entryPoint + 1; i < numbers.Count; i++)
                   {
                        if (numbers[i] < entryNum)
                        {
                            rightPart.Add(numbers[i]);
                        }
                   }
                   break;
               case "expensive":
                  for (int i = 0; i < entryPoint; i++)
                  {
                        if (numbers[i] >= entryNum)
                        {
                            leftPart.Add(numbers[i]);
                        }
                  }

                  for (int i = entryPoint + 1; i < numbers.Count; i++)
                  {
                        if (numbers[i] >= entryNum)
                        {
                            rightPart.Add(numbers[i]);
                        }
                  }
                  break;
            }

            long sumLeft = 0;
            long sumRight = 0;

            switch (typeOfPriceRating)
            {
                case "positive":
                    sumLeft = leftPart.Where(x => x > 0).Sum();
                    sumRight = rightPart.Where(x => x > 0).Sum();
                    break;
                case "negative":
                    sumLeft = leftPart.Where(x => x < 0).Sum();
                    sumRight = rightPart.Where(x => x < 0).Sum();
                    break;
                case "all":
                    sumLeft = leftPart.Sum();
                    sumRight = rightPart.Sum();
                    break;
            }

            if (sumLeft >= sumRight)
            {
                Console.WriteLine($"Left - {sumLeft}");
            }
            else if(sumLeft < sumRight)
            {
                Console.WriteLine($"Right - {sumRight}");
            }
        }
    }
}
