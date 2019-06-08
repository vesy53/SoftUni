namespace p01._03.SumMatrixElements
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

            int[][] matrix = new int[rows][];

            FillInTheMatrix(matrix);

            int sum = matrix
                .Select(x => x.Sum())
                .Sum();

            Console.WriteLine(rows);
            Console.WriteLine(columns);
            Console.WriteLine(sum);
        }

        private static void FillInTheMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                int[] rowElements = Console.ReadLine()
                    .Split(',',
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                matrix[row] = rowElements;
            }
        }
    }
}
