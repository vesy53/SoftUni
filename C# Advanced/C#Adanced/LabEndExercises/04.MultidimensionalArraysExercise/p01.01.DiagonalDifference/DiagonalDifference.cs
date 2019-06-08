namespace p01._01.DiagonalDifference
{
    using System;
    using System.Linq;

    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] jaggedArr = new int[size][];

            FillInTheMatrix(jaggedArr);

            int sumLeftDiagonal = 0;
            int sumRightDiagonal = 0;

            for (int row = 0; row < jaggedArr.Length; row++)
            {
                for (int col = 0; col < jaggedArr[row].Length; col++)
                {
                    if (row == col)
                    {
                        sumLeftDiagonal += jaggedArr[row][col];
                    }

                    if (row + col == jaggedArr.Length - 1)
                    {
                        sumRightDiagonal += jaggedArr[row][col];
                    }
                }
            }

            int difference = Math.Abs(sumLeftDiagonal - sumRightDiagonal);

            Console.WriteLine(difference);
        }

        private static void FillInTheMatrix(int[][] jaggedArr)
        {
            for (int row = 0; row < jaggedArr.Length; row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jaggedArr[row] = numbers;
            }
        }
    }
}
