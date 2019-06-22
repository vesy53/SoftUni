namespace p02._01.Sneaking
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

            foreach (char command in commands)
            {
                EnemiesMove(matrix);

                IsSamAlive(matrix);

                SamMove(matrix, command);

                CheckNikoladze(matrix);
            }
        }

        static void CheckNikoladze(char[][] matrix)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                if (matrix[i].Contains('N') && matrix[i].Contains('S'))
                {
                    int colN = Array.IndexOf(matrix[i], 'N');
                    matrix[i][colN] = 'X';

                    Console.WriteLine($"Nikoladze killed!");

                    PrintTheMatrix(matrix);
                }
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

        static void IsSamAlive(char[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i].Contains('b') &&
                    matrix[i].Contains('S'))
                {
                    int colB = Array.IndexOf(matrix[i], 'b');

                    if (colB < colSam)
                    {
                        matrix[i][colSam] = 'X';

                        Console.WriteLine($"Sam died at {i}, {colSam}");

                        PrintTheMatrix(matrix);
                    }
                }
                else if (matrix[i].Contains('d') &&
                    matrix[i].Contains('S'))
                {
                    int colD = Array.IndexOf(matrix[i], 'd');

                    if (colD > colSam)
                    {
                        matrix[i][colSam] = 'X';

                        Console.WriteLine($"Sam died at {i}, {colSam}");

                        PrintTheMatrix(matrix);
                    }
                }
            }
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
                            matrix[i][++j] = 'b';
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
                            matrix[i][--j] = 'd';
                        }
                    }
                }
            }
        }

        static void PrintTheMatrix(char[][] matrix)
        {
            foreach (var line in matrix)
            {
                Console.WriteLine(string.Join("", line));
            }

            Environment.Exit(0);
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