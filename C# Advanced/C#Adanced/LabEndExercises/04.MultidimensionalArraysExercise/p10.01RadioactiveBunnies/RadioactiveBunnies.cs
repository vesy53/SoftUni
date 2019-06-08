namespace p10._01.RadioactiveBunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RadioactiveBunnies
    {
        static char[][] matrix;
        static int playerRow;
        static int playerCol;
        static bool isOutside;
        static bool isDead;

        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int rows = sizes[0];

            matrix = new char[rows][];

            FillTheMatrix();

            string commands = Console.ReadLine();

            foreach (char command in commands)
            {
                MovePlayer(command);

                MoveBunnies();

                if (isDead)
                {
                    PrintTheMatrix();
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    break;
                }
                else if (isOutside)
                {
                    PrintTheMatrix();
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    break;
                }
            }
        }

        static void PrintTheMatrix()
        {
            foreach (char[] elements in matrix)
            {
                Console.WriteLine(string.Join("", elements));
            }
        }

        static void MovePlayer(char command)
        {
            matrix[playerRow][playerCol] = '.';

            switch (command)
            {
                case 'U':
                    Move(-1, 0);
                    break;
                case 'L':
                    Move(0, -1);
                    break;
                case 'R':
                    Move(0, 1);
                    break;
                case 'D':
                    Move(1, 0);
                    break;
            }
        }

        static void MoveBunnies()
        {
            Queue<int[]> indexes = new Queue<int[]>();

            SearchBunniesIndexes(indexes);

            while (indexes.Count > 0)
            {
                int[] currIndex = indexes.Dequeue();

                int row = currIndex[0];
                int col = currIndex[1];

                if (IsInside(row - 1, col))
                {
                    if (IsPlayer(row - 1, col))
                    {
                        isDead = true;
                    }

                    matrix[row - 1][col] = 'B';
                }

                if (IsInside(row + 1, col))
                {
                    if (IsPlayer(row + 1, col))
                    {
                        isDead = true;
                    }

                    matrix[row + 1][col] = 'B';
                }

                if (IsInside(row, col - 1))
                {
                    if (IsPlayer(row, col - 1))
                    {
                        isDead = true;
                    }

                    matrix[row][col - 1] = 'B';
                }

                if (IsInside(row, col + 1))
                {
                    if (IsPlayer(row, col + 1))
                    {
                        isDead = true;
                    }

                    matrix[row][col + 1] = 'B';
                }
            }
        }

        private static void SearchBunniesIndexes(Queue<int[]> indexes)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 'B')
                    {
                        indexes.Enqueue(new int[] { i, j });
                    }
                }
            }
        }

        static bool IsPlayer(int row, int col)
        {
            return matrix[row][col] == 'P';
        }

        static void Move(int row, int col)
        {
            int targetRow = playerRow + row;
            int targetCol = playerCol + col;

            if (!IsInside(targetRow, targetCol))
            {
                isOutside = true;
            }
            else if (IsBunni(targetRow, targetCol))
            {
                playerRow += row;
                playerCol += col;
                isDead = true;
            }
            else
            {
                playerRow += row;
                playerCol += col;

                matrix[playerRow][playerCol] = 'P';
            }
        }

        static bool IsBunni(int targetRow, int targetCol)
        {
            return matrix[targetRow][targetCol] == 'B';
        }

        static bool IsInside(int row, int col)
        {
            return row >= 0 &&
                   row < matrix.Length &&
                   col >= 0 &&
                   col < matrix[row].Length;
        }

        static void FillTheMatrix()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                char[] elements = Console.ReadLine()
                    .ToCharArray();

                matrix[row] = elements;

                if (matrix[row].Contains('P'))
                {
                    playerRow = row;
                    playerCol = Array.IndexOf(matrix[row], 'P');
                }
            }
        }
    }
}