namespace p01._02.DiagonalDifference
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

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                sumLeftDiagonal += jaggedArr[i][i];

                sumRightDiagonal += jaggedArr[i][size - i - 1];
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
