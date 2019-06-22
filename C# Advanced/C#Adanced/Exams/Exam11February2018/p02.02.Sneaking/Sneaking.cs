namespace p02._02.Sneaking
{
    using System;
    using System.Linq;

    class Sneaking
    {
        static int rowSam;
        static int colSam;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[][] matrix = new char[size][];

            FullTheMatrix(matrix);

            string commands = Console.ReadLine();

            for (int i = 0; i < commands.Length; i++)
            {
                char command = commands[i];

                EnemiesMove(matrix);

                if (matrix[rowSam].Contains('b') &&
                    matrix[rowSam].Contains('S') &&
                    Array.IndexOf(matrix[rowSam], 'b') < colSam)
                {
                    matrix[rowSam][colSam] = 'X';

                    Console.WriteLine(
                            $"Sam died at {rowSam}, {colSam}");
                    break;
                }
                if (matrix[rowSam].Contains('d') &&
                    matrix[rowSam].Contains('S') &&
                    Array.IndexOf(matrix[rowSam], 'd') > colSam)
                {
                    matrix[rowSam][colSam] = 'X';

                    Console.WriteLine(
                        $"Sam died at {rowSam}, {colSam}");
                    break;
                }

                SamMove(matrix, command);

                if (matrix[rowSam].Contains('N') &&
                    matrix[rowSam].Contains('S'))
                {
                    int colN = Array.IndexOf(matrix[rowSam], 'N');

                    matrix[rowSam][colN] = 'X';

                    Console.WriteLine($"Nikoladze killed!");
                    break;
                }
            }

            PrintTheMatrix(matrix);
        }

        static void PrintTheMatrix(char[][] matrix)
        {
            foreach (var line in matrix)
            {
                Console.WriteLine(string.Join("", line));
            }
        }

        static void SamMove(char[][] matrix, char command)
        {
            matrix[rowSam][colSam] = '.';

            switch (command)
            {
                case 'L':
                    colSam--;
                    break;
                case 'R':
                    colSam++;
                    break;
                case 'U':
                    rowSam--;
                    break;
                case 'D':
                    rowSam++;
                    break;
                default:
                    break;
            }

            matrix[rowSam][colSam] = 'S';
        }

        static void EnemiesMove(char[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 'b')
                    {
                        if (j == matrix[i].Length - 1)
                        {
                            matrix[i][j] = 'd';
                        }
                        else
                        {
                            matrix[i][j] = '.';
                            matrix[i][j + 1] = 'b';
                            break;
                        }
                    }
                    else if (matrix[i][j] == 'd')
                    {
                        if (j == 0)
                        {
                            matrix[i][j] = 'b';
                        }
                        else
                        {
                            matrix[i][j] = '.';
                            matrix[i][j - 1] = 'd';
                            break;
                        }
                    }
                }
            }
        }

        static void FullTheMatrix(char[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Trim()
                    .ToCharArray();

                if (matrix[i].Contains('S'))
                {
                    rowSam = i;
                    colSam = Array.IndexOf(matrix[i], 'S');
                }
            }
        }
    }
}