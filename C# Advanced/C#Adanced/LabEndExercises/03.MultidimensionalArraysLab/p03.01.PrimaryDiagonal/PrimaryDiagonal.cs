namespace p03._01.PrimaryDiagonal
{
    using System;
    using System.Linq;

    class PrimaryDiagonal
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            FillInTheMatrix(matrix);

            int sumLeftDiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        sumLeftDiagonal += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(sumLeftDiagonal);
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
