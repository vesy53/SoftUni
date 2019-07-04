namespace p06._01.Sneaking
{
    using System;
    using System.Linq;

    class Sneaking
    {
        static char[][] room;
        static int[] samPosition;

        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            room = new char[size][];
            samPosition = new int[2];
            samPosition[0] = -1;
            samPosition[1] = -1;

            FullTheMatrix();

            char[] moves = Console.ReadLine()
                .ToCharArray();

            for (int i = 0; i < moves.Length; i++)
            {
                MoveEnemies();

                if (room[samPosition[0]].Contains('b') &&
                    room[samPosition[0]].Contains('S'))
                {
                    int indexB = Array.IndexOf(room[samPosition[0]], 'b');

                    if (indexB < samPosition[1])
                    {
                        room[samPosition[0]][samPosition[1]] = 'X';

                        Console.WriteLine(
                            $"Sam died at {samPosition[0]}, {samPosition[1]}");
                        break;
                    }
                }
                else if (room[samPosition[0]].Contains('d') &&
                    room[samPosition[0]].Contains('S'))
                {
                    int indexD = Array.IndexOf(room[samPosition[0]], 'd');

                    if (indexD > samPosition[1])
                    {
                        room[samPosition[0]][samPosition[1]] = 'X';

                        Console.WriteLine(
                            $"Sam died at {samPosition[0]}, {samPosition[1]}");
                        break;
                    }
                }

                MoveSam(moves, i);

                if (room[samPosition[0]].Contains('N'))
                {
                    NikoladzeIsDead();

                    Console.WriteLine("Nikoladze killed!");
                    break;
                }
            }

            PrintTheMatrix();
        }

        private static void NikoladzeIsDead()
        {
            int colIndexN = Array.IndexOf(room[samPosition[0]], 'N');

            room[samPosition[0]][colIndexN] = 'X';
        }

        private static void SamIsDead()
        {
            room[samPosition[0]][samPosition[1]] = 'X';
        }

        private static void MoveSam(char[] moves, int i)
        {
            room[samPosition[0]][samPosition[1]] = '.';

            switch (moves[i])
            {
                case 'U':
                    samPosition[0]--;
                    break;
                case 'D':
                    samPosition[0]++;
                    break;
                case 'L':
                    samPosition[1]--;
                    break;
                case 'R':
                    samPosition[1]++;
                    break;
                default:
                    break;
            }

            room[samPosition[0]][samPosition[1]] = 'S';
        }

        private static void PrintTheMatrix()
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    Console.Write(room[row][col]);
                }

                Console.WriteLine();
            }
        }

        private static void MoveEnemies()
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'b')
                    {
                        if (IsInTheRange(row, col + 1))
                        {
                            room[row][col] = '.';
                            room[row][col + 1] = 'b';
                            col++;
                        }
                        else
                        {
                            room[row][col] = 'd';
                        }
                    }
                    else if (room[row][col] == 'd')
                    {
                        if (IsInTheRange(row, col - 1))
                        {
                            room[row][col] = '.';
                            room[row][col - 1] = 'd';
                        }
                        else
                        {
                            room[row][col] = 'b';
                        }
                    }
                }
            }
        }

        private static bool IsInTheRange(int row, int col)
        {
            return row >= 0 &&
                   row < room.Length &&
                   col >= 0 &&
                   col < room[row].Length;
        }

        private static void FullTheMatrix()
        {
            for (int row = 0; row < room.Length; row++)
            {
                char[] input = Console.ReadLine()
                    .ToCharArray();

                room[row] = new char[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    room[row][col] = input[col];

                    if (room[row][col] == 'S')
                    {
                        samPosition[0] = row;
                        samPosition[1] = col;
                    }
                }
            }
        }
    }
}