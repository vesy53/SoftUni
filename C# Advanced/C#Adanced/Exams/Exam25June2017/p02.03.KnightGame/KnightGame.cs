namespace p02._03.KnightGame
{
    using System;
    using System.Linq;

    class KnightGame
    {
        static char[][] matrix;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            matrix = new char[size][];

            FullTheMatrix(size);

            int removedKnigths = 0;

            while (true)
            {
                int maxCount = 0;
                int targetRow = 0;
                int targetCol = 0;

                for (int row = 0; row < matrix.Length; row++)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        if (matrix[row][col] == 'K')
                        {
                            int currCount = CountTheKnight(row, col);

                            if (currCount > maxCount)
                            {
                                maxCount = currCount;
                                targetRow = row;
                                targetCol = col;
                            }
                        }
                    }
                }

                if (maxCount == 0)
                {
                    break;
                }
                else
                {
                    matrix[targetRow][targetCol] = '0';
                    removedKnigths++;
                }
            }

            Console.WriteLine(removedKnigths);
        }

        static int CountTheKnight(int row, int col)
        {
            int countAttackKnights = 0;

            //row-2, col-1 => up - left
            if (IsPositionAttacked(row - 2, col - 1))
            {
                countAttackKnights++;
            }
            //row-2, col+1 => up - right
            if (IsPositionAttacked(row - 2, col + 1))
            {
                countAttackKnights++;
            }
            //row-1, col-2 => up - left
            if (IsPositionAttacked(row - 1, col - 2))
            {
                countAttackKnights++;
            }
            //row-1, col+2 => up - right
            if (IsPositionAttacked(row - 1, col + 2))
            {
                countAttackKnights++;
            }
            //row+1, col-2 => down - left
            if (IsPositionAttacked(row + 1, col - 2))
            {
                countAttackKnights++;
            }
            //row+1, col+2 => down - right
            if (IsPositionAttacked(row + 1, col + 2))
            {
                countAttackKnights++;
            }
            //row+2, col-1 => down - left
            if (IsPositionAttacked(row + 2, col - 1))
            {
                countAttackKnights++;
            }
            // row+2, col+1 => down - right
            if (IsPositionAttacked(row + 2, col + 1))
            {
                countAttackKnights++;
            }

            return countAttackKnights;
        }

        static bool IsInTheRange(int row, int col)
        {
            return row >= 0 &&
                row < matrix.Length &&
                col >= 0 &&
                col < matrix[row].Length;
        }

        static bool IsPositionAttacked(int row, int col)
        {
            return IsInTheRange(row, col) &&
                matrix[row][col] == 'K';
        }

        private static void FullTheMatrix(int size)
        {
            matrix = matrix
                .Select(m => m = new char[size])
                .Select(m => m = Console.ReadLine()
                                        .ToCharArray())
                .ToArray();
        }
    }
}