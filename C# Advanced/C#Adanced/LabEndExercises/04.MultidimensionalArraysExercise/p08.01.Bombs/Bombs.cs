namespace p08._01.Bombs
{
    using System;
    using System.Linq;

    class Bombs
    {
        static int[][] matrix;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            matrix = new int[size][];

            FillTheMatrix(matrix);

            string[] bombs = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries);

            for (int i = 0; i < bombs.Length; i++)
            {
                int[] coordinates = bombs[i]
                    .Split(new char[] { ',', ' ' }, 
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int bombRow = coordinates[0];
                int bombCol = coordinates[1];

                if (IsInTheRange(bombRow, bombCol))
                {
                    BombAttacks(bombRow, bombCol);
                }
            }
            
            int countAliveCell = 0;
            int sumAliveCell = 0;

            foreach (int[] row in matrix)
            {
                countAliveCell += row.Count(r => r > 0);
                sumAliveCell += row.Where(r => r > 0).Sum();
            }

            Console.WriteLine($"Alive cells: {countAliveCell}");
            Console.WriteLine($"Sum: {sumAliveCell}");

            PrintTheMatrix(matrix);
        }

        private static void PrintTheMatrix(int[][] matrix)
        {
            foreach (int[] row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static void BombAttacks(int row, int col)
        {
            int bombValue = matrix[row][col];

            if (IsPositiveValue(row, col))
            {
                matrix[row][col] = 0;

                if (IsInTheRange(row, col - 1) &&
                    IsPositiveValue(row, col - 1))
                {
                    matrix[row][col - 1] -= bombValue;
                }
                if (IsInTheRange(row, col + 1) &&
                    IsPositiveValue(row, col + 1))
                {
                    matrix[row][col + 1] -= bombValue;
                }

                if (IsInTheRange(row - 1, col) &&
                    IsPositiveValue(row - 1, col))
                {
                    matrix[row - 1][col] -= bombValue;
                }
                if (IsInTheRange(row - 1, col - 1) &&
                    IsPositiveValue(row - 1, col - 1))
                {
                    matrix[row - 1][col - 1] -= bombValue;
                }
                if (IsInTheRange(row - 1, col + 1) &&
                    IsPositiveValue(row - 1, col + 1))
                {
                    matrix[row - 1][col + 1] -= bombValue;
                }

                if (IsInTheRange(row + 1, col) &&
                    IsPositiveValue(row + 1, col))
                {
                    matrix[row + 1][col] -= bombValue;
                }
                if (IsInTheRange(row + 1, col - 1) &&
                    IsPositiveValue(row + 1, col - 1))
                {
                    matrix[row + 1][col - 1] -= bombValue;
                }
                if (IsInTheRange(row + 1, col + 1) &&
                    IsPositiveValue(row + 1, col + 1))
                {
                    matrix[row + 1][col + 1] -= bombValue;
                }
            }
        }

        private static bool IsPositiveValue(int bombRow, int bombCol)
        {
            return matrix[bombRow][bombCol] > 0;
        }

        private static bool IsInTheRange(int row, int col)
        {
            return row >= 0 &&
                   row < matrix.Length &&
                   col >= 0 &&
                   col < matrix[row].Length;
        }

        private static void FillTheMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                matrix[row] = numbers;
            }
        }
    }
}
