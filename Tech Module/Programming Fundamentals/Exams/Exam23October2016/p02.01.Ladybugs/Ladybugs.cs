namespace p02._01.Ladybugs
{
    using System;
    using System.Linq;

    class Ladybugs
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] bugsIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[fieldSize];

            foreach (var index in bugsIndexes)
            {
                if (index >= 0 && index < field.Length)
                {
                    field[index] = 1;
                }
            }

            string input = Console.ReadLine();

            while (input.Equals("end") == false)
            {
                string[] tokens = input
                    .Split();
                int index = int.Parse(tokens[0]);
                string direction = tokens[1];
                int length = int.Parse(tokens[2]);

                if ((index >= 0 && index < field.Length)  && field[index] == 1)
                {
                    field[index] = 0;

                    while (true)
                    {
                        if (direction == "right")
                        {
                            index += length;
                        }
                        else if (direction == "left")
                        {
                            if (length > 0)
                            {
                                index -= length;
                            }
                            else if (length < 0)
                            {
                                length *= -1;
                                index += length;
                            }
                        }

                        if (index < 0 || index >= field.Length)
                        {
                            break;
                        }

                        if (field[index] == 0)
                        {
                            field[index] = 1;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
