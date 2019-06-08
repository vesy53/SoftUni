namespace p07._01.PascalTriangle
{
    using System;

    class PascalTriangle
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            long[][] jaggedArray = new long[size][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                jaggedArray[row] = new long[row + 1];
            }

            jaggedArray[0][0] = 1;

            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    jaggedArray[row + 1][col] += jaggedArray[row][col];

                    jaggedArray[row + 1][col + 1] += jaggedArray[row][col];
                }
            }

            foreach (long[] row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}