namespace p02._01.KnightGame
{
    using System;

    class KnightGame
    {
        static char[][] matrix;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            matrix = new char[size][];

            FullTheMatrix();

            int maxRow = 0;
            int maxColumn = 0;
            int maxAtteckPositon = 0;
            int countOfRemovedKnights = 0;

            do
            {
                if (maxAtteckPositon > 0)
                {
                    matrix[maxRow][maxColumn] = '0';
                    maxAtteckPositon = 0;
                    countOfRemovedKnights++;
                }

                int currentAttackPositions = 0;

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (matrix[row][col] == 'K')
                        {
                            currentAttackPositions = CalculateAttackPositions(row, col);

                            if (currentAttackPositions > maxAtteckPositon)
                            {
                                maxAtteckPositon = currentAttackPositions;
                                maxRow = row;
                                maxColumn = col;
                            }
                        }
                    }
                }

            } while (maxAtteckPositon > 0);

            Console.WriteLine(countOfRemovedKnights);
        }

        static int CalculateAttackPositions(int row, int col)
        {
            int currAttackPositions = 0;
            //row-2, col-1;
            if (IsPositionAttacked(row - 2, col - 1))
            {
                currAttackPositions++;
            }
            //row-2, col+1
            if (IsPositionAttacked(row - 2, col + 1))
            {
                currAttackPositions++;
            }
            //row-1, col-2;
            if (IsPositionAttacked(row - 1, col - 2))
            {
                currAttackPositions++;
            }
            //row-1, col+2
            if (IsPositionAttacked(row - 1, col + 2))
            {
                currAttackPositions++;
            }
            //row+1, col-2;
            if (IsPositionAttacked(row + 1, col - 2))
            {
                currAttackPositions++;
            }
            //row+1, col+2
            if (IsPositionAttacked(row + 1, col + 2))
            {
                currAttackPositions++;
            }
            //row+2, col-1;
            if (IsPositionAttacked(row + 2, col - 1))
            {
                currAttackPositions++;
            }
            // row+2, col+1
            if (IsPositionAttacked(row + 2, col + 1))
            {
                currAttackPositions++;
            }

            return currAttackPositions;
        }

        static bool IsPositionAttacked(int row, int col)
        {
            return IsPositionWithBoard(row, col) &&
                matrix[row][col] == 'K';
        }

        static bool IsPositionWithBoard(int row, int col)
        {
            return row >= 0 &&
                   row < matrix.Length &&
                   col >= 0 &&
                   col < matrix[row].Length;
        }

        static void FullTheMatrix()
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Trim()
                    .ToCharArray();
            }
        }
    }
}