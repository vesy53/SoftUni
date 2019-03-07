namespace p02._01.Ladybugs
{
    using System;
    using System.Linq;

    class Ladybugs
    {
        static void Main(string[] args)
        {
            int sizeOfTheField = int.Parse(Console.ReadLine());
            int[] indexesOfLadybugs = Console.ReadLine()
                .Split(new char[] { ' ' },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            int[] field = new int[sizeOfTheField]; //създаваме [] на полето

            foreach (int index in indexesOfLadybugs)
            {
                if (index < 0 || index >= sizeOfTheField) //проверяваме дали калинките са извън границите
                {
                    continue;
                }

                field[index] = 1; //ако не са - добавяме 1 на всеки индекс където има калинка
            }

            while (command.Equals("end") == false)
            {
                string[] commandTokens = command
                    .Split();
                int index = int.Parse(commandTokens[0]);
                string direction = commandTokens[1];
                int flyLength = int.Parse(commandTokens[2]);

                if (index >= 0 && index < field.Length && field[index] == 1)
                {
                     if (direction == "right")
                     {
                        if (flyLength > 0)
                        {
                            FlyRight(field, index, flyLength);
                        }
                        else
                        {
                            FlyLeft(field, index, Math.Abs(flyLength));
                        }
                     }
                     else if (direction == "left")
                     {
                        if (flyLength > 0)
                        {
                            FlyLeft(field, index, flyLength);
                        }
                        else
                        {
                            FlyRight(field, index, Math.Abs(flyLength));
                        }
                     }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }

        static void FlyLeft(int[] field, int index, int flyLength)
        {
            field[index] = 0;

            for (int i = index - flyLength; i >= 0; i -= flyLength)
            {
                if (field[i] == 0)
                {
                    field[i] = 1;
                    return;
                }
            }
        }

        static void FlyRight(int[] field, int index, int flyLength)
        {
            field[index] = 0;

            for (int i = index + flyLength; i < field.Length; i += flyLength)
            {
                if (field[i] == 0)
                {
                    field[i] = 1;
                    return;
                }
            }
        }
    }
}
