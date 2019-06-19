namespace p01._01.TheGarden
{
    using System;
    using System.Linq;

    class TheGarden  
    {
        private static char[][] matrix;
        private static int countOfCarrots;
        private static int countOfPotatoes;
        private static int countOfLettuce;
        private static int countOfHarmed;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            matrix = new char[size][];

            FullThMatrix();

            string input = Console.ReadLine();

            countOfLettuce = 0;
            countOfPotatoes = 0;
            countOfCarrots = 0;
            countOfHarmed = 0;

            while (input.Equals("End of Harvest") == false)
            {
                string[] tokens = input
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);

                if (command == "Harvest")
                {
                    if (IsInTheRange(row, col))
                    {
                        if (matrix[row][col] == 'L')
                        {
                            countOfLettuce++;
                        }
                        else if (matrix[row][col] == 'P')
                        {
                            countOfPotatoes++;
                        }
                        else if (matrix[row][col] == 'C')
                        {
                            countOfCarrots++;
                        }

                        matrix[row][col] = ' ';
                    }
                }
                else if (command == "Mole")
                {
                    string direction = tokens[3].ToLower();

                    if (IsInTheRange(row, col))
                    { 
                        MovedMole(ref row, ref col, direction);
                    }
                }

                input = Console.ReadLine();
            }

            PrintTheMatrix();

            Console.WriteLine($"Carrots: {countOfCarrots}");
            Console.WriteLine($"Potatoes: {countOfPotatoes}");
            Console.WriteLine($"Lettuce: {countOfLettuce}");
            Console.WriteLine($"Harmed vegetables: {countOfHarmed}");

        }

        private static void PrintTheMatrix()
        {
            foreach (char[] row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static void MovedMole
            (ref int row, 
            ref int col, 
            string direction)
        {
            while (IsInTheRange(row, col))
            {
                if (matrix[row][col] != ' ')
                {
                    matrix[row][col] = ' ';
                    countOfHarmed++;
                }

                switch (direction)
                {
                    case "up":
                        row -= 2;
                        break;
                    case "down":
                        row += 2;
                        break;
                    case "left":
                        col -= 2;
                        break;
                    case "right":
                        col += 2;
                        break;
                }
            }
        }

        private static bool IsInTheRange(int row, int col)
        {
            return row >= 0 &&
                   row < matrix.Length &&
                   col >= 0 &&
                   col < matrix[row].Length;
        }

        private static void FullThMatrix()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                char[] elements = Console.ReadLine()
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                matrix[row] = new char[elements.Length];

                matrix[row] = elements;
            }
        }
    }
}
