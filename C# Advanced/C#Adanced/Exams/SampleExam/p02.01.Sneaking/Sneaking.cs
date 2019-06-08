namespace p02._01.Sneaking
{
    using System;
    using System.Linq;

    class Sneaking
    {
        static char[][] matrix;
        static int rowSam;
        static int colSam;

        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            matrix = new char[rows][];

            rowSam = 0;
            colSam = 0;

            FullTheMatrix();

            string commands = Console.ReadLine();

            for (int i = 0; i < commands.Length; i++)
            {
                char command = commands[i];

                MoveEnemies();

                int colB = Array.IndexOf(matrix[rowSam], 'b');
                int colD = Array.IndexOf(matrix[rowSam], 'd');

                if (matrix[rowSam].Contains('b') &&
                    colB < colSam)
                {
                    SamDied();
                    break;
                }
                else if (matrix[rowSam].Contains('d') &&
                    colD > colSam)
                {
                    SamDied();
                    break;
                }

                MoveSam(command);

                if (matrix[rowSam].Contains('N'))
                {
                    int colNikoladze = Array.IndexOf(matrix[rowSam], 'N');
                    matrix[rowSam][colNikoladze] = 'X';

                    Console.WriteLine($"Nikoladze killed!");
                    break;
                }
            }

            PrintTheResult();
        }

        private static void PrintTheResult()
        {
            foreach (char[] row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static void SamDied()
        {
            matrix[rowSam][colSam] = 'X';

            Console.WriteLine(
                $"Sam died at {rowSam}, {colSam}");
        }

        static void MoveSam(char command)
        {
            matrix[rowSam][colSam] = '.';

            switch (command)
            {
                case 'U':
                    rowSam--;
                    break;
                case 'D':
                    rowSam++;
                    break;
                case 'L':
                    colSam--;
                    break;
                case 'R':
                    colSam++;
                    break;
            }

            matrix[rowSam][colSam] = 'S';
        }

        private static void MoveEnemies()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                if (matrix[row].Contains('b'))
                {
                    int colB = Array.IndexOf(matrix[row], 'b');

                    if (colB == matrix[row].Length - 1)
                    {
                        matrix[row][colB] = 'd';
                    }
                    else
                    {
                        matrix[row][colB] = '.';
                        colB++;
                        matrix[row][colB] = 'b';
                    }
                }
                else if (matrix[row].Contains('d'))
                {
                    int colD = Array.IndexOf(matrix[row], 'd');

                    if (colD == 0)
                    {
                        matrix[row][colD] = 'b';
                    }
                    else
                    {
                        matrix[row][colD] = '.';
                        colD--;
                        matrix[row][colD] = 'd';
                    }
                }
            }
        }

        private static void FullTheMatrix()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .ToCharArray();

                if (matrix[row].Contains('S'))
                {
                    rowSam = row;
                    colSam = Array.IndexOf(matrix[row], 'S');
                }
            }
        }
    }
}
