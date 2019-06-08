namespace p01._01.TrojanInvasion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TrojanInvasion
    {
        static void Main(string[] args)
        {
            
            int waves = int.Parse(Console.ReadLine());
            int[] plates = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> queuePlates = new List<int>(plates);
            Stack<int> stackWarriors = new Stack<int>();

            for (int i = 1; i <= waves; i++)
            {
                if (queuePlates.Count == 0)
                {
                    break;
                }

                int[] powerTroyanWarriors = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                stackWarriors = new Stack<int>(powerTroyanWarriors);

                if (i % 3 == 0)
                {
                    int newPlate = int.Parse(Console.ReadLine());
                
                    queuePlates.Add(newPlate);
                }

                while (queuePlates.Count != 0 &&
                       stackWarriors.Count != 0)
                {
                    int plate = queuePlates[0];
                    int warrior = stackWarriors.Pop();

                    if (warrior < plate)
                    {
                        queuePlates[0] = plate - warrior;
                    }
                    else if (warrior > plate)
                    {
                        warrior -= plate;
                        stackWarriors.Push(warrior);
                        queuePlates.RemoveAt(0);
                    }
                    else if (warrior == plate)
                    {
                        queuePlates.RemoveAt(0);
                    }
                }
            }

            if (queuePlates.Count != 0)
            {
                Console.WriteLine(
                    $"The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine(
                    $"Plates left: {string.Join(", ", queuePlates)}");
            }
            else
            {
                Console.WriteLine(
                    $"The Trojans successfully destroyed the Spartan defense.");
                Console.WriteLine(
                    $"Warriors left: {string.Join(", ", stackWarriors)}");
            }
        }
    }
}
