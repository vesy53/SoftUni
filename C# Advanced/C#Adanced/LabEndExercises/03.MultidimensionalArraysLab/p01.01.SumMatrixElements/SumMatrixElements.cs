namespace p01._01.SumMatrixElements
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

            FillInTheMatrix(matrix);

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));

            int sum = 0;

            foreach (int element in matrix)
            {
                sum += element;
            }

            Console.WriteLine(sum);
        }

        private static void FillInTheMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowElements = Console.ReadLine()
                    .Split(',',
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
