namespace p01._03.TheGarden
{
    using System;

    class TheGarden
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            string[][] garden = new string[rows][];

            for (int row = 0; row < rows; row++)
            {
                string[] vegetables = Console.ReadLine()
                    .Split();

                int cols = vegetables.Length;

                garden[row] = new string[cols];

                for (int col = 0; col < cols; col++)
                {
                    garden[row][col] = vegetables[col];
                }
            }

            int carrots = 0;
            int potatoes = 0;
            int lettuce = 0;
            int harmed = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End of Harvest")
                {
                    break;
                }

                string[] partsOfCommand = input
                    .Split(" ", 
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = partsOfCommand[0];

                if (command == "Harvest")
                {
                    int row = int.Parse(partsOfCommand[1]);
                    int col = int.Parse(partsOfCommand[2]);

                    if (row >= 0 && row < garden.Length
                        && col >= 0 && col < garden[row].Length)
                    {
                        switch (garden[row][col])
                        {
                            case "L":
                                lettuce++;
                                break;
                            case "P":
                                potatoes++;
                                break;
                            case "C":
                                carrots++;
                                break;
                        }

                        garden[row][col] = " ";
                    }
                }
                else if (command == "Mole")
                {
                    int moleRow = int.Parse(partsOfCommand[1]);
                    int moleCol = int.Parse(partsOfCommand[2]);
                    var direction = partsOfCommand[3].ToLower();

                    if (moleRow >= 0 && moleRow < garden.Length
                        && moleCol >= 0 && moleCol < garden[moleRow].Length)
                    {
                        switch (direction)
                        {
                            case "up":

                                for (int row = moleRow; row >= 0; row -= 2)
                                {
                                    if (moleCol < garden[row].Length)
                                    {
                                        if (garden[row][moleCol] != " ")
                                        {
                                            garden[row][moleCol] = " ";
                                            harmed++;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }

                                break;

                            case "down":

                                for (int row = moleRow; row < garden.Length; row += 2)
                                {
                                    if (moleCol < garden[row].Length)
                                    {
                                        if (garden[row][moleCol] != " ")
                                        {
                                            garden[row][moleCol] = " ";
                                            harmed++;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }

                                break;

                            case "left":

                                for (int col = moleCol; col >= 0; col -= 2)
                                {
                                    if (garden[moleRow][col] != " ")
                                    {
                                        garden[moleRow][col] = " ";
                                        harmed++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }

                                break;

                            case "right":

                                for (int col = moleCol; col < garden[moleRow].Length; col += 2)
                                {
                                    if (garden[moleRow][col] != " ")
                                    {
                                        garden[moleRow][col] = " ";
                                        harmed++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }

                                break;
                        }
                    }
                }
            }

            foreach (string[] row in garden)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            Console.WriteLine($"Carrots: {carrots}");
            Console.WriteLine($"Potatoes: {potatoes}");
            Console.WriteLine($"Lettuce: {lettuce}");
            Console.WriteLine($"Harmed vegetables: {harmed}");
        }
    }
}