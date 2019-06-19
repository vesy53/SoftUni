namespace p03._01.Miner
{
    using System;
    using System.Linq;

    class Miner
    {
        static char[][] matrix;
        static int rowStart;
        static int colStart;
        static int totalCoals;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            matrix = new char[size][];

            string[] commands = Console.ReadLine()
                .Split(" ",
                StringSplitOptions
                .RemoveEmptyEntries);

            FullTheMatrix();

            bool hasCoals = true;
            bool isGameOver = false;

            foreach (string command in commands)
            {
                MinerMoved(command);

                if (totalCoals == 0)
                {
                    hasCoals = false;
                    break;
                }

                if (matrix[rowStart][colStart] == 'e')
                {
                    isGameOver = true;
                    break;
                }
            }

            PrintTheResult(hasCoals, isGameOver);
        }

        private static void PrintTheResult(
            bool hasCoals, 
            bool isGameOver)
        {
            if (!hasCoals)
            {
                Console.WriteLine(
                    $"You collected all coals! ({rowStart}, {colStart})");
            }
            else if (isGameOver)
            {
                Console.WriteLine(
                    $"Game over! ({rowStart}, {colStart})");
            }
            else
            {
                Console.WriteLine(
                    $"{totalCoals} coals left. ({rowStart}, {colStart})");
            }
        }

        private static void MinerMoved(string command)
        {
            switch (command)
            {
                case "up":
                    rowStart--;
                    break;
                case "down":
                    rowStart++;
                    break;
                case "left":
                    colStart--;
                    break;
                case "right":
                    colStart++;
                    break;
            }

            IsInRange();

            if (matrix[rowStart][colStart] == 'c')
            {
                totalCoals--;
                matrix[rowStart][colStart] = '*';
            }
        }

        private static void IsInRange()
        {
            if (rowStart < 0)
            {
                rowStart = 0;
            }
            else if (rowStart > matrix.Length - 1)
            {
                rowStart = matrix.Length - 1;
            }

            if (colStart < 0)
            {
                colStart = 0;
            }
            else if (colStart > matrix[rowStart].Length - 1)
            {
                colStart = matrix[rowStart].Length - 1;
            }
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

                matrix[row] = elements;

                if (matrix[row].Contains('s'))
                {
                    rowStart = row;
                    colStart = Array.IndexOf(matrix[row], 's');
                }

                if (matrix[row].Contains('c'))
                {
                    totalCoals += matrix[row]
                        .Where(m => m == 'c')
                        .Count();
                }
            }
        }
    }
}
