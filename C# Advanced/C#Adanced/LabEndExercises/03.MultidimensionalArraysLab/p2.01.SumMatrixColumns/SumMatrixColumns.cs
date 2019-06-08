namespace p02._01.SumMatrixColumns
{
    using System;
    using System.Linq;

    class SumMatrixColumns
    {
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

            int[,] matrix = new int[rows, columns];

            FillInTheMatrix(matrix);

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sumColumn = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumColumn += matrix[row, col];
                }

                Console.WriteLine(sumColumn);
            }
        }

        private static void FillInTheMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowElements = Console.ReadLine()
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowElements[col];
                }
            }
        }
    }
}
