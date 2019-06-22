namespace p03._02.Bombs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Bombs
    {
        private static int[][] matrix;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            matrix = new int[size][];

            FullTheMatrix();

            string[] coordinates = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries);

            foreach (string coordinate in coordinates)
            {
                int[] indexes = coordinate
                    .Split(',')
                    .Select(int.Parse)
                    .ToArray();

                int row = indexes[0];
                int col = indexes[1];

                BombExpodes(row, col);
            }

            List<int> aliveCells = new List<int>();

            foreach (int[] row in matrix)
            {
                foreach (int number in row
                    .Where(x => x > 0))
                {
                    aliveCells.Add(number);
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells.Count()}");
            Console.WriteLine($"Sum: {aliveCells.Sum()}");

            PrintTheMatrix();
        }

        private static void PrintTheMatrix()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }

                Console.WriteLine();
            }
        }

        private static void BombExpodes(int row, int col)
        {
            int value = 0;

            if (IsInTheRange(row, col) &&
                matrix[row][col] > 0)
            {
                value = matrix[row][col];
                matrix[row][col] -= value;
            }

            if (IsInTheRange(row - 1, col) &&
                matrix[row - 1][col] > 0)
            {
                matrix[row - 1][col] -= value;
            }

            if (IsInTheRange(row - 1, col - 1) &&
                matrix[row - 1][col - 1] > 0)
            {
                matrix[row - 1][col - 1] -= value;
            }

            if (IsInTheRange(row - 1, col + 1) &&
                matrix[row - 1][col + 1] > 0)
            {
                matrix[row - 1][col + 1] -= value;
            }

            if (IsInTheRange(row, col - 1) &&
                matrix[row][col - 1] > 0)
            {
                matrix[row][col - 1] -= value;
            }

            if (IsInTheRange(row, col + 1) &&
                matrix[row][col + 1] > 0)
            {
                matrix[row][col + 1] -= value;
            }

            if (IsInTheRange(row + 1, col - 1) &&
                matrix[row + 1][col - 1] > 0)
            {
                matrix[row + 1][col - 1] -= value;
            }

            if (IsInTheRange(row + 1, col) &&
                matrix[row + 1][col] > 0)
            {
                matrix[row + 1][col] -= value;
            }

            if (IsInTheRange(row + 1, col + 1) &&
                matrix[row + 1][col + 1] > 0)
            {
                matrix[row + 1][col + 1] -= value;
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
                int[] numbers = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                matrix[row] = new int[numbers.Length];

                for (int col = 0; col < numbers.Length; col++)
                {
                    matrix[row][col] = numbers[col];
                }
            }
        }
    }
}
