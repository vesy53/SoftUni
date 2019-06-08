namespace p01._02.SumMatrixElements
{
    using System;
    using System.Linq;

    class SumMatrixElements
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

            int sum = 0;

            sum = FillInTheMatrix(matrix, sum);

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }

        private static int FillInTheMatrix(int[,] matrix, int sum)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columnElements = Console.ReadLine()
                    .Split(',',
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columnElements[col];
                    sum += columnElements[col];
                }
            }

            return sum;
        }
    }
}
