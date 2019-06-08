namespace p03._01.MaximalSum
{
    using System;
    using System.Linq;

    class MaximalSum
    {
        static int[][] matrix;
        static int maxSum;
        static int rowIndex;
        static int colIndex;

        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = sizes[0];

            matrix = new int[rows][];

            FillInTheMatrix();

            maxSum = int.MinValue;
            rowIndex = 0;
            colIndex = 0;

            for (int row = 0; row < matrix.Length - 2; row++)
            {
                for (int col = 0; col < matrix[row].Length - 2; col++)
                {
                    int sum = SumRectangleElements(row, col);

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }

            PrintResult();
        }

        private static void PrintResult()
        {
            Console.WriteLine($"Sum = {maxSum}");

            for (int row = rowIndex; row < rowIndex + 3; row++)
            {
                for (int col = colIndex; col < colIndex + 3; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }

                Console.WriteLine();
            }
        }

        private static int SumRectangleElements(int row, int col)
        {
            int sum = matrix[row][col] + 
                      matrix[row][col + 1] + 
                      matrix[row][col + 2] +
                      matrix[row + 1][col] + 
                      matrix[row + 1][col + 1] + 
                      matrix[row + 1][col + 2] +
                      matrix[row + 2][col] + 
                      matrix[row + 2][col + 1] + 
                      matrix[row + 2][col + 2];

            return sum;
        }

        private static void FillInTheMatrix()
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
