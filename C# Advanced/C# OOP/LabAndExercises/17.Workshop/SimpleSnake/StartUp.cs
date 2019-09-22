namespace SimpleSnake
{
    using NAudio.Wave;

    using Core;
    using GameObjects;
    using Utilities;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();

            //using (WaveOutEvent wavOut = new WaveOutEvent())
            //{
            //    using (var wavReader = new WaveFileReader())
            //    {
            //        wavOut.Init(wavReader);
            //        wavOut.Play();
            //    }
            //}

            Wall wall = new Wall(60, 20);
            Snake snake = new Snake(wall);

            string copyRightText = "Snake game by SoftUni @ C# OOP";

            Console.SetCursorPosition(wall.LeftX - copyRightText.Length, wall.TopY + 1);
            //Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(copyRightText);

            Engine engine = new Engine(wall, snake);
            engine.Run();
        }
    }
}
