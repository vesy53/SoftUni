﻿using System;

namespace p07Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine(
                $"Hello, {firstName} {lastName}. You are {age} years old.");
        }
    }
}
