namespace p03._02.PrimaryDiagonal
{
    using System;
    using System.Linq;

    class PrimaryDiagonal
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] jaggedArr = new int[size][];

            FillInTheMatrix(jaggedArr);

            int sumLeftDiagonal = 0;

            for (int row = 0; row < jaggedArr.Length; row++)
            {
                for (int col = 0; col < jaggedArr.Length; col++)
                {
                    if (row == col)
                    {
                        sumLeftDiagonal += jaggedArr[row][col];
                    }
                }
            }

            Console.WriteLine(sumLeftDiagonal);
        }

        private static void FillInTheMatrix(int[][] jaggedArr)
        {
            for (int row = 0; row < jaggedArr.Length; row++)
            {
                int[] rowElements = Console.ReadLine()
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jaggedArr[row] = rowElements;
            }
        }
    }
}
