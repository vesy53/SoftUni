namespace p02._02.Snowmen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Snowmen2
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (numbers.Count > 1)
            {
                List<int> losers = new List<int>();

                for (int attacker = 0; attacker < numbers.Count; attacker++)
                {
                    //integer value is its target index
                    int target = numbers[attacker];
                    // If the integer value is greater than the length of the sequence, divide it modulo (%) by the length of the sequence
                    if (target >= numbers.Count)
                    {
                        target %= numbers.Count;
                    }

                    int difference = Math.Abs(attacker - target);

                    if (numbers.Count - losers.Count == 1)
                    {
                        break;
                    }

                    if (losers.Contains(attacker))
                    {
                        continue;
                    }

                    if (attacker == target)
                    {
                        Console.WriteLine(
                            $"{attacker} performed harakiri");

                        losers.Add(attacker);
                        numbers[attacker] = -1; // atacker is dead
                    }
                    else if (difference % 2 == 0)
                    {
                        Console.WriteLine(
                            $"{attacker} x {target} -> {attacker} wins");

                        losers.Add(target);
                        numbers[target] = -1; // target is loser
                    }
                    else if (difference % 2 == 1)
                    {
                        Console.WriteLine(
                            $"{attacker} x {target} -> {target} wins");

                        losers.Add(attacker);
                        numbers[attacker] = -1;  // attacker is loser
                    }

                    losers = losers.Distinct().ToList();
                }

                numbers = numbers
                    .Where(x => x != -1)
                    .ToList();
            }
        }
    }
}
