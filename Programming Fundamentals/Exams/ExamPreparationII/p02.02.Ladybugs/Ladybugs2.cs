namespace p02._02.Ladybugs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Ladybugs2
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            List<int> indexLadybugs = Console.ReadLine()
                .Split(new char[] { ' ' },
                    StringSplitOptions
                    .RemoveEmptyEntries)
               .Select(int.Parse)
               .Where(x => x >= 0 && x < size)
               .ToList();
            //.ForEach(x => field[x] = 1);

            int[] field = new int[size];

            foreach (var index in indexLadybugs)
            {
                field[index] = 1;
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] command = line.Split(' ');
                int currentLadybugIndexs = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);

                if (direction == "left")
                {
                    flyLength *= -1;
                }

                if (currentLadybugIndexs < 0 || currentLadybugIndexs >= size)
                {
                    continue;
                }

                if (field[currentLadybugIndexs] == 0)
                {
                    continue;
                }

                field[currentLadybugIndexs] = 0;
                int nextIndexToLend = currentLadybugIndexs;

                while (true)
                {
                    nextIndexToLend += flyLength;

                    if (nextIndexToLend < 0 || nextIndexToLend >= size)
                    {
                        break;
                    }

                    if (field[nextIndexToLend] == 1)
                    {
                        continue;
                    }

                    field[nextIndexToLend] = 1;
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
