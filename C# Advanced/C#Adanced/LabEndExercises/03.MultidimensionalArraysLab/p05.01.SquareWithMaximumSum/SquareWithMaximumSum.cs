namespace p05._01.SquareWithMaximumSum
{
    using System;
    using System.Linq;

    class SquareWithMaximumSum
    {
        static int[,] matrix;
        static int maxSquareSum;
        static int rowIndex;
        static int colIndex;

        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(',',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = sizes[0];
            int columns = sizes[1];

            matrix = new int[rows, columns];

            FillInTheMatrix();

            maxSquareSum = 0;
            rowIndex = 0;
            colIndex = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int squareSum = matrix[row, col] +
                        matrix[row + 1, col] +
                        matrix[row, col + 1] +
                        matrix[row + 1, col + 1];

                    if (squareSum > maxSquareSum)
                    {
                        maxSquareSum = squareSum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }

            PrintResults();
        }

        private static void PrintResults()
        {
            for (int row = rowIndex; row < rowIndex + 2; row++)
            {
                for (int col = colIndex; col < colIndex + 2; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSquareSum);
        }

        private static void FillInTheMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowNumbers = Console.ReadLine()
                    .Split(',',
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowNumbers[col];
                }
            }
        }
    }
}
