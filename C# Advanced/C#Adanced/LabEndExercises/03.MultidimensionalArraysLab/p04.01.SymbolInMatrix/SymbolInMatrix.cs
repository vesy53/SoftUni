namespace p04._01.SymbolInMatrix
{
    using System;

    class SymbolInMatrix
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            FillInThematrix(matrix);

            char searchElement = char.Parse(Console.ReadLine());
            int takeRow = 0;
            int takeCol = 0;
            bool isMatch = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == searchElement)
                    {
                        isMatch = true;
                        takeRow = row;
                        takeCol = col;
                        break;
                    }
                }

                if (isMatch)
                {
                    break;
                }
            }

            string result = isMatch ?
                $"({takeRow}, {takeCol})" :
                $"{searchElement} does not occur in the matrix";

            Console.WriteLine(result);
        }

        private static void FillInThematrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] chars = Console.ReadLine()
                    .ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = chars[col];
                }
            }
        }
    }
}
