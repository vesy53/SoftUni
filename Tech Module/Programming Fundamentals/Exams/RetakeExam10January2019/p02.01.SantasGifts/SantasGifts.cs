namespace p02._01.SantasGifts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SantasGifts
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<int> numHouses = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int santasPosition = 0;

            for (int i = 0; i < num; i++)
            {
                string[] inputTokens = Console.ReadLine()
                    .Split();

                string command = inputTokens[0];

                switch (command)
                {
                    case "Forward":
                        int index = int.Parse(inputTokens[1]);

                        if (santasPosition + index >= 0 && 
                            santasPosition + index < numHouses.Count)
                        {
                            santasPosition += index;
                            numHouses.RemoveAt(santasPosition);
                        }
                        break;
                    case "Back":
                        int backIndex = int.Parse(inputTokens[1]);

                        if (santasPosition - backIndex >= 0 &&
                            santasPosition - backIndex < numHouses.Count)
                        {
                            santasPosition -= backIndex;
                            numHouses.RemoveAt(santasPosition);
                        }
                        break;
                    case "Gift":
                        int insertIndex = int.Parse(inputTokens[1]);
                        int value = int.Parse(inputTokens[2]);

                        if (insertIndex >= 0 &&
                            insertIndex < numHouses.Count)
                        {
                            numHouses.Insert(insertIndex, value);
                            santasPosition = insertIndex;
                        }
                        break;
                    case "Swap":
                        int firstValue = int.Parse(inputTokens[1]);
                        int secondValue = int.Parse(inputTokens[2]);

                        if (numHouses.Contains(firstValue) &&
                            numHouses.Contains(secondValue))
                        {
                            int firstIndex = numHouses.IndexOf(firstValue);
                            int secondIndex = numHouses.IndexOf(secondValue);

                            numHouses[firstIndex] = secondValue;
                            numHouses[secondIndex] = firstValue;
                        }
                        break;
                }
            }

            Console.WriteLine($"Position: {santasPosition}");
            Console.WriteLine(string.Join(", ", numHouses));
        }
    }
}
