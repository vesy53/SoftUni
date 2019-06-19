namespace p03._01.Bombs
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

            FullTheMatrix();

            string[] coordinates = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);

            for (int i = 0; i < coordinates.Length; i++)
            {
                int[] bombs = coordinates[i]
                    .Split(',')
                    .Select(int.Parse)
                    .ToArray();

                int rowBomb = bombs[0];
                int colBomb = bombs[1];

                BombExplodes(rowBomb, colBomb);
            }

            PrintResult();

            PrintMatrix();
        }

        private static void PrintMatrix()
        {
            foreach (int[] row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static void PrintResult()
        {
            int countAliveCells = 0;
            int sum = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] > 0)
                    {
                        countAliveCells++;
                        sum += matrix[row][col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {countAliveCells}");
            Console.WriteLine($"Sum: {sum}");
        }

        private static void BombExplodes(int rowBomb, int colBomb)
        {
            int bomb = 0;

            if (IsInTheRange(rowBomb, colBomb) &&
                matrix[rowBomb][colBomb] > 0)
            {
                bomb = matrix[rowBomb][colBomb];
            }

            if (IsInTheRange(rowBomb - 1, colBomb) &&
                matrix[rowBomb - 1][colBomb] > 0)
            {
                matrix[rowBomb - 1][colBomb] -= bomb;
            }

            if (IsInTheRange(rowBomb - 1, colBomb - 1) &&
                matrix[rowBomb - 1][colBomb - 1] > 0)
            {
                matrix[rowBomb - 1][colBomb - 1] -= bomb;
            }

            if (IsInTheRange(rowBomb - 1, colBomb + 1) &&
                matrix[rowBomb - 1][colBomb + 1] > 0)
            {
                matrix[rowBomb - 1][colBomb + 1] -= bomb;
            }

            if (IsInTheRange(rowBomb, colBomb - 1) &&
                matrix[rowBomb][colBomb - 1] > 0)
            {
                matrix[rowBomb][colBomb - 1] -= bomb;
            }

            if (IsInTheRange(rowBomb, colBomb) &&
                matrix[rowBomb][colBomb] > 0)
            {
                matrix[rowBomb][colBomb] -= bomb;
            }

            if (IsInTheRange(rowBomb, colBomb + 1) &&
                matrix[rowBomb][colBomb + 1] > 0)
            {
                matrix[rowBomb][colBomb + 1] -= bomb;
            }

            if (IsInTheRange(rowBomb + 1, colBomb) &&
                matrix[rowBomb + 1][colBomb] > 0)
            {
                matrix[rowBomb + 1][colBomb] -= bomb;
            }

            if (IsInTheRange(rowBomb + 1, colBomb - 1) &&
                matrix[rowBomb + 1][colBomb - 1] > 0)
            {
                matrix[rowBomb + 1][colBomb - 1] -= bomb;
            }

            if (IsInTheRange(rowBomb + 1, colBomb + 1) &&
                matrix[rowBomb + 1][colBomb + 1] > 0)
            {
                matrix[rowBomb + 1][colBomb + 1] -= bomb;
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
                int[] elements = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                matrix[row] = elements;
            }
        }
    }
}
