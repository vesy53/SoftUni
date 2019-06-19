namespace p01._04.TheGarden
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class TheGarden
    {
        private static char[][] matrix;
        private static Dictionary<char, int> data;

        static void Main(string[] args)
        {
            data = new Dictionary<char, int>()
            {
                { 'C', 0 },
                { 'P', 0 },
                { 'L', 0 },

                { 'M', 0 }
            };

            int size = int.Parse(Console.ReadLine());

            matrix = new char[size][];

            FullTheMatrix();

            string input = Console.ReadLine();

            while (input.Equals("End of Harvest") == false)
            {
                string[] tokens = input
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);

                if (command == "Harvest")
                {
                    HarvestTheVegetable(row, col);
                }
                else if (command == "Mole")
                {
                    string direction = tokens[3].ToLower();

                    TheMoleHarms(direction, row, col);
                }

                input = Console.ReadLine();
            }

            PrintTheMatrix();

            PrintAllCounts();
        }

        private static void PrintAllCounts()
        {
            StringBuilder builder = new StringBuilder();

            builder
                .AppendLine($"Carrots: {data['C']}")
                .AppendLine($"Potatoes: {data['P']}")
                .AppendLine($"Lettuce: {data['L']}")
                .Append($"Harmed vegetables: {data['M']}");

            Console.WriteLine(builder.ToString());
        }

        private static void PrintTheMatrix()
        {
            foreach (char[] row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static void TheMoleHarms(
            string direction,
            int row,
            int col)
        {
            while (IsInTheRange(row, col))
            {
                if (matrix[row][col] != ' ')
                {
                    data['M']++;
                    matrix[row][col] = ' ';
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

        private static void HarvestTheVegetable(
            int row,
            int col)
        {
            if (IsInTheRange(row, col))
            {
                char currentElement = matrix[row][col];

                if (data.ContainsKey(currentElement))
                {
                    data[currentElement]++;
                    matrix[row][col] = ' ';
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

        private static void FullTheMatrix()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                char[] elements = Console.ReadLine()
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                // this line is not mandatory
                matrix[row] = new char[elements.Length];

                matrix[row] = elements;
            }
        }
    }
}
