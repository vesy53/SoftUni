namespace p02._03.Snowmen
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Snowmen3
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (numbers.Count > 1)
            {
                for (int attacker = 0; attacker < numbers.Count; attacker++)
                {
                    int target = numbers[attacker];

                    target %= numbers.Count;

                    if (numbers.Count(x => x != -1) == 1)
                    {
                        break;
                    }
                    //If an element loses a battle or suicides, it should NOT be able to attack. It can still be a target though.
                    //Ако даден елемент загуби битка или самоубийство, той НЕ би могъл да атакува. Все пак може да бъде цел.
                    if (numbers[attacker] == -1) // if the current snowman is dead
                    {
                        continue;
                    }

                    int diff = Math.Abs(attacker - target);

                    if (attacker == target) 
                    {
                        Console.WriteLine($"{attacker} performed harakiri");

                        numbers[attacker] = -1; // attacker is dead
                        continue;
                    }

                    if (diff % 2 == 0) 
                    {
                        Console.WriteLine(
                            $"{attacker} x {target} -> {attacker} wins");

                        numbers[target] = -1; // target is losers
                        continue;
                    }

                    if (diff % 2 != 0) 
                    {
                        Console.WriteLine(
                            $"{attacker} x {target} -> {target} wins");

                        numbers[attacker] = -1; // attacker is losers
                    }
                }

                numbers = numbers
                    .Where(x => x != -1)
                    .ToList();
            }
        }
    }
}
