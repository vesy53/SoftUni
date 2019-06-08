namespace p07._02.KnightGame
{
    using System;

    class KnightGame
    {
        static char[][] matrix;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            matrix = new char[size][];

            FillTheMatrix();

            int removedKnight = 0;

            while (true)
            {
                int maxAttack = 0;
                int rowKnight = 0;
                int colKnight = 0;

                for (int row = 0; row < matrix.Length; row++)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        if (matrix[row][col] == 'K')
                        {
                            int countAttack = CountAttacks(row, col);

                            if (countAttack > maxAttack)
                            {
                                maxAttack = countAttack;
                                rowKnight = row;
                                colKnight = col;
                            }
                        }
                    }
                }

                if (maxAttack == 0)
                {
                    break;
                }
                else
                {
                    matrix[rowKnight][colKnight] = '0';
                    removedKnight++;
                }
            }

            Console.WriteLine(removedKnight);
        }

        private static int CountAttacks(int row, int col)
        {
            int countAttacks = 0;

            if (IsInTheRange(row - 2, col - 1) &&
                matrix[row - 2][col - 1] == 'K')
            {
                countAttacks++;
            }

            if (IsInTheRange(row - 2, col + 1) &&
                matrix[row - 2][col + 1] == 'K')
            {
                countAttacks++;
            }

            if (IsInTheRange(row + 2, col - 1) &&
                matrix[row + 2][col - 1] == 'K')
            {
                countAttacks++;
            }

            if (IsInTheRange(row + 2, col + 1) &&
                matrix[row + 2][col + 1] == 'K')
            {
                countAttacks++;
            }

            if (IsInTheRange(row - 1, col + 2) &&
                matrix[row - 1][col + 2] == 'K')
            {
                countAttacks++;
            }
            if (IsInTheRange(row + 1, col + 2) &&
                matrix[row + 1][col + 2] == 'K')
            {
                countAttacks++;
            }

            if (IsInTheRange(row - 1, col - 2) &&
                matrix[row - 1][col - 2] == 'K')
            {
                countAttacks++;
            }

            if (IsInTheRange(row + 1, col - 2) &&
                matrix[row + 1][col - 2] == 'K')
            {
                countAttacks++;
            }

            return countAttacks;
        }

        private static bool IsInTheRange(int row, int col)
        {
            return row >= 0 &&
                   row < matrix.Length &&
                   col >= 0 &&
                   col < matrix[row].Length;
        }

        private static void FillTheMatrix()
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