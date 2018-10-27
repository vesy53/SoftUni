namespace p02._01.Snowmen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Snowmen
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (numbers.Length > 1)
            {
                List<int> losers = new List<int>();

                for (int attacker = 0; attacker < numbers.Length; attacker++)
                {
                    int target = numbers[attacker] % numbers.Length;

                    int diff = Math.Abs(attacker - target);

                    if (numbers.Length - losers.Count == 1)
                    {
                        break;
                    }

                    if (losers.Contains(attacker))
                    {
                        continue;
                    }

                    if (attacker == target)
                    {
                        Console.WriteLine($"{attacker} performed harakiri");

                        losers.Add(attacker);
                        numbers[attacker] = -1;
                    }
                    else if (diff % 2 == 0)
                    {
                        Console.WriteLine(
                            $"{attacker} x {target} -> {attacker} wins");

                        losers.Add(target);
                        numbers[target] = -1;
                    }
                    else
                    {
                        Console.WriteLine(
                            $"{attacker} x {target} -> {target} wins");

                        losers.Add(attacker);
                        numbers[attacker] = -1;
                    }

                    losers = losers.Distinct().ToList();
                }

                numbers = numbers
                    .Where(n => n != -1)
                    .ToArray();
            }
        }
    }
}
