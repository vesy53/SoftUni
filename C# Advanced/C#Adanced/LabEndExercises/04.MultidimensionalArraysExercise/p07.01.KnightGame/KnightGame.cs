namespace p07._01.KnightGame
{
    using System;

    class KnightGame
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[][] matrix = new char[size][];

            FillTheMatrix(matrix);

            int removedHorses = 0;

            while (true)
            {
                int knightRow = -1;
                int knightCol = -1;
                int maxAttack = 0;

                for (int row = 0; row < matrix.Length; row++)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        if (matrix[row][col] == 'K')
                        {
                            int tempAttack = CountAttacks(matrix, row, col);

                            if (tempAttack > maxAttack)
                            {
                                maxAttack = tempAttack;
                                knightRow = row;
                                knightCol = col;
                            }
                        }
                    }
                }

                if (maxAttack > 0)
                {
                    matrix[knightRow][knightCol] = '0';
                    removedHorses++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(removedHorses);
        }

        private static int CountAttacks(char[][] matrix, int row, int col)
        {
            int attacks = 0;

            if (IsInMatrix(row - 1, col - 2, matrix.Length) &&
                matrix[row - 1][col - 2] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row - 1, col + 2, matrix.Length) &&
                matrix[row - 1][col + 2] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row + 1, col - 2, matrix.Length) &&
                matrix[row + 1][col - 2] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row + 1, col + 2, matrix.Length) &&
                matrix[row + 1][col + 2] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row - 2, col - 1, matrix.Length) &&
                matrix[row - 2][col - 1] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row - 2, col + 1, matrix.Length) &&
                matrix[row - 2][col + 1] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row + 2, col - 1, matrix.Length) &&
                matrix[row + 2][col - 1] == 'K')
            {
                attacks++;
            }
            if (IsInMatrix(row + 2, col + 1, matrix.Length) &&
                matrix[row + 2][col + 1] == 'K')
            {
                attacks++;
            }

            return attacks;
        }

        private static bool IsInMatrix(int row, int col, int length)
        {
            return row >= 0 &&
                   row < length &&
                   col >= 0 &&
                   col < length;
        }

        private static void FillTheMatrix(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                char[] elements = Console.ReadLine()
                    .ToCharArray();

                matrix[row] = elements;
            }
        }
    }
}
