namespace p02._04.Ladybugs
{
    using System;
    using System.Linq;

    class Ladybugs4
    {
        static void Main(string[] args)
        {
            long size = long.Parse(Console.ReadLine());
            long[] bugIndexes = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();

            long[] field = new long[size];

            for (long i = 0; i < bugIndexes.Length; i++)
            {
                long currIndex = bugIndexes[i];

                if (currIndex >= 0 && currIndex < field.Length)
                {
                    field[currIndex] = 1;
                }
            }

            string command = Console.ReadLine();

            while (command.Equals("end") == false)
            {
                string[] commandTokens = command
                    .Split();
                long index = long.Parse(commandTokens[0]);
                string direction = commandTokens[1];
                long length = long.Parse(commandTokens[2]);

                if (index >= 0 && index < field.Length && (field[index] == 1))
                {
                    field[index] = 0;

                    if (direction == "right")
                    {
                        MoveRight(field, index, length);
                    }
                    else if (direction == "left")
                    {
                        if (length >= 0)
                        {
                            MoveLeft(field, index, length);
                        }
                        else if (length < 0)
                        {
                            MoveRight(field, index, Math.Abs(length));
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }

        static void MoveLeft(long[] field, long index, long length)
        {
            index -= length;

            if (index >= 0 && index < field.Length && field[index] == 0)
            {
                field[index] = 1;
            }
            else if (index >= 0 && index < field.Length && field[index] == 1)
            {
                MoveLeft(field, index, length);
            }
        }

        static void MoveRight(long[] field, long index, long length)
        {
            index += length;

            if (index >= 0 && index < field.Length && field[index] == 0)
            {
                field[index] = 1;
            }
            else if (index >= 0 && index < field.Length && field[index] == 1)
            {
                MoveRight(field, index, length);
            }
        }
    }
}
