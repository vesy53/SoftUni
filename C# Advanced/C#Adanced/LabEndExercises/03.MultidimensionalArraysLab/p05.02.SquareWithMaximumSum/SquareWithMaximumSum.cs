namespace p05._02.SquareWithMaximumSum
{
    using System;
    using System.Linq;

    class SquareWithMaximumSum
    {
        static int[][] jaggedArr;
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

            jaggedArr = new int[rows][];

            FillInTheMatrix();

            maxSquareSum = int.MinValue;
            rowIndex = 0;
            colIndex = 0;

            for (int row = 0; row < jaggedArr.Length - 1; row++)
            {
                for (int col = 0; col < jaggedArr[row].Length - 1; col++)
                {
                    int squareSum = jaggedArr[row][col] +
                        jaggedArr[row][col + 1] +
                        jaggedArr[row + 1][col] +
                        jaggedArr[row + 1][col + 1];

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
                    Console.Write($"{jaggedArr[row][col]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSquareSum);
        }

        private static void FillInTheMatrix()
        {
            for (int row = 0; row < jaggedArr.Length; row++)
            {
                int[] rowNumbers = Console.ReadLine()
                    .Split(',',
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jaggedArr[row] = rowNumbers;
            }
        }
    }
}