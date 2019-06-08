namespace p02._02.SumMatrixColumns
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

            int[][] matrix = new int[rows][];

            FillInTheMatrix(matrix);

            for (int col = 0; col < matrix[0].Length; col++)
            {
                int sumColumn = 0;

                for (int row = 0; row < matrix.Length; row++)
                {
                    sumColumn += matrix[row][col];
                }

                Console.WriteLine(sumColumn);
            }
        }

        private static void FillInTheMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                int[] rowElements = Console.ReadLine()
                   .Split(' ',
                       StringSplitOptions
                       .RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();

                matrix[row] = rowElements;
            }
        }
    }
}
